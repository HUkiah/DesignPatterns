using observerPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace observerPattern.Impl
{
    public class HanFeizi : IObservable
    {
        private IList<IObserver> observerList 
            = new List<IObserver>();

        public void AddObserver(IObserver observer)
        {
            observerList.Add(observer);
        }

        public void DeleteObserver(IObserver observer)
        {
            observerList.Remove(observer);
        }

        public void NotifyObserver(string context)
        {
            foreach (var ob in observerList)
            {
                ob.Update(context);
            }
        }

        public void haveBreakfast()
        {
            Console.WriteLine("韩非子：开始吃饭了...");
            NotifyObserver("韩非子在吃饭");
        }

        public void haveFun()
        {
            Console.WriteLine("韩非子：开始娱乐了...");
            NotifyObserver("韩非子在娱乐");
        }
    }
}
