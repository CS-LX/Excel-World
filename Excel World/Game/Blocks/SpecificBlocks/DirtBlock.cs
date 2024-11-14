using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excel_World.Game.Blocks
{
    public class DirtBlock : Block
    {
        public new const int Index = 1;

        public override string GetChar()
        {
            return "🟫";
        }
    }
}
