using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commando
{
    internal class SeaCommando : Commando
    {
        public SeaCommando(string Name, string CodeName, string[] Tools, StatusType Status)
            : base(Name, CodeName, Tools, Status) { }

        public void Swim()
        {
            this.Status = StatusType.swim;
            Console.WriteLine($"{this.Name} is swimming");
        }

        public override void Attack()
        {
            Console.WriteLine($"{this.Name} attacking from the sea");
        }
    }
}
