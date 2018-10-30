using System;
using CalculadoraSOLID.Interfaces;

namespace CalculadoraSOLID.Logic
{
    public class Menu : IMenu
    {
        private readonly IConverter _converter = new Converter();
        public OperationType PrintMenuOperation()
        {
            Console.WriteLine("Intro Operation");
            Console.WriteLine("0: SUM");
            Console.WriteLine("1: SUB");
            Console.WriteLine("2: DIV");
            Console.WriteLine("3: MUL");
            Console.WriteLine("4: NExpM");
            var operation = Console.ReadLine();
            return (OperationType)_converter.ConvertStringToInt(operation);
        }

        public string PrintMenuOperand1()
        {
            Console.WriteLine("Intro First Operand");
            return Console.ReadLine();
        }

        public string PrintMenuOperand2()
        {
            Console.WriteLine("Intro Second Operand");
            return Console.ReadLine(); 
        }
    }
}
