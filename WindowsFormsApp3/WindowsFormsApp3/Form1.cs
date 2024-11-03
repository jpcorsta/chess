using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class lblStatus : Form
    {
        public lblStatus()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private Task ProcessData(List<string> list, IProgress<ProgressReport> Progress)
        {
            int index = 1;
            int totalProcess = list.Count;
            var progressReport = new ProgressReport();
            return Task.Run(() => { 
                for (int i = 0; i < totalProcess; i++) 
                { 
                    progressReport.PercentComplete=index++*100/ totalProcess;
                }
            });


        }

        private void btnStart_Click(object sender, EventArgs e)
        {

        }
    }
}
