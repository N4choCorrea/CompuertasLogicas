using System;
using System.Collections.Generic;

namespace Library 
{
    public class OrGate : Gate
    {
        public OrGate(string name) : base(name)
        {
        }
        public override bool Calculate()
        {
            if (this.Inputs.Count< 2)
            {
                throw new GateExceptions("OrGate must have at least two inputs");
            }
            return this.Inputs[0].Calculate() || this.Inputs[1].Calculate();
            bool result = false;
            foreach (IInput input in this.Inputs)
            {
                result = result || input.Calculate();
            }
            return result;
        }
        
        
    }
}