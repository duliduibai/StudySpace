using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Account
    {
        /// <summary>
        /// 时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 单号
        /// </summary>
        public string AccountNo { get; set; }
        /// <summary>
        /// 设计师
        /// </summary>
        public string DesignerName { get; set; }
        public string DesignerNo { get; set; }
        /// <summary>
        /// 助理
        /// </summary>
        public string AssistDesignName { get; set; }
        public string AssistDesignNo { get; set; }
        /// <summary>
        /// 技师
        /// </summary>
        public string TechnicianName { get; set; }
        public string TechnicianNo { get; set; }
        /// <summary>
        /// 洗吹
        /// </summary>
        public decimal WashBlow { get; set; }
        /// <summary>
        /// 烫发
        /// </summary>
        public decimal Perm { get; set; }
        /// <summary>
        /// 洗剪吹
        /// </summary>
        public decimal WashCutBlow { get; set; }
        /// <summary>
        /// 染色
        /// </summary>
        public decimal Dye { get; set; }
        /// <summary>
        /// 吸剪吹
        /// </summary>
        public decimal InhaleCutBlow { get; set; }
        /// <summary>
        /// 直发
        /// </summary>
        public decimal Straight { get; set; }
        /// <summary>
        /// 儿童剪
        /// </summary>
        public decimal ChildCut { get; set; }
        /// <summary>
        /// 接发
        /// </summary>
        public decimal TransHair { get; set; }
        /// <summary>
        /// 造型
        /// </summary>
        public decimal Style { get; set; }
        /// <summary>
        /// 护发
        /// </summary>
        public decimal HairCare { get; set; }
        /// <summary>
        /// 其他
        /// </summary>
        public decimal Other { get; set; }
        /// <summary>
        /// 支付方式:1支付宝;2微信
        /// </summary>
        public int PayWay { get; set; }
        /// <summary>
        /// 现金合计
        /// </summary>
        public decimal CashTotal { get; set; }
        public bool IsVIP { get; set; }
        public string VIPNo { get; set; }
        public decimal VIPBalance { get; set; }
    }
}
