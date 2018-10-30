using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraSOLID.Interfaces
{
    interface IConverter
    {
        int ConvertStringToInt(string value);
        float ConvertStringToFloat(string value);

    }
}
