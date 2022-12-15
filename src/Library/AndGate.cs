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
            //las excepciones en los meteodos son mejores con if y catch, en el program principal se pueden usar try y catch
            bool result = true;
            foreach (IInput input in this.Inputs)
            {
                result = result && input.Calculate();
            }
            return result;
        }
        public bool Main()
        {   
        if (this.Inputs.Count < 2)
        {
        
            throw new GateExceptions("AndGate must have at least two inputs");
        }
        return this.Inputs[0].Calculate() && this.Inputs[1].Calculate();
        }
       
        
        
    }
}