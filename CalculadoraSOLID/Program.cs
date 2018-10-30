using System;
using CalculadoraSOLID.Interfaces;
using CalculadoraSOLID.Logic;

namespace CalculadoraSOLID
{
    class Program
    {

        private static readonly IConverter _converter = new Converter();
        private static readonly IMenu _menu = new Menu();
        private static readonly ICalc _calc = new CalculadoraSOLID.Logic.CalcSOLID();


        static void Main(string[] args)
        {
            //NoSolidOperation();
            CalcSolid();
        }

        private static void NoSolidOperation()
        {
            Console.WriteLine("Intro First Operand");
            var operand1 = Console.ReadLine();

            Console.WriteLine("Intro Second Operand");
            var operand2 = Console.ReadLine();

            Console.WriteLine("Intro Operation");
            Console.WriteLine("0: SUM");
            Console.WriteLine("1: SUB");
            Console.WriteLine("2: DIV");
            Console.WriteLine("3: MUL");
            int operationTeclado = Convert.ToInt32(Console.ReadLine());
            var operation = (OperationType)operationTeclado;

            var result = new NoSolidCalc().Operation(operation, operand1, operand2);
            Console.WriteLine(result);
            Console.Read();
        }

        private static void CalcSolid()
        {
            var operand1 = _converter.ConvertStringToInt(_menu.PrintMenuOperand1());
            var operand2 = _converter.ConvertStringToInt(_menu.PrintMenuOperand2());
            var operation = _menu.PrintMenuOperation();
            Console.WriteLine(_calc.DoOperation(operation, operand1, operand2));
            Console.ReadLine();
        }

    }
}