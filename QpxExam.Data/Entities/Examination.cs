using System;
using System.Collections.Generic;
using System.Text;
using QpxExam.Data.CustType;

namespace QpxExam.Data.Entities
{
    /// <summary>
    /// 考试，描述了一场考试的模型。
    /// </summary>
    public class Examination
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ExaminationState State { get; set; }

        public Course Course;
        public IList<GradeMajorClass> Targets { get; set; }
        public IList<Paper> Papers { get; set; }
        public IList<StudentExamination> Students { get; set; }
    }
}
