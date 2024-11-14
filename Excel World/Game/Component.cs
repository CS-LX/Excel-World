using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excel_World.Game
{
    public abstract class Component
    {
        public Project Project { get; set; }
        public Entity Entity { get; set; }
    }
}
