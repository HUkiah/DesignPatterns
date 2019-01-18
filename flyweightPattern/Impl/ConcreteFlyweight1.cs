using System;
using System.Collections.Generic;
using System.Text;

namespace flyweightPattern.Impl
{
    public class ConcreteFlyweight1 : Flyweight
    {
        public ConcreteFlyweight1():base()
        {
        }

        public ConcreteFlyweight1(string _Extrinsic):base(_Extrinsic)
        {
            
        }

        public override void operate()
        {
            throw new NotImplementedException();
        }
    }
}
