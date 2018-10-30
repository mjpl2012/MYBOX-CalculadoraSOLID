using CalculadoraSOLID.Interfaces;


namespace CalculadoraSOLID.Logic
{
    public class OperationMul: IOperation
    {
        public int Execute(int operand1, int operand2)
        {
            return operand1 * operand2;

        }
    }
}
