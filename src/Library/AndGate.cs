using System;
using System.Collections.Generic;

namespace Library
{
    /// <summary>
    /// Esta junto a la clase NotGate, OrGate, aplican el patron expert, porque son expertos parciales que comparten
    /// la responsbilidad de calcular el resultado de la compuerta.
    /// </summary>
    public class AndGate : Gate
    {
        
        public AndGate(string name) : base(name)
        {
        }
        public override bool Calculate()
        {
            bool result = true;
            foreach (IInput input in this.Inputs)
            {
                result = result && input.Calculate();
            }
            return result;
        }
        public bool Main()
        {   
        try 
        {
            return this.Inputs[0].Calculate() && this.Inputs[1].Calculate();
        }
        catch (System.IndexOutOfRangeException)
        {
            throw new System.IndexOutOfRangeException("AndGate must have at least two inputs");
            
        }

        }
        
    }
}