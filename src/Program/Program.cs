//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

using Library;
public class Program
{
    public static void Main(string[] args)
{
    AndGate andGate = new AndGate("andGate");
    NotGate notGate = new NotGate("notGate");
    OrGate orGate = new OrGate("orGate");
    IInput input1 = new LogicInput(true);
    IInput input2 = new LogicInput(false);
    IInput input3 = new LogicInput(true);
    andGate.AddInput(input1);
    andGate.AddInput(input2);
    orGate.AddInput(input3);
    orGate.AddInput(andGate);
    notGate.AddInput(orGate);
    Console.WriteLine(notGate.Calculate());
}
}

