using Expression;
using System;

namespace Operator
{

    class OperatorC : IExpression
    {
        private char action;
        private IExpression leftExp;
        private IExpression rightExp;

        public OperatorC(char op,IExpression left,IExpression right)
        {
            this.action=op;
            leftExp=left;
            rightExp=right;
        }

        public double eval()
        {
            switch(action)
            {
                case '+' : return leftExp.eval()+rightExp.eval();
                case '*' : return leftExp.eval()*rightExp.eval();
                case '-' : return leftExp.eval()-rightExp.eval();
                case '/' : 
                if(rightExp.eval()==0)
                {
                    throw new DivideByZeroException("Invalid Operation : Division by Zero");
                }

                return leftExp.eval()/rightExp.eval();

                default : throw new Exception("Invalid Operation : Operator nogt supported");
            }  

        }
}
}