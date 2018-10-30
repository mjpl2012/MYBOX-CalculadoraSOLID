using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraSOLID.Interfaces
{
    interface ICalc
    {
        int DoOperation(OperationType operation, int operand1, int operand2);
    }
}
