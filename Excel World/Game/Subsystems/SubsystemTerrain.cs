using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel_World.Game.Blocks;

namespace Excel_World.Game.Subsystems
{
    public class SubsystemTerrain : Subsystem, IDrawable
    {
        public int[,] m_blocks;

        public int DrawOrder => 0;

        public override void Load()
        {
            base.Load();
            m_blocks = new int[GameManager.WorldWidth, GameManager.WorldHeight];
            GenerateTerrain();
        }

        public void GenerateTerrain()
        {
            for (int i = 0; i < m_blocks.GetLength(0); i++) 
            {
                for (int j = 0; j < m_blocks.GetLength(1); j++)
                {
                    m_blocks[i, j] = DirtBlock.Index;
                }
            }
        }

        public void Draw(Dictionary<Point2, string> requires)
        {
            for (int i = 0; i < m_blocks.GetLength(0); i++)
            {
                for (int j = 0; j < m_blocks.GetLength(1); j++)
                {
                    requires[new Point2(i, j)] = BlocksManager.Blocks[m_blocks[i, j]].GetChar();
                }
            }
        }
    }
}
