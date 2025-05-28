using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commando
{
    internal class Commando
    {
        protected string Name {  get; set; }
        protected string CodeName { get; set; }
        protected string[] Tools = new string[5] { "gun", "knife", "bag", "hammer", "grenade" };
        protected StatusType Status {  get; set; }


        public Commando(string Name, string CodeName, StatusType Status)
        {
            this.Name = Name;
            this.CodeName = CodeName;
            this.Status = Status;
        }

        public string GetName()
        {
            return this.Name;
        }
        public string GetCodeName()
        {
            return this.CodeName;
        }
        public string[] GetTools()
        {
            return this.Tools;
        }
        public StatusType GetStatus()
        {
            return this.Status;
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
        public virtual void Attack()
        {
            Console.WriteLine($"commando with codeName {this.CodeName} is attacking");
        }



        public string CSayName(string commanderRank)
        {
            return SayName_c.SayName(commanderRank, this);
        }

    }

    enum StatusType
    {
        walking, 
        hiding,
        standing,
        parachuting,
        swim
    }
}
