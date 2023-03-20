namespace GuessTheNumber {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {

            int count = 1;
            var rand = new Random();
            int value = 0;
            DialogResult result;
            do {
                value = rand.Next(200);
                String message = "Вами загадано число " + value;
                result = MessageBox.Show(message, "Угадывание числа " + count + " раз", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                count++;
                if(result == DialogResult.Cancel)
                    break;
            } while (value != this.numericUpDown1.Value);
            if (result == DialogResult.Cancel) {
                MessageBox.Show("Угадывание прервано");
            } else
                MessageBox.Show("Количество запросов " + count + " Загаданное число " + value);
            //DialogResult result = MessageBox.Show("Вами загадано число X", "Ответ программы",MessageBoxButtons.OK );
        }
    }
}