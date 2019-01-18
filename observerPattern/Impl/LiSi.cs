using observerPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace observerPattern.Impl
{
    public class LiSi : IObserver
    {
        public void Update(string context)
        {
            Console.WriteLine("李斯：观察到韩非子活动，开始像秦老板报告...");

            Console.WriteLine("李斯:汇报完毕...");
        }

        public void report(string context)
        {
            Console.WriteLine("李斯：报告！韩非子有活动了-->" + context);
        }
    }
}
