using System;
using CalculadoraSOLID.Interfaces;

namespace CalculadoraSOLID.Logic
{
    public class Converter : IConverter
    {
        public float ConvertStringToFloat(string value)
        {
            var isConverted = float.TryParse(value, out float floatValue);
            return isConverted ? floatValue : 0.0f;
        }

        public int ConvertStringToInt(string value)
        {
            var isConverted = int.TryParse(value, out int intValue);
            return isConverted ? intValue : 0;
        }
    }
}
