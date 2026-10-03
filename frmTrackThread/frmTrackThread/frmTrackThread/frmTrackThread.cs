using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmTrackThread
{
    public partial class frmTrackThread : Form
    {
        Thread threadA;
        Thread threadB;
        Thread threadC;
        Thread threadD;

        public frmTrackThread()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Console.WriteLine("-Thread Starts-");
            threadA = new Thread(MyThreadClass.Thread1);
            threadB = new Thread(MyThreadClass.Thread1);
            threadC = new Thread(MyThreadClass.Thread2);
            threadD = new Thread(MyThreadClass.Thread2);

            threadA.Name = "Thread A";
            threadB.Name = "Thread B";
            threadC.Name = "Thread C";
            threadD.Name = "Thread D";

            threadA.Priority = System.Threading.ThreadPriority.Highest;
            threadB.Priority = System.Threading.ThreadPriority.Normal;
            threadC.Priority = System.Threading.ThreadPriority.AboveNormal;
            threadD.Priority = System.Threading.ThreadPriority.BelowNormal;

            threadA.Start();
            threadB.Start();
            threadC.Start();
            threadD.Start();

            threadA.Join();
            threadB.Join();
            threadC.Join();
            threadD.Join();

            Console.WriteLine("-End Of Thread-");
            lblStatus.Text = "-End Of Thread-";
        }
    }
}

