using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excel_World.Game.Subsystems
{
    public class SubsystemEatables : Subsystem, IDrawable
    {
        public List<Point2> m_eatables = new();

        public int DrawOrder => 1;

        public override void Load()
        {
            for (int i = 0; i < 5; i++)
            {
                int x, y;
                while (true)
                {
                    Random random = new Random((int)(i * DateTime.Now.Ticks % 1000));
                    x = random.Next(0, GameManager.WorldWidth);
                    random.NextDouble();
                    y = random.Next(0, GameManager.WorldHeight);

                    if (!m_eatables.Any(a => a == new Point2(x, y)))
                    {
                        break;
                    }
                }
                m_eatables.Add(new Point2(x, y));
            }
        }

        public override void Save()
        {
            m_eatables.Clear();
        }

        public void BeAte(Point2 eatPoint)
        {
            m_eatables.Remove(eatPoint);
            int x, y;
            while (true)
            {
                Random random = new Random((int)(DateTime.Now.Ticks % 1000));
                x = random.Next(0, GameManager.WorldWidth);
                random.NextDouble();
                y = random.Next(0, GameManager.WorldHeight);

                if (!m_eatables.Any(a => a == new Point2(x, y)))
                {
                    break;
                }
            }
            m_eatables.Add(new Point2(x, y));
        }

        public void Draw(Dictionary<Point2, string> requires)
        {
            foreach (var item in m_eatables)
            {
                requires[item] = "🍎";
            }
        }
    }
}
