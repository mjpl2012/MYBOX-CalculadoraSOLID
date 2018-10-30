using System;
using CalculadoraSOLID.Interfaces;

namespace CalculadoraSOLID.Logic
{
    public class CalcSOLID : ICalc
    {
        private readonly IOperation _summatory;
        private readonly IOperation _multiplication;
        private readonly IOperation _subtraction;
        private readonly IOperation _division;
        private readonly IOperation _exponential;

        public CalcSOLID()
        {
            _summatory = new OperationSum();
            _multiplication = new OperationMul();
            _subtraction = new OperationSub();
            _division = new OperationDiv();
            _exponential = new OperationNExpM();
        }

        public int DoOperation(OperationType operation, int operand1, int operand2)
        {
            switch (operation)
            {
                case OperationType.Div:
                    return Division(operand1, operand2);
                case OperationType.Mul:
                    return Multiplication(operand1, operand2);
                case OperationType.Sub:
                    return Subtraction(operand1, operand2);
                case OperationType.Sum:
                    return Summatory(operand1, operand2);
                case OperationType.NExpM:
                    return Exponential(operand1, operand2);
                default:
                    return 0;
            }
        }

        private int Exponential(int operand1, int operand2)
        {
            return _exponential.Execute(operand1, operand2);
        }

        private int Summatory(int operand1, int operand2)
        {
            return _summatory.Execute(operand1, operand2);
        }

        private int Subtraction(int operand1, int operand2)
        {
            return _subtraction.Execute(operand1, operand2); 
        }

        private int Multiplication(int operand1, int operand2)
        {
            return _multiplication.Execute(operand1, operand2);
        }

        private int Division(int operand1, int operand2)
        {
            return _division.Execute(operand1, operand2);
        }
    }
}
