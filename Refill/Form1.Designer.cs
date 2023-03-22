namespace Refill
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            comboBox1 = new ComboBox();
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            label6 = new Label();
            totaMoneylFuelLabel = new Label();
            amountFuelTextBox = new TextBox();
            litersTextBox = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            priceTextBox4 = new TextBox();
            priceTextBox3 = new TextBox();
            priceTextBox2 = new TextBox();
            priceTextBox1 = new TextBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            sumTextBox4 = new TextBox();
            sumTextBox3 = new TextBox();
            sumTextBox2 = new TextBox();
            sumTextBox1 = new TextBox();
            label13 = new Label();
            label10 = new Label();
            checkBox1 = new CheckBox();
            groupBox5 = new GroupBox();
            label11 = new Label();
            shopLabel = new Label();
            groupBox6 = new GroupBox();
            button1 = new Button();
            label8 = new Label();
            totalLabel = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(94, 31);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(244, 29);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(amountFuelTextBox);
            groupBox1.Controls.Add(litersTextBox);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Location = new Point(15, 17);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(408, 476);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Автозаправка";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(346, 179);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(21, 21);
            label5.TabIndex = 10;
            label5.Text = "л.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(347, 228);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(39, 21);
            label4.TabIndex = 9;
            label4.Text = "руб.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(347, 113);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(39, 21);
            label3.TabIndex = 8;
            label3.Text = "руб.";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(totaMoneylFuelLabel);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(8, 290);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(378, 170);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "К оплате:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(333, 99);
            label6.Name = "label6";
            label6.Size = new Size(39, 21);
            label6.TabIndex = 3;
            label6.Text = "руб.";
            // 
            // totaMoneylFuelLabel
            // 
            totaMoneylFuelLabel.AutoSize = true;
            totaMoneylFuelLabel.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            totaMoneylFuelLabel.Location = new Point(190, 70);
            totaMoneylFuelLabel.Name = "totaMoneylFuelLabel";
            totaMoneylFuelLabel.Size = new Size(95, 50);
            totaMoneylFuelLabel.TabIndex = 2;
            totaMoneylFuelLabel.Text = "0,00";
            // 
            // amountFuelTextBox
            // 
            amountFuelTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            amountFuelTextBox.Location = new Point(184, 220);
            amountFuelTextBox.Margin = new Padding(4);
            amountFuelTextBox.Name = "amountFuelTextBox";
            amountFuelTextBox.Size = new Size(154, 29);
            amountFuelTextBox.TabIndex = 6;
            amountFuelTextBox.KeyDown += amountFuelTextBox_KeyDown;
            // 
            // litersTextBox
            // 
            litersTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            litersTextBox.Location = new Point(184, 171);
            litersTextBox.Margin = new Padding(4);
            litersTextBox.Name = "litersTextBox";
            litersTextBox.Size = new Size(154, 29);
            litersTextBox.TabIndex = 5;
            litersTextBox.KeyDown += litersTextBox_KeyDown;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(94, 105);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(244, 29);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(8, 109);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(47, 21);
            label2.TabIndex = 2;
            label2.Text = "Цена";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(8, 35);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 21);
            label1.TabIndex = 1;
            label1.Text = "Бензин";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.Location = new Point(14, 62);
            radioButton2.Margin = new Padding(4);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(76, 25);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Сумма";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = SystemColors.Control;
            radioButton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(14, 18);
            radioButton1.Margin = new Padding(4);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(111, 25);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Количество";
            radioButton1.UseVisualStyleBackColor = false;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioButton1);
            groupBox3.Controls.Add(radioButton2);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(15, 171);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(165, 106);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(priceTextBox4);
            groupBox4.Controls.Add(priceTextBox3);
            groupBox4.Controls.Add(priceTextBox2);
            groupBox4.Controls.Add(priceTextBox1);
            groupBox4.Controls.Add(checkBox4);
            groupBox4.Controls.Add(checkBox3);
            groupBox4.Controls.Add(checkBox2);
            groupBox4.Controls.Add(sumTextBox4);
            groupBox4.Controls.Add(sumTextBox3);
            groupBox4.Controls.Add(sumTextBox2);
            groupBox4.Controls.Add(sumTextBox1);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(checkBox1);
            groupBox4.Controls.Add(groupBox5);
            groupBox4.Location = new Point(470, 17);
            groupBox4.Margin = new Padding(4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4);
            groupBox4.Size = new Size(408, 476);
            groupBox4.TabIndex = 11;
            groupBox4.TabStop = false;
            groupBox4.Text = "Мини-Кафе";
            // 
            // priceTextBox4
            // 
            priceTextBox4.Location = new Point(196, 212);
            priceTextBox4.Name = "priceTextBox4";
            priceTextBox4.Size = new Size(100, 29);
            priceTextBox4.TabIndex = 25;
            priceTextBox4.Text = "100";
            // 
            // priceTextBox3
            // 
            priceTextBox3.Location = new Point(196, 154);
            priceTextBox3.Name = "priceTextBox3";
            priceTextBox3.Size = new Size(100, 29);
            priceTextBox3.TabIndex = 24;
            priceTextBox3.Text = "85";
            // 
            // priceTextBox2
            // 
            priceTextBox2.Location = new Point(196, 101);
            priceTextBox2.Name = "priceTextBox2";
            priceTextBox2.Size = new Size(100, 29);
            priceTextBox2.TabIndex = 23;
            priceTextBox2.Text = "120";
            // 
            // priceTextBox1
            // 
            priceTextBox1.Location = new Point(196, 50);
            priceTextBox1.Name = "priceTextBox1";
            priceTextBox1.Size = new Size(100, 29);
            priceTextBox1.TabIndex = 22;
            priceTextBox1.Text = "220";
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(29, 216);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(66, 25);
            checkBox4.TabIndex = 21;
            checkBox4.Text = "Кофе";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(29, 158);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(57, 25);
            checkBox3.TabIndex = 20;
            checkBox3.Text = "Чай";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(29, 105);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(75, 25);
            checkBox2.TabIndex = 19;
            checkBox2.Text = "Беляш";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // sumTextBox4
            // 
            sumTextBox4.Location = new Point(308, 212);
            sumTextBox4.Name = "sumTextBox4";
            sumTextBox4.Size = new Size(100, 29);
            sumTextBox4.TabIndex = 18;
            sumTextBox4.Text = "1";
            // 
            // sumTextBox3
            // 
            sumTextBox3.Location = new Point(308, 154);
            sumTextBox3.Name = "sumTextBox3";
            sumTextBox3.Size = new Size(100, 29);
            sumTextBox3.TabIndex = 16;
            sumTextBox3.Text = "1";
            // 
            // sumTextBox2
            // 
            sumTextBox2.Location = new Point(308, 101);
            sumTextBox2.Name = "sumTextBox2";
            sumTextBox2.Size = new Size(100, 29);
            sumTextBox2.TabIndex = 14;
            sumTextBox2.Text = "1";
            // 
            // sumTextBox1
            // 
            sumTextBox1.Location = new Point(308, 50);
            sumTextBox1.Name = "sumTextBox1";
            sumTextBox1.Size = new Size(100, 29);
            sumTextBox1.TabIndex = 12;
            sumTextBox1.Text = "1";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(315, 26);
            label13.Name = "label13";
            label13.Size = new Size(93, 21);
            label13.TabIndex = 10;
            label13.Text = "Количество";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(222, 26);
            label10.Name = "label10";
            label10.Size = new Size(47, 21);
            label10.TabIndex = 9;
            label10.Text = "Цена";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(29, 54);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(88, 25);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Шаурма";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label11);
            groupBox5.Controls.Add(shopLabel);
            groupBox5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox5.Location = new Point(8, 290);
            groupBox5.Margin = new Padding(4);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(4);
            groupBox5.Size = new Size(378, 170);
            groupBox5.TabIndex = 7;
            groupBox5.TabStop = false;
            groupBox5.Text = "К оплате:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(336, 99);
            label11.Name = "label11";
            label11.Size = new Size(39, 21);
            label11.TabIndex = 1;
            label11.Text = "руб.";
            // 
            // shopLabel
            // 
            shopLabel.AutoSize = true;
            shopLabel.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            shopLabel.Location = new Point(193, 70);
            shopLabel.Name = "shopLabel";
            shopLabel.Size = new Size(95, 50);
            shopLabel.TabIndex = 0;
            shopLabel.Text = "0,00";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(button1);
            groupBox6.Controls.Add(label8);
            groupBox6.Controls.Add(totalLabel);
            groupBox6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox6.Location = new Point(15, 526);
            groupBox6.Margin = new Padding(4);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(4);
            groupBox6.Size = new Size(863, 142);
            groupBox6.TabIndex = 8;
            groupBox6.TabStop = false;
            groupBox6.Text = "ИТОГ К оплате:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(148, 45);
            button1.Name = "button1";
            button1.Size = new Size(190, 90);
            button1.TabIndex = 2;
            button1.Text = "Просчитать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(802, 95);
            label8.Name = "label8";
            label8.Size = new Size(39, 21);
            label8.TabIndex = 1;
            label8.Text = "руб.";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            totalLabel.Location = new Point(656, 66);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(95, 50);
            totalLabel.TabIndex = 0;
            totalLabel.Text = "0,00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 702);
            Controls.Add(groupBox6);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Лукойл";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox amountFuelTextBox;
        private TextBox litersTextBox;
        private Label label5;
        private Label label4;
        private Label label3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private Label label11;
        private Label shopLabel;
        private GroupBox groupBox6;
        private Button button1;
        private Label label8;
        private Label totalLabel;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private TextBox sumTextBox4;
        private TextBox sumTextBox3;
        private TextBox sumTextBox2;
        private TextBox sumTextBox1;
        private Label label13;
        private Label label10;
        private CheckBox checkBox1;
        private TextBox priceTextBox1;
        private TextBox priceTextBox4;
        private TextBox priceTextBox3;
        private TextBox priceTextBox2;
        private Label label6;
        private Label totaMoneylFuelLabel;
    }
}