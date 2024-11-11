namespace Excel_World
{
    partial class OperationsBar : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public OperationsBar()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.startGameButton = this.Factory.CreateRibbonButton();
            this.finishGameButton = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Label = "我的Excel";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.startGameButton);
            this.group1.Items.Add(this.finishGameButton);
            this.group1.Name = "group1";
            // 
            // startGameButton
            // 
            this.startGameButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.startGameButton.Label = "开始游戏";
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.ShowImage = true;
            this.startGameButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.startGameButton_Click);
            // 
            // finishGameButton
            // 
            this.finishGameButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.finishGameButton.Label = "结束游戏";
            this.finishGameButton.Name = "finishGameButton";
            this.finishGameButton.ShowImage = true;
            this.finishGameButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.finishGameButton_Click);
            // 
            // OperationsBar
            // 
            this.Name = "OperationsBar";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.OperationsBar_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton startGameButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton finishGameButton;
    }

    partial class ThisRibbonCollection
    {
        internal OperationsBar OperationsBar
        {
            get { return this.GetRibbon<OperationsBar>(); }
        }
    }
}
