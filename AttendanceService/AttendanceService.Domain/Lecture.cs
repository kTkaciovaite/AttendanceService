﻿using System;
using System.Collections.Generic;

namespace AttendanceService.Domain
{
    public class Lecture
    {
        public int Id { get; set; }

        // public bool IsAttended { get; set; }

        public Auditorium Auditorium { get; set; }

        public Lecturer Lecturer { get; set; }

        public LectureTime LectureTime { get; set; }

        public LectureType LectureType { get; set; }

        public Subject Subject { get; set; }

        public List<Occurrence> Occurrences { get; set; }
    }
}
