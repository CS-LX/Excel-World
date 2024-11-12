using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excel_World.Game.Subsystems
{
    public class SubsystemDrawing : Subsystem, IUpdateable, IDrawable
    {
        public int UpdateOrder => int.MaxValue;

        public int DrawOrder => int.MaxValue;

        public Dictionary<Point2, string> m_requires = new();

        public override void Load()
        {
            var worksheet = GameManager.Screen;

            // 设置 1~20 行的行高为 36
            for (int row = 1; row <= GameManager.WorldHeight; row++)
            {
                worksheet.Rows[row].RowHeight = 16;
            }

            // 设置 1~20 列的列宽为 36
            for (int col = 1; col <= GameManager.WorldWidth; col++)
            {
                worksheet.Columns[col].ColumnWidth = 16 / 7.5;  // 列宽单位和行高不同，约为 1字符 = 7.5 点
            }
        }

        public void FixedUpdate(float dt)
        {
        }

        public void Update(float dt)
        {
            Project.DrawSubsystems(m_requires);
        }

        public void Draw(Dictionary<Point2, string> requires)
        {
            for (int x = 0; x < GameManager.WorldWidth; x++)
            {
                for (int y = 0; y < GameManager.WorldHeight; y++)
                {
                    if (requires.ContainsKey(new Point2(x, y))) GameManager.Screen.Cells[x + 1, y + 1].Value2 = requires[new Point2(x, y)];
                    else GameManager.Screen.Cells[x + 1, y + 1].Value2 = string.Empty;
                }
            }
        }
    }
}
