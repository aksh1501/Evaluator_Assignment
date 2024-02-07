using Expression;

namespace Operand
{    
    class OperandC : IExpression
    {
        private double value;

        public OperandC(double Value)
        {
            value = Value;
        }
        public double eval()
        {
            return value;
        }
    }
}