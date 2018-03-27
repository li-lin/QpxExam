using System;
using System.Collections.Generic;
using System.Text;

namespace QpxExam.Data.CustType
{
    /// <summary>
    /// 考试状态，包括未开始，进行中和已结束。
    /// </summary>
    public enum ExaminationState
    {
        NotStarted,
        Running,
        Finished
    }
}
