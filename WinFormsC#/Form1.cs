namespace WinFormsC_ {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            int i = 0;
            int strlLength = 0;
            String caption = "������";
            String message = "������������. ���� ����� �������� ������ ������������";
            strlLength += message.Length;
            i++;
            DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.OK) {
                message = "� ������ ������ � ������� �������� \"���\"";
                caption += " \"�����������\"";
                strlLength += message.Length;
                i++;
                result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK) {
                    i++;
                    message = "����� � ����� ������������� �������������";
                    strlLength += message.Length;
                    int temp = strlLength / i;
                    result = MessageBox.Show(message, "���-�� MB: " + i + ", ����: " + strlLength + ", ������ �� ���� MB: " + temp, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK) {
                        Application.Exit();
                    }
                }
            }
        }
    }


}