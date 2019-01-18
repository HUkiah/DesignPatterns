using System;
using System.Collections.Generic;
using System.Text;

namespace flyweightPattern.Impl
{
    public class ExtrinsicState
    {
        private string subject;
        private string location;
        public string GetSubject()
        {
            return subject;
        }
        public void SetSubject(string _subject)
        {
            subject = _subject;
        }

        public string GetLocation()
        {
            return location;
        }
        public void SetLocation(string _location)
        {
            location = _location;
        }

        public override bool Equals(object obj)
        {
            if (obj is ExtrinsicState)
            {
                var state = (ExtrinsicState)obj;
                return state.GetLocation().Equals(location) && state.GetSubject().Equals(subject);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return subject.GetHashCode()+location.GetHashCode();
        }
    }
}
