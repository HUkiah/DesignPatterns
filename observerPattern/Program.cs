using observerPattern.Impl;
using System;

namespace observerPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var lisi = new LiSi();
            var hanfeizi = new HanFeizi();
            hanfeizi.AddObserver(lisi);
            hanfeizi.haveBreakfast();
            hanfeizi.haveFun();
            hanfeizi.haveBreakfast();
            Console.ReadKey();
        }
    }
}
