using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excel_World.Game
{
    public class ComponentBody : Component, IDrawable
    {
        public Point2 Position = new Point2(10, 10);

        public int DrawOrder => 1;

        public void Draw(Dictionary<Point2, string> requires)
        {
            requires[Position] = "🧍‍♂️";
        }
    }
}
