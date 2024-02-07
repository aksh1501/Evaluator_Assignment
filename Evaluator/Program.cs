// See https://aka.ms/new-console-template for more information
using System;
using Expression;
using  Operand;
using Operator;

Console.WriteLine("Welcome to Calculator!");



IExpression num2 = new OperandC(2);
IExpression num5=  new OperandC(5);
IExpression num3=  new OperandC(3);

IExpression exp1= new OperatorC('+',num2,num3);
Console.WriteLine(exp1.eval());

IExpression exp2= new OperatorC('*',num2,num3);
IExpression exp3= new OperatorC('-',exp2,num5);
IExpression exp= new OperatorC('+',exp1,exp3);

Console.WriteLine("Output for (2 + 3) + ((2 * 3) - 5) = " + exp.eval());
