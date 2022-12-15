using System;
namespace Library
{
    public class GateExceptions : Exception
    {
        public GateExceptions(string message) : base(message)
        {
        }
    }
}