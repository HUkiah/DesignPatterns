using System;
using System.Collections.Generic;
using System.Text;

namespace flyweightPattern.Impl
{
    public abstract class Flyweight
    {
        private string intrinsic;
        protected readonly string Extrinsic;
        public Flyweight(string _Extrinsic)
        {
            Extrinsic = _Extrinsic;
        }

        public Flyweight()
        { }

        public abstract void operate();

        public string GetIntrinsic()
        {
            return intrinsic;
        }

        public void SetIntrinsic(string _intrinsic)
        {
            intrinsic = _intrinsic;
        }
    }
}
