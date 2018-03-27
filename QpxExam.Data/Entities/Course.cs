using System;
using System.Collections.Generic;
using System.Text;

namespace QpxExam.Data.Entities
{
    /// <summary>
    /// 课程，描述了一门课程的模型。
    /// </summary>
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public IList<Paper> Papers { get; set; }
    }
}
