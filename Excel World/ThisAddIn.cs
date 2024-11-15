﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
using Excel_World.Game;
using Excel_World.Game.Subsystems;
using Excel_World.Game.Blocks;

namespace Excel_World
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            BlocksManager.Init();
            GameManager.Screen = Globals.ThisAddIn.Application.ActiveSheet as Excel.Worksheet;
            GameManager.Project.AddSubsystem(new SubsystemDrawing());
            GameManager.Project.AddSubsystem(new SubsystemTerrain());

            Entity playerEntity = new Entity() { Name = "Player" };
            playerEntity.AddComponent(new ComponentBody());
            playerEntity.AddComponent(new ComponentLocomotion());

            GameManager.Project.AddEntity(playerEntity);
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO 生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
