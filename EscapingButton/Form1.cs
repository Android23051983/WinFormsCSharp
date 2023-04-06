namespace EscapingButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            Random r = new Random();
            button1.Left = r.Next(0, this.Size.Width - button1.Width);
            button1.Top = r.Next(0, this.Size.Height - button1.Height);
        }
    }
}