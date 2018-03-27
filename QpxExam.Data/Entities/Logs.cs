using System;
using System.Collections.Generic;
using System.Text;

namespace QpxExam.Data.Entities
{
    /// <summary>
    /// 日志
    /// </summary>
    public class Logs
    {
        public int Id { get; set; }
        public string Who { get; set; }
        public string Actor { get; set; }
        public string Do { get; set; }
        public string Module { get; set; }
        public DateTime LogDate { get; set; }
    }
}
