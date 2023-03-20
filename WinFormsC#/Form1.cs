namespace WinFormsC_ {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            int i = 0;
            int strlLength = 0;
            String caption = "Резюме";
            String message = "Здравствуйте. Меня зовут Щербаков Андрей Владимирович";
            strlLength += message.Length;
            i++;
            DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.OK) {
                message = "В данный момент я студент Академии \"ТОР\"";
                caption += " \"продолжение\"";
                strlLength += message.Length;
                i++;
                result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK) {
                    i++;
                    message = "Скоро я стану первоклассным программистом";
                    strlLength += message.Length;
                    int temp = strlLength / i;
                    result = MessageBox.Show(message, "Кол-во MB: " + i + ", букв: " + strlLength + ", знаков на одно MB: " + temp, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK) {
                        Application.Exit();
                    }
                }
            }
        }
    }


}