using System.Diagnostics;
using System.Windows.Forms;

namespace Static
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        struct MouseCoords
        {
            int x;
            int y;

            public int X { get; set; }
            public int Y { get; set; }

            public override string ToString() => $"X = {X}, Y = {Y}";
        }

        MouseCoords mc1 = new MouseCoords();
        MouseCoords mc2 = new MouseCoords();
        MouseCoords upperLeftCorner = new MouseCoords();
        MouseCoords lowerRightCorner = new MouseCoords();
        Stopwatch st = new Stopwatch();
        MouseButtons mb = MouseButtons.Left;
        int tabIndex = 0;
        private void DrawForm(int tabIndex, int x, int y, int x1, int y1)
        {
            Button button = new Button();
            string buttonName = "button" + tabIndex;

            if (x < x1 && y < y1)
            {
                button.Location = new Point(x, y);
                button.Size = new Size(x1 - x, y1 - y);
            }
            else
            {
                upperLeftCorner = mc2;
                lowerRightCorner = mc1;
                button.Location = new Point(x1, y1);
                button.Size = new Size(x - x1, y - y1);
            }
            button.Name = buttonName;
            button.TabIndex = tabIndex;
            button.Text = "Статик " + tabIndex;
            button.Tag = tabIndex;
            button.UseVisualStyleBackColor = true;
            if (button.Size.Height < 10 && button.Size.Width < 10)
            {
                MessageBox.Show("Выделенный размер меньше 10", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (tabIndex > 1)
                {
                    for (int i = 1; i < tabIndex - 1; i++)
                    {
                        string name = "button" + i;
                    }
                }
                this.Controls.Add(button);
                //this.Text = "Статик " + count.ToString();
                button.BringToFront();
                button.Select();
                button.Focus();
                
            }


        }
    
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            int count = this.Controls.Count;
            int[] nb = new int[10];
            if (!st.IsRunning)
            {
                mb = e.Button;
                st.Start();
                mc1.X = e.X;
                mc1.Y = e.Y;
            }
            if (e.Button == MouseButtons.Right)
            {

                for (int i = 0; i < count; i++)
                {
                    if ((e.X >= this.Controls[i].Location.X || e.X <= this.Controls[i].Width) || (e.Y >= this.Controls[i].Location.Y || e.Y <= this.Controls[i].Height))
                    {
                        nb[i] = i; 
                    }
                }
                for (int i = 0; i < nb.Length; i++)
                {
                    MessageBox.Show(Convert.ToString(nb[i]),"Номер кнопки", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == mb)
            {
                mc2.X = e.X;
                mc2.Y = e.Y;
                DrawForm(tabIndex, mc1.X, mc1.Y, mc2.X, mc2.Y);
                if (mc1.X > mc2.X || mc1.Y > mc2.Y)
                {
                    MessageBox.Show("X,Y\n" + mc2.X.ToString() + "," + mc2.Y.ToString() + " " + mc1.X.ToString() + "," + mc1.Y.ToString(), "Координаты элемента", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("X,Y\n" + mc1.X.ToString() + "," + mc1.Y.ToString() + " " + mc2.X.ToString() + "," + mc2.Y.ToString(), "Координаты элемента", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ToString();
                st.Stop();
                mb = MouseButtons.None;
                st.Reset();
                tabIndex++;
                
            }
        }
    }
}