using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commando
{
    internal class Commando
    {
        private string Name;
        private string CodeName;
        private string[] Tools;
        private StatusType Status;


        public Commando(string Name, string CodeName, string[] Tools, StatusType Status)
        {
            this.Name = Name;
            this.CodeName = CodeName;
            this.Tools = Tools;
            this.Status = Status;
        }

        public void Walk()
        {
            this.Status = StatusType.walking;
            Console.WriteLine($"{this.Name} is {this.Status}");
        }

        public void Hide()
        {
            this.Status = StatusType.hiding;
            Console.WriteLine($"{this.Name} is {this.Status}");
        }

        public void Attack()
        {
            Console.WriteLine($"commando with codeName {this.CodeName} is attacking");
        }

        public string SayName(string commanderRank)
        {
            if(commanderRank == "General")
            {
                return this.Name;
            }
            else if(commanderRank == "Colonel")
            {
                return this.CodeName;
            }
            return "classified data";
        }

    }

    enum StatusType
    {
        walking, 
        hiding,
        standing
    }
}
