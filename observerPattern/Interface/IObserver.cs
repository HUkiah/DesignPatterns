using System;
using System.Collections.Generic;
using System.Text;

namespace observerPattern.Interface
{
    public interface IObserver
    {
        void Update(string context);
    }
}
