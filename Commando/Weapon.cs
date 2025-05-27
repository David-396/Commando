using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commando
{
    internal class Weapon
    {
        private string Name;
        private string Producer;
        private int Ammo;

        public Weapon(string name, string producer, int ammo)
        {
            this.Name = name;
            this.Producer = producer;
            this.Ammo = ammo;
        }

        public void Shoot()
        {
            if(this.Ammo > 0)
            {
                this.Ammo -= 1;
                Console.WriteLine($"{this.Name} shooting");
            }
            else
            {
                Console.WriteLine("not enough ammo");
            }
        }


    }
}
