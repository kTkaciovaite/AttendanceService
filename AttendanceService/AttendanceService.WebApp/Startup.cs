using AttendanceService.WebApp.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(AttendanceService.WebApp.Startup))]

namespace AttendanceService.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            _createRolesAndUsers();
        }

        private void _createRolesAndUsers()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            if (!roleManager.RoleExists("Admin"))
            {
                var role = new IdentityRole
                {
                    Name = "Admin"
                };
                roleManager.Create(role);
            }

            if (!roleManager.RoleExists("Manager"))
            {
                var role = new IdentityRole
                {
                    Name = "Manager"
                };
                roleManager.Create(role);
            }

            if (!roleManager.RoleExists("Lecturer"))
            {
                var role = new IdentityRole
                {
                    Name = "Lecturer"
                };
                roleManager.Create(role);

                var user = new ApplicationUser
                {
                    UserName = "vardas1.pavarde1",
                    Email = "vardas1.pavarde1@vgtu.lt"
                };

                string userPWD = "Abcd.1234";

                var userChecker = UserManager.Create(user, userPWD);

                if (userChecker.Succeeded)
                {
                    var result1 = UserManager.AddToRole(user.Id, "Lecturer");
                }
            }

            if (!roleManager.RoleExists("Student"))
            {
                var role = new IdentityRole
                {
                    Name = "Student"
                };
                roleManager.Create(role);

                var user = new ApplicationUser
                {
                    UserName = "karolina.tkaciovaite",
                    Email = "karolina.tkaciovaite@stud.vgtu.lt"
                };

                string userPWD = "Abcd.1234";

                var userChecker = UserManager.Create(user, userPWD);

                if (userChecker.Succeeded)
                {
                    var result1 = UserManager.AddToRole(user.Id, "Student");

                }
            }
        }
    }
}
