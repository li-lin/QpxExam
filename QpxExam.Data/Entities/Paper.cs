using System;
using System.Collections.Generic;
using System.Text;

namespace QpxExam.Data.Entities
{
    /// <summary>
    /// 试卷，描述了一张试卷的模型。
    /// </summary>
    public class Paper
    {
        public int Id { get; set; }
        public string PaperNumber { get; set; } //试卷编号，如A卷、B卷等。
        public string Title { get; set; } //试卷标题
        public string Term { get; set; } //试卷对应的学期
        public DateTime CreateDate { get; set; }
        public string Description { get; set; } //试卷描述

        public Teacher Teacher { get; set; }
        public Course Course { get; set; }
        public IList<Question> Questions { get; set; }
    }
}
