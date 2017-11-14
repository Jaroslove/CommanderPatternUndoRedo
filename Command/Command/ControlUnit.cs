using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class ControlUnit
    {
        IList<Commande> commands = new List<Commande>();
        private int current = 0;

        public void StoreCommand(Commande commande)
        {
            commands.Add(commande);
        }

        public void ExecuteCommand()
        {
            commands[current].Execute();
            current++;
        }

        public void Undo(int levels)
        {
            for (int i = 0; i < levels; i++)
            {
                if(current > 0)
                {
                    commands[--current].UnExecute();
                }
            }
        }

        public void Redo(int levels)
        {
            for (int i = 0; i < levels; i++)
            {
                if(current < commands.Count - 1)
                {
                    commands[current++].Execute();
                }
            }
        }
    }
}
