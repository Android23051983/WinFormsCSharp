using System.Globalization;

namespace DeyOfTheWeek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DateTime date = new DateTime();
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            date = dateTimePicker1.Value;
            label1.Text = "День недели " + date.ToString("dddd", CultureInfo.GetCultureInfo("ru-ru"));
        }
    }
}