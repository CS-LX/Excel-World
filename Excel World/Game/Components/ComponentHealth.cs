using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excel_World.Game
{
    public class ComponentHealth : Component, IUpdateable
    {
        public ComponentBody m_componentBody;

        public int UpdateOrder => 2;

        public void FixedUpdate(float dt)
        {
            if (m_componentBody.m_headPosition.X < 0 || m_componentBody.m_headPosition.X >= GameManager.WorldWidth || m_componentBody.m_headPosition.Y < 0 || m_componentBody.m_headPosition.Y >= GameManager.WorldHeight)
            {
                FinishGame();
            }
            
            if (m_componentBody.m_bodyParts.Contains(m_componentBody.m_headPosition))
            {
                FinishGame();
            }
        }

        public override void Load()
        {
            m_componentBody = Entity.GetComponent<ComponentBody>();
        }

        public void FinishGame()
        {
            MessageBox.Show($"游戏结束，分数: {m_componentBody.m_bodyParts.Count + 1}");
            GameManager.Finish();
        }

        public void Update(float dt)
        {
        }
    }
}
