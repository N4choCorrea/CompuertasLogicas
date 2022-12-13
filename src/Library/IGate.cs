using System;
using System.Collections.Generic;

namespace Library
{
    public interface IGate
    {
        public void AddInput(Gate Iinput); 
       public bool Calculate(); 
    }
}