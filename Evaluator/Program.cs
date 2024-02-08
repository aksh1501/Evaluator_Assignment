// See https://aka.ms/new-console-template for more information
using System;
using Expression;
using  Operand;
using Operator;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Calculator!");

        Console.WriteLine("Output for (2 + 3) + ((2 * 3) - 5) = " + new Add(new Add(new OperandC(2), new OperandC(3)), new Subtract(new Multiply(new OperandC(2), new OperandC(3)), new OperandC(5))).eval());
    }
}