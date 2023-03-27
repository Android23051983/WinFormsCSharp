using Microsoft.VisualBasic.Devices;
using System.Windows.Forms;

namespace CoordinatesOfTtheForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && Control.ModifierKeys == Keys.Control)
            {
                Application.Exit();
            }
            if (e.Button == MouseButtons.Left)
            {

                if ((e.X < 10 || e.X > this.ClientSize.Width - 10) || (e.Y < 10 || e.Y > this.ClientSize.Height - 10))
                {
                    MessageBox.Show("ٸ������ ������� ��������������", "���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (e.X == 10 || e.Y == 10)
                {
                    MessageBox.Show("ٸ������ �� ������� ��������������", "���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("ٸ������ ������ ��������������", "���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //this.Text = $"{this.Width-10}, {this.Height-10}";
                //this.Text = "X: " + e.X.ToString() + "Y: " + e.Y.ToString();
            }
            if(e.Button == MouseButtons.Right)
            {
                this.Text = "������� ������� ������� X: " + this.ClientSize.Width + " Y: " + this.ClientSize.Height;
            }
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = " ��������� ������� X: " + e.X + " Y:" + e.Y ;
        }
    }
}