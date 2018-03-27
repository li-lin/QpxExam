using System;
using System.Collections.Generic;
using System.Text;

namespace QpxExam.Data.Entities
{
    /// <summary>
    /// 学生参加一场考试，包括学生选题、作答和得分。
    /// </summary>
    public class StudentExamination
    {
        public int Id { get; set; }
        public Examination Examination { get; set; }
        public Student Student { get; set; }        
        public Paper Paper { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime SubmitTime { get; set; }
        public string Answer { get; set; }
        public double Score { get; set; }
    }
}
