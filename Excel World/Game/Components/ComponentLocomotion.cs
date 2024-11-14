using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excel_World.Game
{
    internal class ComponentLocomotion : Component
    {
        public void Move(Point2 deltaPosition)
        {
            Entity.GetComponent<ComponentBody>().Position += deltaPosition;
        }
    }
}
