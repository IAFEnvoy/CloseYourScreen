namespace 快捷指令
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.关闭显示器 = new System.Windows.Forms.ToolStripMenuItem();
            this.启动 = new System.Windows.Forms.ToolStripMenuItem();
            this.任务管理器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.退出 = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.关闭显示器并锁定电脑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "右键打开菜单";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关闭显示器,
            this.关闭显示器并锁定电脑ToolStripMenuItem,
            this.启动,
            this.toolStripSeparator1,
            this.退出});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(229, 134);
            // 
            // 关闭显示器
            // 
            this.关闭显示器.Name = "关闭显示器";
            this.关闭显示器.Size = new System.Drawing.Size(228, 24);
            this.关闭显示器.Text = "关闭显示器";
            this.关闭显示器.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // 启动
            // 
            this.启动.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.任务管理器ToolStripMenuItem,
            this.cmdToolStripMenuItem});
            this.启动.Name = "启动";
            this.启动.Size = new System.Drawing.Size(228, 24);
            this.启动.Text = "启动";
            this.启动.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // 任务管理器ToolStripMenuItem
            // 
            this.任务管理器ToolStripMenuItem.Name = "任务管理器ToolStripMenuItem";
            this.任务管理器ToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.任务管理器ToolStripMenuItem.Text = "任务管理器";
            this.任务管理器ToolStripMenuItem.Click += new System.EventHandler(this.任务管理器ToolStripMenuItem_Click);
            // 
            // cmdToolStripMenuItem
            // 
            this.cmdToolStripMenuItem.Name = "cmdToolStripMenuItem";
            this.cmdToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.cmdToolStripMenuItem.Text = "cmd";
            this.cmdToolStripMenuItem.Click += new System.EventHandler(this.cmdToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(225, 6);
            // 
            // 退出
            // 
            this.退出.Name = "退出";
            this.退出.Size = new System.Drawing.Size(228, 24);
            this.退出.Text = "退出";
            this.退出.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // 关闭显示器并锁定电脑ToolStripMenuItem
            // 
            this.关闭显示器并锁定电脑ToolStripMenuItem.Name = "关闭显示器并锁定电脑ToolStripMenuItem";
            this.关闭显示器并锁定电脑ToolStripMenuItem.Size = new System.Drawing.Size(228, 24);
            this.关闭显示器并锁定电脑ToolStripMenuItem.Text = "关闭显示器并锁定电脑";
            this.关闭显示器并锁定电脑ToolStripMenuItem.Click += new System.EventHandler(this.关闭显示器并锁定电脑ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 496);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "快捷指令";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 关闭显示器;
        private System.Windows.Forms.ToolStripMenuItem 退出;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 启动;
        private System.Windows.Forms.ToolStripMenuItem 任务管理器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭显示器并锁定电脑ToolStripMenuItem;
    }
}

