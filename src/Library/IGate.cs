using System;
using System.Collections.Generic;

namespace Library
{
    public interface IGate
    {
        public void AddInput(IInput Iinput); 
       public bool Calculate(); 
    }
}