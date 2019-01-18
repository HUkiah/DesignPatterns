using System;
using System.Collections.Generic;
using System.Text;

namespace flyweightPattern.Impl
{
    public class ConcreteFlyweight2 : Flyweight
    {
        public ConcreteFlyweight2(string _Extrinsic) : base(_Extrinsic)
        {

        }

        public override void operate()
        {
            throw new NotImplementedException();
        }
    }

}
