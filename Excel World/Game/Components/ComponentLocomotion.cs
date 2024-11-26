using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel_World.Game.Subsystems;

namespace Excel_World.Game
{
    internal class ComponentLocomotion : Component, IUpdateable
    {
        public Point2 m_direction;
        private float m_cacheSeconds = 0;
        public float m_speed = 2;
        public int UpdateOrder => 0;

        public ComponentBody m_componentBody;
        public SubsystemEatables m_subsystemEatables;

        public override void Load()
        {
            m_componentBody = Entity.GetComponent<ComponentBody>();
            m_subsystemEatables = Project.FindSubsystem<SubsystemEatables>();

            Input.OnWKeyDown(() => m_direction = new Point2(-1, 0));
            Input.OnAKeyDown(() => m_direction = new Point2(0, -1));
            Input.OnSKeyDown(() => m_direction = new Point2(0, 1));
            Input.OnDKeyDown(() => m_direction = new Point2(1, 0));
        }

        public void FixedUpdate(float dt)
        {
            if (m_cacheSeconds > 1 / m_speed)
            {
                m_cacheSeconds = 0;
                bool isAte = m_subsystemEatables.m_eatables.Contains(m_componentBody.m_headPosition);
                if (isAte) m_subsystemEatables.BeAte(m_componentBody.m_headPosition);
                m_componentBody.Move(m_direction, isAte);
            }
            else
            {
                m_cacheSeconds += dt;
            }
        }

        public void Update(float dt)
        {
        }
    }
}
