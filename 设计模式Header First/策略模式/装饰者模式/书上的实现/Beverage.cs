using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰者模式.书上的实现
{
    /// <summary>
    /// 饮料父类——基本组件，所有的装饰者和被装饰对象都要继承于此
    /// </summary>
    public abstract class Beverage
    {
        protected string description = "Unknown Beverage";
        public virtual string GetDescription()
        {
            return description;
        }
        public abstract decimal Cost();
    }
}
