﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰者模式.书上的实现
{
    abstract class CondimentDecorator : Beverage
    {
        public override decimal Cost()
        {
            throw new NotImplementedException();
        }
    }
}
