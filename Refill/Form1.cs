using System.Reflection;
using System.Windows.Forms;
using UITimer = System.Windows.Forms.Timer;

namespace Refill
{
    public partial class Form1 : Form
    {
        UITimer vTimer = new System.Windows.Forms.Timer();

        double priceFuel = 0;
        double litersFuel = 0;
        double totalMoneyFuel = 0;
        double amountFuel = 0;
        double totalMoney = 0;
        double shopMoney = 0;
        double totalDay = 0;
        double total = 0.00;
        public Form1()
        {
            InitializeComponent();
            vTimer.Tick += new EventHandler(ShowTimer);
            Application.ApplicationExit += new EventHandler(OnApplicationExit);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Location = new Point(0, 0);
            this.comboBox1.Items.AddRange(new object[] { "ÀÈ 92 ÝÊÒÎ", "ÀÈ 95 ÝÊÒÎ", "Äèçåëü ÝÊÒÎ", "ÀÈ 100 ÝÊÒÎ", " " });
            this.litersTextBox.Visible = false;
            this.amountFuelTextBox.Visible = false;
        }
        public void Total()
        {
            if (checkBox1.Checked == false & checkBox2.Checked == false & checkBox3.Checked == false & checkBox4.Checked == false)
            {
                shopLabel.Text = "0,00";
                total = 0;
            }
        }

        public void ShowTimer(object xObject, EventArgs e)
        {
            vTimer.Stop();
            DialogResult result = MessageBox.Show("Ãîòîâû ðàáîòàòü ñ íîâûì êëèåíòîì?", "Íîâûé êëèåíò", MessageBoxButtons.YesNo);
            switch(result)
            {
                case DialogResult.Yes:
                    comboBox1.Text = "ÀÈ 92 ÝÊÒÎ";

                    litersTextBox.Visible= false;
                    litersTextBox.ReadOnly= false;
                    amountFuelTextBox.Visible= false;
                    amountFuelTextBox.ReadOnly= false;

                    radioButton1.Checked = false;
                    radioButton2.Checked = false;

                    totaMoneylFuelLabel.Text = "0,00";

                    sumTextBox1.Text = "1";
                    sumTextBox2.Text = "1";
                    sumTextBox3.Text = "1";
                    sumTextBox4.Text = "1";

                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                    checkBox4.Checked = false;

                    shopLabel.Text = "0,00";

                    totalLabel.Text = "0,00";
                    break;
                case DialogResult.No:
                    if (Convert.ToDouble(totalLabel.Text) > 0)
                    {
                        vTimer.Interval = Decimal.ToInt32(10) * 1000;
                        vTimer.Start();
                    }
                    break;
            }
        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            MessageBox.Show(totalDay.ToString().ToUpper() + " ðóá.", "Çàðàáîòîê çà òåêóùèé äåíü");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.comboBox1.Text)
            {
                case "ÀÈ 92 ÝÊÒÎ":
                    this.textBox1.Text = "49,19";
                    break;
                case "ÀÈ 95 ÝÊÒÎ":
                    this.textBox1.Text = "54,60";
                    break;
                case "Äèçåëü ÝÊÒÎ":
                    this.textBox1.Text = "53,50";
                    break;
                case "ÀÈ 100 ÝÊÒÎ":
                    this.textBox1.Text = "66,41";
                    break;
                case " ":
                    this.textBox1.Text = "0,00";
                    break;
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBox1.Checked)
            {
                case true:
                    total += Convert.ToDouble(priceTextBox1.Text) * Convert.ToDouble(sumTextBox1.Text);
                    break;
                case false:
                    total -= Convert.ToDouble(priceTextBox1.Text) * Convert.ToDouble(sumTextBox1.Text);
                    break;
            }
            //if (checkBox1.Checked==true)
            //{
            //    double price = Convert.ToDouble(priceTextBox1.Text);
            //    double sum = Convert.ToDouble(sumTextBox1.Text);
            //    double result = price * sum;
            //    total += result;
            //}
            //if(checkBox1.Checked==false)
            //{
            //    total -= result;
            //}

            shopLabel.Text = total.ToString();
            Total();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBox2.Checked)
            {
                case true:
                    total += Convert.ToDouble(priceTextBox2.Text) * Convert.ToDouble(sumTextBox2.Text);
                    break;
                case false:
                    total -= Convert.ToDouble(priceTextBox2.Text) * Convert.ToDouble(sumTextBox2.Text);
                    break;
            }
            //if (checkBox2.Checked==true)
            //{
            //    result = Quantity(priceTextBox2, sumTextBox2);
            //    total += result;
            //}
            //else if(checkBox2.Checked == false)
            //{
            //    total -= result;
            //}
            shopLabel.Text = total.ToString();
            Total();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBox3.Checked)
            {
                case true:
                    total += Convert.ToDouble(priceTextBox3.Text) * Convert.ToDouble(sumTextBox3.Text);
                    break;
                case false:
                    total -= Convert.ToDouble(priceTextBox3.Text) * Convert.ToDouble(sumTextBox3.Text);
                    break;
            }
            //if (checkBox3.Checked == true)
            //{
            //    result = Quantity(priceTextBox3, sumTextBox3);
            //    total += result;
            //}
            //else if (checkBox3.Checked == false) 
            //{
            //    total -= result;
            //}
            shopLabel.Text = total.ToString();
            Total();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBox4.Checked)
            {
                case true:
                    total += Convert.ToDouble(priceTextBox4.Text) * Convert.ToDouble(sumTextBox4.Text);
                    break;
                case false:
                    total -= Convert.ToDouble(priceTextBox4.Text) * Convert.ToDouble(sumTextBox4.Text);
                    break;
            }
            //if (checkBox4.Checked == true)
            //{
            //    result = Quantity(priceTextBox4, sumTextBox4);
            //    total += result;
            //}
            //else if (checkBox4.Checked == false) 
            //{
            //    total -= result;
            //}
            shopLabel.Text = total.ToString();
            Total();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            totalMoney = Convert.ToDouble(totaMoneylFuelLabel.Text);
            shopMoney = Convert.ToDouble(shopLabel.Text);
            totalLabel.Text = Convert.ToString(totalMoney + shopMoney);
            totalDay += Convert.ToDouble(totalLabel.Text);
            totalDayLabel.Text = "Ñåé÷àñ â êàññå " + totalDay + " ðóá.";
            if (Convert.ToDouble(totalLabel.Text) > 0)
            {
                vTimer.Interval = Decimal.ToInt32(10) * 1000;
                vTimer.Start();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            totaMoneylFuelLabel.Text = "0,00";
            litersTextBox.Clear();
            amountFuelTextBox.Clear();
            litersTextBox.Visible = true;
            litersTextBox.ReadOnly = false;
            amountFuelTextBox.Visible = true;
            amountFuelTextBox.ReadOnly = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            totaMoneylFuelLabel.Text = "0,00";
            litersTextBox.Clear();
            amountFuelTextBox.Clear();
            litersTextBox.Visible = true;
            litersTextBox.ReadOnly = true;
            amountFuelTextBox.Visible = true;
            amountFuelTextBox.ReadOnly = false;
        }
        private void litersTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                priceFuel = Convert.ToDouble(textBox1.Text);
                litersFuel = Convert.ToDouble(litersTextBox.Text);
                totalMoneyFuel = priceFuel * litersFuel;
                totalMoneyFuel = Convert.ToInt32(totalMoneyFuel);
                amountFuelTextBox.Text = totalMoneyFuel.ToString();
                totaMoneylFuelLabel.Text = totalMoneyFuel.ToString();

            }
        }

        private void amountFuelTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                priceFuel = Convert.ToDouble(textBox1.Text);
                amountFuel = Convert.ToDouble(amountFuelTextBox.Text);
                litersFuel = amountFuel / priceFuel;
                litersFuel = Math.Round(litersFuel, 2, MidpointRounding.ToEven);
                litersTextBox.Text = litersFuel.ToString();
                totaMoneylFuelLabel.Text = amountFuel.ToString();

            }
        }
    }
}