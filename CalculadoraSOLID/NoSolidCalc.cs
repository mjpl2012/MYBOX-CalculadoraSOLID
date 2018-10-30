using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraSOLID
{
    class NoSolidCalc
    {
        public int Operation(OperationType operationType, string operand1, string operand2)
        {

            var parsed1 = int.TryParse(operand1, out int operandOneParsed);
            var parsed2 = int.TryParse(operand2, out int operandTwoParsed);

            if (parsed1 && parsed2)
            {
                if (operationType.Equals(OperationType.Div))
                {
                    return operandOneParsed / operandTwoParsed;
                }

                if (operationType.Equals(OperationType.Mul))
                {
                    return operandOneParsed * operandTwoParsed;
                }
                if (operationType.Equals(OperationType.Sub))
                {
                    return operandOneParsed - operandTwoParsed;
                }

                return operandOneParsed + operandTwoParsed;
            }
            return 0;
        }

    }

    public enum OperationType
    {
        Sum, // = 0,
        Sub, // = 1,
        Div, // = 2,
        Mul, // =3
        NExpM
    }
}
