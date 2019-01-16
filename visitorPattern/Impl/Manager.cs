using System;
using System.Collections.Generic;
using System.Text;
using iteratorPattern.Interface;

namespace iteratorPattern.Impl
{
    public class Manager:Employee
    {
        public string Performance;
        public string GetPerformance()
        {
            return Performance;
        }
        public void SetPerformance(string performance)
        {
            Performance = performance;
        }

        public override void accept(IVisitor visitor)
        {
            visitor.visit(this);
        }
    }
}
