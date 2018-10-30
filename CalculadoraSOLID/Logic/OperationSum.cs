using CalculadoraSOLID.Interfaces;


namespace CalculadoraSOLID.Logic
{
    public class OperationSum:IOperation
    {
        public int Execute(int operand1, int operand2)
        {
            return operand1 + operand2;

        }
    }
}
