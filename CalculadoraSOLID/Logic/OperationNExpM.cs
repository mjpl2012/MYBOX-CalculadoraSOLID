﻿using System;
using CalculadoraSOLID.Interfaces;

namespace CalculadoraSOLID.Logic
{
    public class OperationNExpM : IOperation
    {
        private static readonly IOperation _mul = new OperationMul(); //Liskov

        public int Execute(int operand1, int operand2)
        {
            int result = operand1;

            for (int i = 1; i < operand2; i++)
            {
                result = _mul.Execute(result, operand1);
            }

            return result;
        }
    }
}
