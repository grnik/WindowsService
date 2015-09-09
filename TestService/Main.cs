using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logical;

namespace TestService
{
    public partial class Main : Form
    {
        ServiceTest service;

        public Main()
        {
            InitializeComponent();
        }

        private void btTestLogical_Click(object sender, EventArgs e)
        {
            using (LogFile file = new LogFile())
            {
                file.Write("Я работаю!!!");

                MessageBox.Show(String.Format("Файл с логом {0}", file.FileName));
            }
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            service = new ServiceTest();

            service.TestStart(new string[0]);

            btStart.Enabled = false;
            btStop.Enabled = true;
            btPause.Enabled = true;
            btContinue.Enabled = false;
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            service.TestStop();

            btStart.Enabled = true;
            btStop.Enabled = false;
            btPause.Enabled = false;
            btContinue.Enabled = false;
        }

        private void btPause_Click(object sender, EventArgs e)
        {
            service.TestPause();

            btStart.Enabled = false;
            btStop.Enabled = true;
            btPause.Enabled = false;
            btContinue.Enabled = true;
        }

        private void btContinue_Click(object sender, EventArgs e)
        {
            service.TestContinue();

            btStart.Enabled = false;
            btStop.Enabled = true;
            btPause.Enabled = true;
            btContinue.Enabled = false;
        }
    }
}
