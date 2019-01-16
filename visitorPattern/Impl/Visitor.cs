using iteratorPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace iteratorPattern.Impl
{
    public class Visitor : IVisitor
    {
        public void visit(Manager manager)
        {
            Console.WriteLine(this.GetManagerInfo(manager));
        }

        public void visit(CommonEmployee commonEmployee)
        {
            Console.WriteLine(this.GetCommonEmployee(commonEmployee));
        }

        private string GetBasicInfo(Employee employee)
        {
            string info = "姓名：" + employee.GetName() + "\t";
            info += "工资：" + employee.GetSalary() + "\t";
            return info;
        }

        private string GetCommonEmployee(CommonEmployee commonEmployee)
        {
            string basicInfo = this.GetBasicInfo(commonEmployee);
            basicInfo += "工作：" + commonEmployee.GetJob()+"\t";
            return basicInfo;
        }
        private string GetManagerInfo(Manager manager)
        {
            string basicInfo = GetBasicInfo(manager);
            basicInfo += "业绩：" + manager.GetPerformance() + "\t";
            return basicInfo;
        }
    }
}
