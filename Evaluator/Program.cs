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

        IExpression num2 = new OperandC(2);
        IExpression num5 = new OperandC(5);
        IExpression num3 = new OperandC(3);

        IExpression exp1 = new Add(num2, num3);
        IExpression exp2 = new Multiply(num2, num3);
        IExpression exp3 = new Subtract(exp2, num5);
        IExpression exp = new Add(exp1, exp3);

        Console.WriteLine("Output for (2 + 3) + ((2 * 3) - 5) = " + exp.eval());
    }
}