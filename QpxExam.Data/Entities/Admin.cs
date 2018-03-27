using System;
using System.Collections.Generic;
using System.Text;

namespace QpxExam.Data.Entities
{
    /// <summary>
    /// 管理员
    /// </summary>
    public class Admin
    {
        public int Id { get; set; }
        public string AdminNumber { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastLoginDate { get; set; }
    }
}
