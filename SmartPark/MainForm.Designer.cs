namespace SmartPark
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.系统管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_PlaceManage = new System.Windows.Forms.ToolStripMenuItem();
            this.类别设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.场地列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_SystemConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.服务器地址ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.会员管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.财务结算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.商品出售ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.会籍管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.折扣管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.等级管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.场地预定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统管理ToolStripMenuItem,
            this.会员管理ToolStripMenuItem,
            this.财务结算ToolStripMenuItem,
            this.商品出售ToolStripMenuItem,
            this.场地预定ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(884, 25);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // 系统管理ToolStripMenuItem
            // 
            this.系统管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_PlaceManage,
            this.MenuItem_SystemConfig,
            this.MenuItemQuit});
            this.系统管理ToolStripMenuItem.Name = "系统管理ToolStripMenuItem";
            this.系统管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.系统管理ToolStripMenuItem.Text = "系统管理";
            // 
            // MenuItem_PlaceManage
            // 
            this.MenuItem_PlaceManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.类别设置ToolStripMenuItem,
            this.场地列表ToolStripMenuItem});
            this.MenuItem_PlaceManage.Name = "MenuItem_PlaceManage";
            this.MenuItem_PlaceManage.Size = new System.Drawing.Size(152, 22);
            this.MenuItem_PlaceManage.Text = "场地管理";
            // 
            // 类别设置ToolStripMenuItem
            // 
            this.类别设置ToolStripMenuItem.Name = "类别设置ToolStripMenuItem";
            this.类别设置ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.类别设置ToolStripMenuItem.Text = "类别设置";
            // 
            // 场地列表ToolStripMenuItem
            // 
            this.场地列表ToolStripMenuItem.Name = "场地列表ToolStripMenuItem";
            this.场地列表ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.场地列表ToolStripMenuItem.Text = "场地列表";
            // 
            // MenuItem_SystemConfig
            // 
            this.MenuItem_SystemConfig.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户管理ToolStripMenuItem,
            this.服务器地址ToolStripMenuItem});
            this.MenuItem_SystemConfig.Name = "MenuItem_SystemConfig";
            this.MenuItem_SystemConfig.Size = new System.Drawing.Size(152, 22);
            this.MenuItem_SystemConfig.Text = "系统设置";
            // 
            // 用户管理ToolStripMenuItem
            // 
            this.用户管理ToolStripMenuItem.Name = "用户管理ToolStripMenuItem";
            this.用户管理ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.用户管理ToolStripMenuItem.Text = "用户管理";
            // 
            // 服务器地址ToolStripMenuItem
            // 
            this.服务器地址ToolStripMenuItem.Name = "服务器地址ToolStripMenuItem";
            this.服务器地址ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.服务器地址ToolStripMenuItem.Text = "服务器设置";
            // 
            // MenuItemQuit
            // 
            this.MenuItemQuit.Name = "MenuItemQuit";
            this.MenuItemQuit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.MenuItemQuit.Size = new System.Drawing.Size(152, 22);
            this.MenuItemQuit.Text = "退出";
            this.MenuItemQuit.Click += new System.EventHandler(this.MenuItemQuit_Click);
            // 
            // 会员管理ToolStripMenuItem
            // 
            this.会员管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.等级管理ToolStripMenuItem,
            this.会籍管理ToolStripMenuItem,
            this.折扣管理ToolStripMenuItem});
            this.会员管理ToolStripMenuItem.Name = "会员管理ToolStripMenuItem";
            this.会员管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.会员管理ToolStripMenuItem.Text = "会员管理";
            // 
            // 财务结算ToolStripMenuItem
            // 
            this.财务结算ToolStripMenuItem.Name = "财务结算ToolStripMenuItem";
            this.财务结算ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.财务结算ToolStripMenuItem.Text = "财务结算";
            // 
            // 商品出售ToolStripMenuItem
            // 
            this.商品出售ToolStripMenuItem.Name = "商品出售ToolStripMenuItem";
            this.商品出售ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.商品出售ToolStripMenuItem.Text = "商品管理";
            // 
            // 会籍管理ToolStripMenuItem
            // 
            this.会籍管理ToolStripMenuItem.Name = "会籍管理ToolStripMenuItem";
            this.会籍管理ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.会籍管理ToolStripMenuItem.Text = "会籍管理";
            // 
            // 折扣管理ToolStripMenuItem
            // 
            this.折扣管理ToolStripMenuItem.Name = "折扣管理ToolStripMenuItem";
            this.折扣管理ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.折扣管理ToolStripMenuItem.Text = "折扣管理";
            // 
            // 等级管理ToolStripMenuItem
            // 
            this.等级管理ToolStripMenuItem.Name = "等级管理ToolStripMenuItem";
            this.等级管理ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.等级管理ToolStripMenuItem.Text = "等级管理";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(884, 58);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(55, 55);
            this.toolStripButton1.Text = "结算";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.AutoSize = false;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(55, 55);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.AutoSize = false;
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(55, 55);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.AutoSize = false;
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(55, 55);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // 场地预定ToolStripMenuItem
            // 
            this.场地预定ToolStripMenuItem.Name = "场地预定ToolStripMenuItem";
            this.场地预定ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.场地预定ToolStripMenuItem.Text = "场地预定";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "管理系统";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem 系统管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_PlaceManage;
        private System.Windows.Forms.ToolStripMenuItem MenuItemQuit;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_SystemConfig;
        private System.Windows.Forms.ToolStripMenuItem 类别设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 场地列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 服务器地址ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 会员管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 财务结算ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 商品出售ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 等级管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 会籍管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 折扣管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripMenuItem 场地预定ToolStripMenuItem;
    }
}

