using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commando
{
    internal class AirCommando : Commando
    {
        public AirCommando(string Name, string CodeName, string[] Tools, StatusType Status)
            : base(Name, CodeName, Tools, Status) { }
        
        public Parachute()
        {
            this.Status = StatusType.parachuting;
            Console.WriteLine($"{this.Name} is parachuting");
        }

    }
}
