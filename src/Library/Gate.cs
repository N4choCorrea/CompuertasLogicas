using System;
using System.Collections.Generic;

namespace Library
{
    /// <summary>
    /// Se puede ver el principio de OCP ya que esta clase es abierta a la extension pero cerrada a la modificacion.	
    /// Y tambien se puede ver el principio de Dip ya que esta clase no depende de clases concretas sino de interfaces, queremos introducir
    /// una abstracion.
    /// </summary>
    public abstract class Gate :IInput, IGate
    {
        public string name { get; set; }
        public List<IInput> Inputs { get; set; }
        public Gate (string name)
        {
            if (string.IsNullOrEmpty(name)) 
            {
                throw new ArgumentNullException("name");
            }
            this.name = name;
            this.Inputs = new List<IInput>();
        
            
        }
        public void AddInput(IInput Iinput)
        {
            this.Inputs.Add(Iinput);
        }
        /// <summary>
        /// Este metodo Calculate usa el patron PolyMorfismo porque se define se define en esta clase como abstracto y se usa diferente
        /// dependiendo la compuerta que se este usando.Sobreescribe el metodo calculate. 
        /// </summary>
        /// <returns></returns>
        public abstract bool Calculate();
    
    }
}

