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
        private string Status;


        public Commando(string Name, string CodeName, string[] Tools, string Status)
        {
            this.Name = Name;
            this.CodeName = CodeName;
            this.Tools = Tools;
            this.Status = Status;
        }

        public void Walk()
        {
            this.Status = "walking";
            Console.WriteLine($"{this.Name} is {this.Status}");
        }

        public void Hide()
        {
            this.Status = "hiding";
            Console.WriteLine($"{this.Name} is {this.Status}");
        }

        public void Attack()
        {
            Console.WriteLine($"commando with codeName {this.CodeName} is attacking");
        }

    }
}
