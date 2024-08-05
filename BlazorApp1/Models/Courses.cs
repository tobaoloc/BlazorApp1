﻿using BlazorApp1.Data;

namespace BlazorApp1.Models
{
    public class Courses
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int SemesterId { get; set; }
        public string LectureId { get; set; }
        public int SubjectId { get; set; }
        //xnxx//
        public Semesters Semester { get; set; }
        public ApplicationUser Lecture { get; set; }
        public Subjects Subject { get; set; }

    }
}
