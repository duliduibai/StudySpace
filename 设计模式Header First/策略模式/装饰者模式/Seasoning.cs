using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰者模式
{
    /// <summary>
    /// 调料
    /// </summary>
    public class Seasoning
    {
        /// <summary>
        /// 调料名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 单份调料价格
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// 调料数量
        /// </summary>
        public double Amount { get; set; }
        /// <summary>
        /// 调料描述
        /// </summary>
        public string Comment { get; set; }
    }
}
