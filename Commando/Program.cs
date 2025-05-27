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
            Commando cmndo1 = new Commando("david", "123", new string[5] {"gun","knife","bag","hammer","grenade"}, StatusType.standing);
            Commando cmndo2 = new AirCommando("da", "123", new string[5] {"gun","knife","bag","hammer","grenade"}, StatusType.standing);
            Commando cmndo3 = new SeaCommando("vid", "123", new string[5] {"gun","knife","bag","hammer","grenade"}, StatusType.standing);
            Commando[] cmndoARR = {cmndo1, cmndo2, cmndo3};

            foreach(Commando cmndo in cmndoARR)
            {
                cmndo.Attack();
            }

            //cmndo.Attack();
            //cmndo.Walk();
            //Weapon wpn = new Weapon("s100", "elvit", 5);
            //wpn.Shoot();
            //cmndo.CodeName = "456";
        }
    }
}
