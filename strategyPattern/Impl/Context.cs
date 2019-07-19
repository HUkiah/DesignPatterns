using strategyPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace strategyPattern.Impl
{
    public class Context
    {
        private Strategy strategy;

        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }

        public void operate()
        {
            this.strategy.Operate();
        }
    }
}
