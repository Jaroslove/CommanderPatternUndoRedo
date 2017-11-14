using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Calculator
    {
        ArithmeticUnit arithmeticUnit;
        ControlUnit controlUnit;

        public Calculator()
        {
            arithmeticUnit = new ArithmeticUnit();
            controlUnit = new ControlUnit();
        }

        private int Run(Commande commande)
        {
            controlUnit.StoreCommand(commande);
            controlUnit.ExecuteCommand();
            return arithmeticUnit.Registr;
        }

        public int Add(int operand)
        {
            return Run(new Add(arithmeticUnit, operand));
        }

        public int Sub(int operand)
        {
            return Run(new Sub(arithmeticUnit, operand));
        }

        public int Undo(int levels)
        {
            controlUnit.Undo(levels);
            return arithmeticUnit.Registr;
        }

        public int Redo(int levels)
        {
            controlUnit.Redo(levels);
            return arithmeticUnit.Registr;
        }
    }
}
