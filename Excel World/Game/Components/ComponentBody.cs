using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excel_World.Game
{
    public class ComponentBody : Component, IDrawable
    {
        public List<Point2> m_bodyParts = new();
        public Point2 m_headPosition;

        public int DrawOrder => 1;

        public override void Load()
        {
            m_headPosition = new Point2(10, 10);
        }

        public override void Save()
        {
            m_headPosition = new Point2();
            m_bodyParts.Clear();
        }

        public void Move(Point2 direciton, bool addLength = false)
        {
            m_bodyParts.Add(m_headPosition);
            m_headPosition += direciton;
            if (!addLength) m_bodyParts.RemoveAt(0);
        }

        public void Draw(Dictionary<Point2, string> requires)
        {
            foreach (var part in m_bodyParts)
            {
                requires[part] = "\U0001f7e9";
            }
            requires[m_headPosition] = "\U0001f7e9";
        }
    }
}
