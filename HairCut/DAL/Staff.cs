using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Staff
    {
        public int StaffNo { get; set; }
        public string StaffName { get; set; }
        /// <summary>
        /// 0-不确定，1-男，2-女
        /// </summary>
        public int Gender { get; set; }
        public int Age { get; set; }
        public string TypeName { get; set; }
        public override string ToString()
        {
            return this.StaffName;
        }
    }
}
