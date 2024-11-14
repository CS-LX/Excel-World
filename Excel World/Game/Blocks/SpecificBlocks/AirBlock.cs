using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excel_World.Game.Blocks
{
    public class AirBlock : Block
    {
        public new const int Index = 0;
        public override string GetChar()
        {
            return "🟦";
        }
    }
}
