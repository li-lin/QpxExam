using System;
using System.Collections.Generic;

namespace QpxExam.Data.Entities
{
    /// <summary>
    /// 学生
    /// </summary>
    public class Student
    {
        public int Id { get; set; }
        public string StudentNumber { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public IList<StudentExamination> Exams { get; set; }
    }
}
