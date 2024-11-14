using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excel_World.Game.Blocks
{
    public abstract class Block
    {
        public const int Index = 0;
        public virtual string GetChar() => "◻️";
    }
}
