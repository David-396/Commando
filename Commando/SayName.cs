using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commando
{
    internal class SayName_c
    {
        public static string SayName(string commanderRank, Commando cmndo)
        {
            if (commanderRank == "General")
            {
                return cmndo.GetName();
            }
            else if (commanderRank == "Colonel")
            {
                return cmndo.GetCodeName();
            }
            return "classified data";
        }

    }
}
