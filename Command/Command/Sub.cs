﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Sub : Commande
    {
        public Sub(ArithmeticUnit unit, int operand)
        {
            this.unit = unit;
            this.operand = operand;
        }

        public override void Execute()
        {
            unit.Run("-", operand);
        }

        public override void UnExecute()
        {
            unit.Run("+", operand);
        }
    }
}
