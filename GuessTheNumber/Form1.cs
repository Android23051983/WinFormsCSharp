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
                String message = "���� �������� ����� " + value;
                result = MessageBox.Show(message, "���������� ����� " + count + " ���", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                count++;
                if(result == DialogResult.Cancel)
                    break;
            } while (value != this.numericUpDown1.Value);
            if (result == DialogResult.Cancel) {
                MessageBox.Show("���������� ��������");
            } else
                MessageBox.Show("���������� �������� " + count + " ���������� ����� " + value);
            //DialogResult result = MessageBox.Show("���� �������� ����� X", "����� ���������",MessageBoxButtons.OK );
        }
    }
}