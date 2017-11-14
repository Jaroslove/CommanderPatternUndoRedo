using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    abstract class Commande
    {
        protected ArithmeticUnit unit;
        protected int operand;

        public abstract void Execute();
        public abstract void UnExecute();
    }
}
