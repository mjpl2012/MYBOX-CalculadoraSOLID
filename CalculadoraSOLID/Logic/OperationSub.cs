using CalculadoraSOLID.Interfaces;


namespace CalculadoraSOLID.Logic
{
    public class OperationSub:IOperation
    {
        public int Execute(int operand1, int operand2)
        {
            return operand1 - operand2;

        }
    }
}
