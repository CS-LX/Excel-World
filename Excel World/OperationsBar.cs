using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Excel_World.Game;
using Microsoft.Office.Tools.Ribbon;

namespace Excel_World
{
    public partial class OperationsBar
    {
        private void OperationsBar_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void startGameButton_Click(object sender, RibbonControlEventArgs e)
        {
            GameManager.Start();
        }

        private void finishGameButton_Click(object sender, RibbonControlEventArgs e)
        {
            GameManager.Finish();
        }

        private void wButton_Click(object sender, RibbonControlEventArgs e)
        {
            GameManager.Project.FindEntity("Player").GetComponent<ComponentLocomotion>().Move(new Point2(-1, 0));
        }

        private void aButton_Click(object sender, RibbonControlEventArgs e)
        {
            GameManager.Project.FindEntity("Player").GetComponent<ComponentLocomotion>().Move(new Point2(0, -1));
        }

        private void dButton_Click(object sender, RibbonControlEventArgs e)
        {
            GameManager.Project.FindEntity("Player").GetComponent<ComponentLocomotion>().Move(new Point2(0, 1));
        }

        private void sButton_Click(object sender, RibbonControlEventArgs e)
        {
            GameManager.Project.FindEntity("Player").GetComponent<ComponentLocomotion>().Move(new Point2(1, 0));
        }
    }
}
