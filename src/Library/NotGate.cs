using System;
using System.Collections.Generic;

namespace Library
{
    public class NotGate : Gate
    {
        public NotGate(string name) : base(name)
        {
        }
        public override bool Calculate()
        {
            return !this.Inputs[0].Calculate();
        }
        public bool  Main()
        {
            try 
            {
                return !this.Inputs[0].Calculate();
            }
            catch (System.IndexOutOfRangeException)
            {
                throw new System.IndexOutOfRangeException("NotGate must have at least one input");
                
            }
        }
    }
}