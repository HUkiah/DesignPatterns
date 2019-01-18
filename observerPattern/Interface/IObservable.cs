using System;
using System.Collections.Generic;
using System.Text;

namespace observerPattern.Interface
{
    public interface IObservable
    {
        void AddObserver(IObserver observer);
        void DeleteObserver(IObserver observer);
        void NotifyObserver(string context);
    }
}
