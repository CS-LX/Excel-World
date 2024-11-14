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
            this.group2 = this.Factory.CreateRibbonGroup();
            this.box1 = this.Factory.CreateRibbonBox();
            this.box2 = this.Factory.CreateRibbonBox();
            this.box3 = this.Factory.CreateRibbonBox();
            this.box4 = this.Factory.CreateRibbonBox();
            this.startGameButton = this.Factory.CreateRibbonButton();
            this.finishGameButton = this.Factory.CreateRibbonButton();
            this.button1 = this.Factory.CreateRibbonButton();
            this.wButton = this.Factory.CreateRibbonButton();
            this.button3 = this.Factory.CreateRibbonButton();
            this.aButton = this.Factory.CreateRibbonButton();
            this.button5 = this.Factory.CreateRibbonButton();
            this.dButton = this.Factory.CreateRibbonButton();
            this.button7 = this.Factory.CreateRibbonButton();
            this.sButton = this.Factory.CreateRibbonButton();
            this.button9 = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.group2.SuspendLayout();
            this.box1.SuspendLayout();
            this.box2.SuspendLayout();
            this.box3.SuspendLayout();
            this.box4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Groups.Add(this.group2);
            this.tab1.Label = "我的Excel";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.startGameButton);
            this.group1.Items.Add(this.finishGameButton);
            this.group1.Name = "group1";
            // 
            // group2
            // 
            this.group2.Items.Add(this.box1);
            this.group2.Name = "group2";
            // 
            // box1
            // 
            this.box1.BoxStyle = Microsoft.Office.Tools.Ribbon.RibbonBoxStyle.Vertical;
            this.box1.Items.Add(this.box2);
            this.box1.Items.Add(this.box3);
            this.box1.Items.Add(this.box4);
            this.box1.Name = "box1";
            // 
            // box2
            // 
            this.box2.Items.Add(this.button1);
            this.box2.Items.Add(this.wButton);
            this.box2.Items.Add(this.button3);
            this.box2.Name = "box2";
            // 
            // box3
            // 
            this.box3.Items.Add(this.aButton);
            this.box3.Items.Add(this.button5);
            this.box3.Items.Add(this.dButton);
            this.box3.Name = "box3";
            // 
            // box4
            // 
            this.box4.Items.Add(this.button7);
            this.box4.Items.Add(this.sButton);
            this.box4.Items.Add(this.button9);
            this.box4.Name = "box4";
            // 
            // startGameButton
            // 
            this.startGameButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.startGameButton.Label = "开始游戏";
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.OfficeImageId = "MoviePlay";
            this.startGameButton.ShowImage = true;
            this.startGameButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.startGameButton_Click);
            // 
            // finishGameButton
            // 
            this.finishGameButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.finishGameButton.Label = "结束游戏";
            this.finishGameButton.Name = "finishGameButton";
            this.finishGameButton.OfficeImageId = "WindowClose";
            this.finishGameButton.ShowImage = true;
            this.finishGameButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.finishGameButton_Click);
            // 
            // button1
            // 
            this.button1.Label = " ";
            this.button1.Name = "button1";
            this.button1.OfficeImageId = "BorderNone";
            this.button1.ShowImage = true;
            // 
            // wButton
            // 
            this.wButton.Label = " ";
            this.wButton.Name = "wButton";
            this.wButton.OfficeImageId = "ShapeUpArrow";
            this.wButton.ShowImage = true;
            this.wButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.wButton_Click);
            // 
            // button3
            // 
            this.button3.Label = " ";
            this.button3.Name = "button3";
            this.button3.OfficeImageId = "BorderNone";
            this.button3.ShowImage = true;
            // 
            // aButton
            // 
            this.aButton.Label = " ";
            this.aButton.Name = "aButton";
            this.aButton.OfficeImageId = "ShapeLeftArrow";
            this.aButton.ShowImage = true;
            this.aButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.aButton_Click);
            // 
            // button5
            // 
            this.button5.Label = " ";
            this.button5.Name = "button5";
            this.button5.OfficeImageId = "BorderNone";
            this.button5.ShowImage = true;
            // 
            // dButton
            // 
            this.dButton.Label = " ";
            this.dButton.Name = "dButton";
            this.dButton.OfficeImageId = "ShapeRightArrow";
            this.dButton.ShowImage = true;
            this.dButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.dButton_Click);
            // 
            // button7
            // 
            this.button7.Label = " ";
            this.button7.Name = "button7";
            this.button7.OfficeImageId = "BorderNone";
            this.button7.ShowImage = true;
            // 
            // sButton
            // 
            this.sButton.Label = " ";
            this.sButton.Name = "sButton";
            this.sButton.OfficeImageId = "ShapeDownArrow";
            this.sButton.ShowImage = true;
            this.sButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.sButton_Click);
            // 
            // button9
            // 
            this.button9.Label = " ";
            this.button9.Name = "button9";
            this.button9.OfficeImageId = "BorderNone";
            this.button9.ShowImage = true;
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
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.box1.ResumeLayout(false);
            this.box1.PerformLayout();
            this.box2.ResumeLayout(false);
            this.box2.PerformLayout();
            this.box3.ResumeLayout(false);
            this.box3.PerformLayout();
            this.box4.ResumeLayout(false);
            this.box4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton startGameButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton finishGameButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box1;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box2;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box3;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box4;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton wButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button3;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton aButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button5;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton dButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button7;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button9;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton sButton;
    }

    partial class ThisRibbonCollection
    {
        internal OperationsBar OperationsBar
        {
            get { return this.GetRibbon<OperationsBar>(); }
        }
    }
}
