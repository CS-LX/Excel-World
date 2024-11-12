using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excel_World.Game
{
    public interface IDrawable
    {
        void Draw(Dictionary<Point2, string> requires);

        int DrawOrder { get; }
    }
}
