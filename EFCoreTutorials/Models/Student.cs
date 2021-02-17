using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreTutorials.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        public int? GradeId { get; set; }
        public Grade Grade { get; set; }

        public Student()
        {
            StudentId = 0;
            Name = string.Empty;
            GradeId = 0;
        }
    }
}
