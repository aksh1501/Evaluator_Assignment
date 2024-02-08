using Expression;
using System;

namespace Operator
{
    interface IOperator : IExpression
    {
    }

    class Add: IOperator
    {
        private IExpression leftExp;
        private IExpression rightExp;

        public Add(IExpression leftExp, IExpression rightExp)
        {
            this.leftExp=leftExp;
            this.rightExp=rightExp;
        }

        public double eval(){
            return leftExp.eval() + rightExp.eval();
        }
    }

    class Subtract: IOperator
    {
        private IExpression leftExp;
        private IExpression rightExp;

        public Subtract(IExpression leftExp, IExpression rightExp)
        {
            this.leftExp=leftExp;
            this.rightExp=rightExp;
        }

        public double eval()
        {
            return leftExp.eval() - rightExp.eval();
        }
    }


    class Multiply: IOperator
    {
        private IExpression leftExp;
        private IExpression rightExp;

        public Multiply(IExpression leftExp, IExpression rightExp)
        {
            this.leftExp=leftExp;
            this.rightExp=rightExp;
        }

        public double eval()
        {
            return leftExp.eval() * rightExp.eval();
        }
    }


    class Divide: IOperator
    {
        private IExpression leftExp;
        private IExpression rightExp;

        public Divide(IExpression leftExp, IExpression rightExp)
        {
            this.leftExp=leftExp;
            this.rightExp=rightExp;
        }

        public double eval()
        {
            try
            {
                return leftExp.eval()/rightExp.eval();
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Invalid Operation : Division by Zero" + e);
            }
            
            return 0;
        }
    }

}