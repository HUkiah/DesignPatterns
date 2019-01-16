using iteratorPattern.Impl;
using System;
using System.Collections.Generic;

namespace iteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var emp in mockEmployee())
            {
                emp.accept(new Visitor());
            }
            Console.ReadKey();
        }

        static List<Employee> mockEmployee()
        {
            var emplist = new List<Employee>();
            var zhangsan = new CommonEmployee();
            zhangsan.SetName("张三");
            zhangsan.SetSalary(10000);
            zhangsan.SetJob("编写C#代码。！");
            emplist.Add(zhangsan);

            var lisi = new CommonEmployee();
            lisi.SetName("李四");
            lisi.SetSalary(10000);
            lisi.SetJob("编写python代码。！");
            emplist.Add(lisi);

            var wangwu = new Manager();
            wangwu.SetName("王五");
            wangwu.SetSalary(20000);
            wangwu.SetPerformance("绝对不是负值，我们持平。！");
            emplist.Add(wangwu);

            return emplist;
        }
    }
}
