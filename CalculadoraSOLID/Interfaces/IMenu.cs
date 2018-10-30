using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraSOLID.Interfaces
{
    interface IMenu
    {
        string PrintMenuOperand1();
        string PrintMenuOperand2();
        OperationType PrintMenuOperation();
    }
}
