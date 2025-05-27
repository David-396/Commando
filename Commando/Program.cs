using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commando
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Commando cmndo = new Commando("david", "123", new string[5] {"gun","knife","bag","hammer","grenade"}, StatusType.standing);
            cmndo.Attack();
            cmndo.Walk();
            Weapon wpn = new Weapon("s100", "elvit", 5);
            wpn.Shoot();
            cmndo.CodeName = "456";
        }
    }
}
