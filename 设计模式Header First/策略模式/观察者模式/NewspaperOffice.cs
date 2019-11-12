using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 观察者模式
{
    public class NewspaperOffice
    {
        List<IObserver> observers = new List<IObserver>();
        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }
        public void RemoveObserver(IObserver observer)
        {
            if (observers.IndexOf(observer) != -1)
            {
                observers.Remove(observer);
            }
        }

        public void PostNews()
        {
            Console.WriteLine("各位,我们报社POST最新报纸了");
            foreach (var item in observers)
            {
                item.RecevieData();
            }
        }
    }
}
