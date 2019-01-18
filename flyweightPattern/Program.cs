using flyweightPattern.Impl;
using System;
using System.Diagnostics;

namespace flyweightPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 字符串 外部
            //string key1 = "科目1上海";
            //string key2 = "科目1上海";

            //FlyweightFactory.GetFlyweight(key1);
            //var sw = Stopwatch.StartNew();
            //for (int i = 0; i < 1000000; i++)
            //{
            //    FlyweightFactory.GetFlyweight(key2);
            //}
            //Console.WriteLine("Time: {0}ms", sw.ElapsedMilliseconds);
            #endregion
            ExtrinsicState state1 = new ExtrinsicState();
            state1.SetSubject("科目1");
            state1.SetLocation("上海");
            FlyweightFactory.GetFlyweight(state1);

            ExtrinsicState state2 = new ExtrinsicState();
            state2.SetSubject("科目1");
            state2.SetLocation("上海");

            var sw = Stopwatch.StartNew();
            for (int i = 0; i < 1000000; i++)
            {
                FlyweightFactory.GetFlyweight(state2);
            }
            Console.WriteLine("Time: {0}ms", sw.ElapsedMilliseconds);

            Console.ReadKey();
        }
    }
}
