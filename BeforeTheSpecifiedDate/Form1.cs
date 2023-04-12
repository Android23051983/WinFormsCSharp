using Microsoft.VisualBasic;
using System;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Threading.Timer;
using Timer = System.Windows.Forms.Timer;

namespace BeforeTheSpecifiedDate
{
    public partial class Form1 : Form
    {
        DateTime dt = new DateTime(2026, 11, 30, 6, 0, 0);
        Timer timer1 = new Timer();
        int years;
        int months;
        int days;

        public Form1()
        {
            InitializeComponent();
            timer1.Tick += timer1_Tick;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dt = Convert.ToDateTime(textBox1.Text);
                label3.Text = $"До {textBox1.Text} осталось";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = dt.ToString("d");
            label3.Text = $"До {textBox1.Text} осталось";
            label1.Text = "00:00:00";
        }
        void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan TimeRemaining = dt - DateTime.Now;
            if(radioButton1.Checked)
            {
                YearsMonths.GetYearsMonthsDays(dt, DateTime.Now, out years, out months, out days);
                label1.Text = years+"Г "+months+"М "+days+"Д ";
            }
            else if(radioButton2.Checked)
            {
                YearsMonths.GetMonthsDays(dt, DateTime.Now, out months, out days);
                label1.Text = months+"М " + days+"Д";
            }
            else if (radioButton3.Checked)
            {
                int totalDays = (int)Math.Abs(TimeRemaining.TotalDays);
                label1.Text = totalDays.ToString();//TimeRemaining.TotalDays.ToString();
            }
            else if (radioButton4.Checked)
            {
                int totalMinutes = (int)Math.Abs(TimeRemaining.TotalMinutes);
                label1.Text = totalMinutes.ToString();//TimeRemaining.TotalMinutes.ToString();
            }
            else if (radioButton5.Checked)
            {
                int totalSeconds = (int)Math.Abs(TimeRemaining.TotalSeconds);
                label1.Text = totalSeconds.ToString();//TimeRemaining.TotalSeconds.ToString();
            }
            else
            {
                label1.Text = TimeRemaining.Days + " : " + TimeRemaining.Hours + " : " + TimeRemaining.Minutes + " : " + TimeRemaining.Seconds;
            }
        }
       
     

    }
}