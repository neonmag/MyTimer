namespace MyTimer
{
    public partial class Form1 : Form
    {
        private static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        DateTime myTime = new DateTime();
        public Form1()
        {
            InitializeComponent();
            myTimer.Interval = 1;
            myTimer.Start();
            this.Text = "0";
            myTime = DateTime.Now.ToLocalTime();
            label1.Text = DateTime.Now.ToLongTimeString();
            label4.Text = DateTime.Now.ToLongTimeString();
            myTimer.Tick += new EventHandler(CheckTime);
        }
        private void CheckTime(object vObj, EventArgs e)
        {
            label4.Text = DateTime.Now.ToLongTimeString();
            this.Text = (DateTime.Now - myTime).TotalMilliseconds.ToString();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
        }
    }
}