using System;
using System.Collections.Generic;

namespace Library
{
    /// <summary>
    /// Se aplica el principio ISP ya que depende de una interface con una sola responsabilidad especifica.
    /// </summary>
    public class LogicInput : IInput
    {
        public bool Value { get; set; }
        public LogicInput(bool value)
        {
            this.Value = value;
        }
        public bool Calculate()
        {
            return this.Value;
        }
    }
}