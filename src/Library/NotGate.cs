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
            if (this.Inputs.Count < 1)
            {
                throw new GateExceptions("NotGate must have at least one input");
            }
            return !this.Inputs[0].Calculate();
        }
    }
}