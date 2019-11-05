using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            new CreateDelegate().ChainDelegateDemo(new CreateDelegate());
            Console.ReadLine();
        }
    }
}
