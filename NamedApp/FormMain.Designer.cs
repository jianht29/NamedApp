namespace NamedApp
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.uiSymbolButtonNamed = new Sunny.UI.UISymbolButton();
            this.uiSymbolLabelName = new Sunny.UI.UISymbolLabel();
            this.TimerNamed = new System.Windows.Forms.Timer(this.components);
            this.uiStyleManager = new Sunny.UI.UIStyleManager(this.components);
            this.uiContextMenuStrip = new Sunny.UI.UIContextMenuStrip();
            this.ToolStripMenuItemReSet = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItemColorDefault = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemColorFul = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItemVoiceBroadcast = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemVoiceControl = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemVoiceCommand = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItemNamedList = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.uiContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiSymbolButtonNamed
            // 
            this.uiSymbolButtonNamed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButtonNamed.Font = new System.Drawing.Font("微软雅黑", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButtonNamed.Location = new System.Drawing.Point(599, 333);
            this.uiSymbolButtonNamed.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButtonNamed.Name = "uiSymbolButtonNamed";
            this.uiSymbolButtonNamed.Size = new System.Drawing.Size(244, 70);
            this.uiSymbolButtonNamed.Symbol = 61515;
            this.uiSymbolButtonNamed.SymbolOffset = new System.Drawing.Point(0, 3);
            this.uiSymbolButtonNamed.SymbolSize = 39;
            this.uiSymbolButtonNamed.TabIndex = 1;
            this.uiSymbolButtonNamed.Text = "开始抽签";
            this.uiSymbolButtonNamed.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButtonNamed.Click += new System.EventHandler(this.uiSymbolButtonNamed_Click);
            // 
            // uiSymbolLabelName
            // 
            this.uiSymbolLabelName.Font = new System.Drawing.Font("微软雅黑", 120F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolLabelName.Location = new System.Drawing.Point(26, 54);
            this.uiSymbolLabelName.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabelName.Name = "uiSymbolLabelName";
            this.uiSymbolLabelName.Size = new System.Drawing.Size(817, 251);
            this.uiSymbolLabelName.Symbol = 61484;
            this.uiSymbolLabelName.SymbolOffset = new System.Drawing.Point(0, 10);
            this.uiSymbolLabelName.SymbolSize = 128;
            this.uiSymbolLabelName.TabIndex = 2;
            this.uiSymbolLabelName.Text = "准备抽签";
            this.uiSymbolLabelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TimerNamed
            // 
            this.TimerNamed.Interval = 10;
            this.TimerNamed.Tick += new System.EventHandler(this.TimerNamed_Tick);
            // 
            // uiContextMenuStrip
            // 
            this.uiContextMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiContextMenuStrip.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemReSet,
            this.toolStripSeparator1,
            this.ToolStripMenuItemColorDefault,
            this.ToolStripMenuItemColorFul,
            this.toolStripSeparator2,
            this.ToolStripMenuItemVoiceBroadcast,
            this.ToolStripMenuItemVoiceControl,
            this.ToolStripMenuItemVoiceCommand,
            this.toolStripSeparator3,
            this.ToolStripMenuItemNamedList,
            this.toolStripSeparator4,
            this.ToolStripMenuItemExit});
            this.uiContextMenuStrip.Name = "uiContextMenuStrip";
            this.uiContextMenuStrip.ShowCheckMargin = true;
            this.uiContextMenuStrip.ShowImageMargin = false;
            this.uiContextMenuStrip.Size = new System.Drawing.Size(161, 268);
            // 
            // ToolStripMenuItemReSet
            // 
            this.ToolStripMenuItemReSet.Name = "ToolStripMenuItemReSet";
            this.ToolStripMenuItemReSet.Size = new System.Drawing.Size(160, 30);
            this.ToolStripMenuItemReSet.Text = "准备抽签";
            this.ToolStripMenuItemReSet.Click += new System.EventHandler(this.ToolStripMenuItemReSet_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // ToolStripMenuItemColorDefault
            // 
            this.ToolStripMenuItemColorDefault.CheckOnClick = true;
            this.ToolStripMenuItemColorDefault.Name = "ToolStripMenuItemColorDefault";
            this.ToolStripMenuItemColorDefault.Size = new System.Drawing.Size(160, 30);
            this.ToolStripMenuItemColorDefault.Text = "默认主题";
            this.ToolStripMenuItemColorDefault.Click += new System.EventHandler(this.ToolStripMenuItemColorDefault_Click);
            // 
            // ToolStripMenuItemColorFul
            // 
            this.ToolStripMenuItemColorFul.CheckOnClick = true;
            this.ToolStripMenuItemColorFul.Name = "ToolStripMenuItemColorFul";
            this.ToolStripMenuItemColorFul.Size = new System.Drawing.Size(160, 30);
            this.ToolStripMenuItemColorFul.Text = "多彩主题";
            this.ToolStripMenuItemColorFul.Click += new System.EventHandler(this.ToolStripMenuItemColorFul_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(157, 6);
            // 
            // ToolStripMenuItemVoiceBroadcast
            // 
            this.ToolStripMenuItemVoiceBroadcast.CheckOnClick = true;
            this.ToolStripMenuItemVoiceBroadcast.Name = "ToolStripMenuItemVoiceBroadcast";
            this.ToolStripMenuItemVoiceBroadcast.Size = new System.Drawing.Size(160, 30);
            this.ToolStripMenuItemVoiceBroadcast.Text = "语音播报";
            this.ToolStripMenuItemVoiceBroadcast.Click += new System.EventHandler(this.ToolStripMenuItemVoiceBroadcast_Click);
            // 
            // ToolStripMenuItemVoiceControl
            // 
            this.ToolStripMenuItemVoiceControl.CheckOnClick = true;
            this.ToolStripMenuItemVoiceControl.Name = "ToolStripMenuItemVoiceControl";
            this.ToolStripMenuItemVoiceControl.Size = new System.Drawing.Size(160, 30);
            this.ToolStripMenuItemVoiceControl.Text = "语音控制";
            this.ToolStripMenuItemVoiceControl.Click += new System.EventHandler(this.ToolStripMenuItemVoiceControl_Click);
            // 
            // ToolStripMenuItemVoiceCommand
            // 
            this.ToolStripMenuItemVoiceCommand.Name = "ToolStripMenuItemVoiceCommand";
            this.ToolStripMenuItemVoiceCommand.Size = new System.Drawing.Size(160, 30);
            this.ToolStripMenuItemVoiceCommand.Text = "语音指令";
            this.ToolStripMenuItemVoiceCommand.Click += new System.EventHandler(this.ToolStripMenuItemVoiceCommand_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(157, 6);
            // 
            // ToolStripMenuItemNamedList
            // 
            this.ToolStripMenuItemNamedList.Name = "ToolStripMenuItemNamedList";
            this.ToolStripMenuItemNamedList.Size = new System.Drawing.Size(160, 30);
            this.ToolStripMenuItemNamedList.Text = "编辑名单";
            this.ToolStripMenuItemNamedList.Click += new System.EventHandler(this.ToolStripMenuItemNamedList_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(157, 6);
            // 
            // ToolStripMenuItemExit
            // 
            this.ToolStripMenuItemExit.Name = "ToolStripMenuItemExit";
            this.ToolStripMenuItemExit.Size = new System.Drawing.Size(160, 30);
            this.ToolStripMenuItemExit.Text = "退出程序";
            this.ToolStripMenuItemExit.Click += new System.EventHandler(this.ToolStripMenuItemExit_Click);
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(876, 438);
            this.ContextMenuStrip = this.uiContextMenuStrip;
            this.Controls.Add(this.uiSymbolLabelName);
            this.Controls.Add(this.uiSymbolButtonNamed);
            this.ExtendBox = true;
            this.ExtendMenu = this.uiContextMenuStrip;
            this.ExtendSymbol = 61573;
            this.ExtendSymbolOffset = new System.Drawing.Point(0, 2);
            this.ExtendSymbolSize = 32;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(0, 49, 0, 0);
            this.Text = "抽签点名程序";
            this.TitleFont = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TitleHeight = 49;
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.uiContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolButton uiSymbolButtonNamed;
        private Sunny.UI.UISymbolLabel uiSymbolLabelName;
        private System.Windows.Forms.Timer TimerNamed;
        private Sunny.UI.UIStyleManager uiStyleManager;
        private Sunny.UI.UIContextMenuStrip uiContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemReSet;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemColorDefault;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemColorFul;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemVoiceBroadcast;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemVoiceControl;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemVoiceCommand;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemNamedList;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemExit;
    }
}

