using strategyPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace strategyPattern.Impl
{
    public class BackDoor : Strategy
    {
        public void Operate()
        {
            Console.WriteLine("");
        }
    }
}
