using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lecture5
{
    public delegate void ChangeUI(string data);
    public partial class Form1 : Form
    {
        private event ChangeUI myUI;
        private Threads threads;

        public void ChangeText(string data)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(myUI, data);
                return;
            }
            textBox1.AppendText(data + Environment.NewLine + "-------------------------------------------" 
                + Environment.NewLine);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            myUI = new ChangeUI(ChangeText);
            threads = new Threads(myUI);
            threads.Run();
            startButton.Text = "Restart";
            stopButton.Visible = true;
            resumeButton.Visible = false;

        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            threads.Stop();
            stopButton.Visible = false;
            resumeButton.Visible = true;
        }

        private void resumeButton_Click(object sender, EventArgs e)
        {
            threads.Resume();
            stopButton.Visible = true;
            resumeButton.Visible = false;
        }
    }
}
