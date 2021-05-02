using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using System.Diagnostics;
using System.Runtime.Remoting.Messaging;

namespace 快捷指令
{
    public partial class Form1 : Form
    {
        bool ok = false;
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint msg, uint wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern void LockWorkStation();

        private const uint WM_SYSCOMMAND = 0x0112;

        private const uint SC_MONITORPOWER = 0xF170;
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MONITORPOWER, 2);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.notifyIcon1.ShowBalloonTip(60, "快捷指令", "所有指令都在桌面右下角的任务栏的系统托盘区哦！" + Environment.NewLine + "右键图标即可使用。", ToolTipIcon.None);
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ok == true) {
                timer1.Enabled = false;
                Hide();
            } 
            ok = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void 任务管理器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = true;
            p.Start();
            p.StandardInput.WriteLine("taskmgr.exe");
            p.StandardInput.AutoFlush = true;
        }

        private void cmdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd.exe", "C:\\Windows\\system32");
        }

        private void 关闭显示器并锁定电脑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LockWorkStation();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MONITORPOWER, 2);
        }
    }
}
