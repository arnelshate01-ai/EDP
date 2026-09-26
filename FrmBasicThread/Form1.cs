namespace FrmBasicThread
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("-Before Starting Thread-");

            Thread ThreadA = new Thread(MyThreadClass.Thread1);
            Thread ThreadB = new Thread(MyThreadClass.Thread1);

            ThreadA.Name = "Thread A";
            ThreadB.Name = "Thread B";

            ThreadA.Start();
            ThreadB.Start();

            ThreadA.Join();
            ThreadB.Join();

            Console.WriteLine("-End of the Thread-");
            lblDisplay.Text = "-End of the Thread-";
        }
    }
}
