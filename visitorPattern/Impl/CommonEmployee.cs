using System;
using System.Collections.Generic;
using System.Text;
using iteratorPattern.Interface;

namespace iteratorPattern.Impl
{
    public class CommonEmployee:Employee
    {
        private string Job;
        public string GetJob()
        {
            return Job;
        }
        public void SetJob(string job)
        {
            Job = job;
        }

        public override void accept(IVisitor visitor)
        {
            visitor.visit(this);
        }
    }
}
