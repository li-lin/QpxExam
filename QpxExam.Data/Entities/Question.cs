using System;
using QpxExam.Data.CustType;

namespace QpxExam.Data.Entities
{
    /// <summary>
    /// 试题，描述了一道题的模型。
    /// </summary>
    public class Question
    {
        public int Id { get; set; }
        public QuestionType Type { get; set; }
        public string Title { get; set; }
        public string Content { get; set; } //选择题才有Content。
        public string Answer { get; set; }
        public QuestionDifficulty Difficulty { get; set; }
        public int Score { get; set; }
        public int Rights { get; set; }
        public int Wrongs { get; set; }
        public Paper Paper { get; set; }
    }
}
