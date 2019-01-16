using iteratorPattern.Impl;
using System;
using System.Collections.Generic;
using System.Text;

namespace iteratorPattern.Interface
{
    public interface IVisitor
    {
        void visit(Manager manager);
        void visit(CommonEmployee commonEmployee);
    }
}
