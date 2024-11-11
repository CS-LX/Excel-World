using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    }
}
