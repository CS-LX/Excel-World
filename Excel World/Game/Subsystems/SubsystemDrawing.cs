using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace Excel_World.Game.Subsystems
{
    public class SubsystemDrawing : Subsystem
    {
        public Dictionary<Point2, string> m_requires = new();
        private Dictionary<Point2, string> m_previousRequires = new();

        public bool m_isRunning = false;

        public override void Load()
        {
            var worksheet = GameManager.Screen;

            // 设置 1~20 行的行高为 36
            for (int row = 1; row <= GameManager.WorldHeight; row++)
            {
                worksheet.Rows[row].RowHeight = 16;
                worksheet.Cells[row, GameManager.WorldHeight].Borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
                worksheet.Cells[row, GameManager.WorldHeight].Borders[XlBordersIndex.xlEdgeRight].Weight = XlBorderWeight.xlMedium;
            }

            // 设置 1~20 列的列宽为 36
            for (int col = 1; col <= GameManager.WorldWidth; col++)
            {
                worksheet.Columns[col].ColumnWidth = 16 / 7.5;  // 列宽单位和行高不同，约为 1字符 = 7.5 点
                worksheet.Cells[GameManager.WorldHeight, col].Borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
                worksheet.Cells[GameManager.WorldHeight, col].Borders[XlBordersIndex.xlEdgeBottom].Weight = XlBorderWeight.xlMedium;
            }

            m_isRunning = true;

            Task.Run(DrawLoop);
        }

        public override void Save()
        {
            m_requires.Clear();
            m_isRunning = false;
        }

        private void DrawLoop()
        {
            while (m_isRunning)
            {
                Project.DrawSubsystems(m_requires);
                Project.DrawEntities(m_requires);

                Draw(m_requires);
                // 控制帧率（例如60帧/秒）
                Thread.Sleep(16);
            }
        }

        public void Draw(Dictionary<Point2, string> requires)
        {
            for (int x = 0; x < GameManager.WorldWidth; x++)
            {
                for (int y = 0; y < GameManager.WorldHeight; y++)
                {
                    Point2 point = new Point2(x, y);
                    if (requires.ContainsKey(point))
                    {
                        if (m_previousRequires.ContainsKey(point) && m_previousRequires[point] != requires[point])
                        {
                            GameManager.Screen.Cells[x + 1, y + 1].Value2 = requires[point];
                        }
                        if (!m_previousRequires.ContainsKey(point))
                        {
                            GameManager.Screen.Cells[x + 1, y + 1].Value2 = requires[point];
                        }
                    }
                    else if (m_previousRequires.ContainsKey(point) && !requires.ContainsKey(point))
                    {
                        GameManager.Screen.Cells[x + 1, y + 1].Value2 = string.Empty;
                    }
                }
            }

            m_previousRequires = new Dictionary<Point2, string>(requires);
        }
    }
}
