using System;
using System.Collections.Generic;
using System.Text;

namespace QpxExam.Data.Entities
{
    /// <summary>
    /// 教师
    /// </summary>
    public class Teacher
    {
        public int Id { get; set; }
        public string TeacherNumber { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public IList<Paper> Papers { get; set; }
    }
}
