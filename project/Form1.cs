using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChineseDamsTest
{
    public partial class mainForm : Form
    {
        public Statistics sti;
        public Image img;

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            sti = new Statistics();
            sti.Dock = DockStyle.Fill;
            img = new Image();    //实例化
            img.Dock = DockStyle.Fill;
        }

        //显示用于统计功能的窗口
        private void staBtn_Click(object sender, EventArgs e)
        {
            sti.Show();
            WorkPanel.Controls.Clear();
            WorkPanel.Controls.Add(sti);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            img.Show();
            WorkPanel.Controls.Clear();
            WorkPanel.Controls.Add(img);
        }
    }
}
