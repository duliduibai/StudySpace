using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象类Test
{
    class Program
    {
        static void Main(string[] args)
        {
            AbsTest a = new A();
            Console.WriteLine(a.GetName());

            AbsTestEx b = new B();
            Console.WriteLine(b.GetName());

            Console.ReadLine();
        }
    }

    abstract class AbsTest
    {
        public virtual string GetName()
        {
            return "AbsTest";
        }
    }
    abstract class AbsTestEx : AbsTest
    {
        //public new abstract string GetName();
    }

    class A : AbsTestEx
    {
        public override string GetName()
        {
            return "A";
        }
    }
    class B : AbsTestEx
    {
        public override string GetName()
        {
            return "B";
        }
    }
}
