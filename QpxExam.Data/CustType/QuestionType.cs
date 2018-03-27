using System;
using System.Collections.Generic;
using System.Text;

namespace QpxExam.Data.CustType
{
    /// <summary>
    /// 试题类型，包括填空题，单选题，多选题，判断题和综合题。
    /// </summary>
    public enum QuestionType
    {
        /// <summary>
        /// 填空题
        /// </summary>
        FillingBlank = 1,
        /// <summary>
        /// 单选题
        /// </summary>
        SingleChoice,
        /// <summary>
        /// 多选题
        /// </summary>
        MultiChoice,
        /// <summary>
        /// 判断题
        /// </summary>
        Judgement,
        /// <summary>
        /// 综合题
        /// </summary>
        Complex
    }
}
