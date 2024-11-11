using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excel_World.Game
{
    public interface IUpdateable
    {
        void Update(float dt);

        void FixedUpdate(float dt);
    }
}
