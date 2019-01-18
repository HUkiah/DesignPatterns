using System;
using System.Collections.Generic;
using System.Text;

namespace flyweightPattern.Impl
{
    public class FlyweightFactory
    {
        private static Dictionary<string, Flyweight> pool
            = new Dictionary<string, Flyweight>();

        private static Dictionary<ExtrinsicState, Flyweight> pool1
            = new Dictionary<ExtrinsicState, Flyweight>();

        public static Flyweight GetFlyweight(ExtrinsicState extrinsicState)
        {
            Flyweight flyweight = null;
            if (!pool1.ContainsKey(extrinsicState))
            {
                flyweight = new ConcreteFlyweight1();
                pool1.TryAdd(extrinsicState, flyweight);
            }
            else
            {
                pool1.TryGetValue(extrinsicState, out flyweight);
            }
            return flyweight;
        }

        public static Flyweight GetFlyweight(string Extrinsic)
        {
            Flyweight flyweight = null;
            if (pool.ContainsKey(Extrinsic))
            {
                pool.TryGetValue(Extrinsic, out flyweight);
            }
            else
            {
                flyweight = new ConcreteFlyweight1(Extrinsic);
                pool.TryAdd(Extrinsic, flyweight);
            }

            return flyweight;
        }


    }
}
