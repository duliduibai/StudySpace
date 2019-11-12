using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 观察者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            NewspaperOffice newspaperOffice = new NewspaperOffice();
            IObserver obs1 = new RailwayStation();
            IObserver obs2 = new Someone();
            IObserver obs3 = new School();
            newspaperOffice.AddObserver(obs1);
            newspaperOffice.AddObserver(obs2);
            newspaperOffice.AddObserver(obs3);
            newspaperOffice.PostNews();
            newspaperOffice.RemoveObserver(obs3);
            newspaperOffice.PostNews();
            Console.ReadLine();
        }
    }
}
