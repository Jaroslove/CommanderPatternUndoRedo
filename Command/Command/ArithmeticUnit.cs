using System;

namespace Command
{
    class ArithmeticUnit
    {
        public int Registr { get; private set; }

        public void Run(string operation, int operand)
        {
            switch (operation)
            {
                case "+":
                    Registr += operand;
                    break;
                case "-":
                    Registr -= operand;
                    break;
                default:
                    break;
            }
        }
    }
}