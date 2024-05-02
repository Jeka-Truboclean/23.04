namespace _23._04
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
            groupBox1 = new GroupBox();
            GasolinePayGroupBox = new GroupBox();
            GasolinePayGroupBoxLabel = new Label();
            gasStationTotalLabel = new Label();
            label5 = new Label();
            label4 = new Label();
            AmountNumeric = new NumericUpDown();
            CountNumeric = new NumericUpDown();
            groupBox4 = new GroupBox();
            AmountRadioButton = new RadioButton();
            CountRadioButton = new RadioButton();
            label3 = new Label();
            PriceTextBox = new TextBox();
            GasolineComboBox = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            MiniCafeGroupBox = new GroupBox();
            label11 = new Label();
            label10 = new Label();
            groupBox6 = new GroupBox();
            label8 = new Label();
            MiniCafeTotalLabel = new Label();
            groupBox3 = new GroupBox();
            label12 = new Label();
            TotalToPayLabel = new Label();
            pictureBox1 = new PictureBox();
            PayButton = new Button();
            groupBox1.SuspendLayout();
            GasolinePayGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AmountNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CountNumeric).BeginInit();
            groupBox4.SuspendLayout();
            MiniCafeGroupBox.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(GasolinePayGroupBox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(AmountNumeric);
            groupBox1.Controls.Add(CountNumeric);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(PriceTextBox);
            groupBox1.Controls.Add(GasolineComboBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(289, 293);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Автозаправка";
            // 
            // GasolinePayGroupBox
            // 
            GasolinePayGroupBox.Controls.Add(GasolinePayGroupBoxLabel);
            GasolinePayGroupBox.Controls.Add(gasStationTotalLabel);
            GasolinePayGroupBox.Location = new Point(6, 179);
            GasolinePayGroupBox.Name = "GasolinePayGroupBox";
            GasolinePayGroupBox.Size = new Size(271, 102);
            GasolinePayGroupBox.TabIndex = 10;
            GasolinePayGroupBox.TabStop = false;
            GasolinePayGroupBox.Text = "К оплате";
            // 
            // GasolinePayGroupBoxLabel
            // 
            GasolinePayGroupBoxLabel.AutoSize = true;
            GasolinePayGroupBoxLabel.Location = new Point(240, 83);
            GasolinePayGroupBoxLabel.Name = "GasolinePayGroupBoxLabel";
            GasolinePayGroupBoxLabel.Size = new Size(26, 15);
            GasolinePayGroupBoxLabel.TabIndex = 10;
            GasolinePayGroupBoxLabel.Text = "грн";
            // 
            // gasStationTotalLabel
            // 
            gasStationTotalLabel.AutoSize = true;
            gasStationTotalLabel.Font = new Font("Segoe UI Semibold", 48F, FontStyle.Bold, GraphicsUnit.Point, 204);
            gasStationTotalLabel.Location = new Point(70, 10);
            gasStationTotalLabel.Name = "gasStationTotalLabel";
            gasStationTotalLabel.Size = new Size(73, 86);
            gasStationTotalLabel.TabIndex = 0;
            gasStationTotalLabel.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(252, 142);
            label5.Name = "label5";
            label5.Size = new Size(26, 15);
            label5.TabIndex = 9;
            label5.Text = "грн";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(252, 117);
            label4.Name = "label4";
            label4.Size = new Size(14, 15);
            label4.TabIndex = 8;
            label4.Text = "л";
            // 
            // AmountNumeric
            // 
            AmountNumeric.Location = new Point(126, 138);
            AmountNumeric.Name = "AmountNumeric";
            AmountNumeric.Size = new Size(120, 23);
            AmountNumeric.TabIndex = 7;
            AmountNumeric.ValueChanged += AmountNumeric_ValueChanged;
            // 
            // CountNumeric
            // 
            CountNumeric.Location = new Point(126, 109);
            CountNumeric.Name = "CountNumeric";
            CountNumeric.Size = new Size(120, 23);
            CountNumeric.TabIndex = 6;
            CountNumeric.ValueChanged += CountNumeric_ValueChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(AmountRadioButton);
            groupBox4.Controls.Add(CountRadioButton);
            groupBox4.Location = new Point(6, 91);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(107, 82);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            // 
            // AmountRadioButton
            // 
            AmountRadioButton.AutoSize = true;
            AmountRadioButton.Location = new Point(7, 47);
            AmountRadioButton.Name = "AmountRadioButton";
            AmountRadioButton.Size = new Size(63, 19);
            AmountRadioButton.TabIndex = 1;
            AmountRadioButton.TabStop = true;
            AmountRadioButton.Text = "Сумма";
            AmountRadioButton.UseVisualStyleBackColor = true;
            AmountRadioButton.CheckedChanged += CountOrPriceRadioButton_CheckedChanged;
            // 
            // CountRadioButton
            // 
            CountRadioButton.AutoSize = true;
            CountRadioButton.Location = new Point(7, 22);
            CountRadioButton.Name = "CountRadioButton";
            CountRadioButton.Size = new Size(90, 19);
            CountRadioButton.TabIndex = 0;
            CountRadioButton.TabStop = true;
            CountRadioButton.Text = "Количество";
            CountRadioButton.UseVisualStyleBackColor = true;
            CountRadioButton.CheckedChanged += CountOrPriceRadioButton_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(251, 70);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 4;
            label3.Text = "грн";
            // 
            // PriceTextBox
            // 
            PriceTextBox.Enabled = false;
            PriceTextBox.Location = new Point(71, 62);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(176, 23);
            PriceTextBox.TabIndex = 3;
            // 
            // GasolineComboBox
            // 
            GasolineComboBox.FormattingEnabled = true;
            GasolineComboBox.Location = new Point(71, 30);
            GasolineComboBox.Name = "GasolineComboBox";
            GasolineComboBox.Size = new Size(176, 23);
            GasolineComboBox.TabIndex = 2;
            GasolineComboBox.SelectedIndexChanged += GasolineComboBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 62);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 1;
            label2.Text = "Цена";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 30);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Бензин";
            // 
            // MiniCafeGroupBox
            // 
            MiniCafeGroupBox.Controls.Add(label11);
            MiniCafeGroupBox.Controls.Add(label10);
            MiniCafeGroupBox.Controls.Add(groupBox6);
            MiniCafeGroupBox.Location = new Point(307, 12);
            MiniCafeGroupBox.Name = "MiniCafeGroupBox";
            MiniCafeGroupBox.Size = new Size(253, 293);
            MiniCafeGroupBox.TabIndex = 1;
            MiniCafeGroupBox.TabStop = false;
            MiniCafeGroupBox.Text = "Мини-Кафе";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(175, 19);
            label11.Name = "label11";
            label11.Size = new Size(72, 15);
            label11.TabIndex = 13;
            label11.Text = "Количество";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(130, 19);
            label10.Name = "label10";
            label10.Size = new Size(35, 15);
            label10.TabIndex = 12;
            label10.Text = "Цена";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(label8);
            groupBox6.Controls.Add(MiniCafeTotalLabel);
            groupBox6.Location = new Point(6, 179);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(241, 102);
            groupBox6.TabIndex = 11;
            groupBox6.TabStop = false;
            groupBox6.Text = "К оплате";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(209, 84);
            label8.Name = "label8";
            label8.Size = new Size(26, 15);
            label8.TabIndex = 10;
            label8.Text = "грн";
            // 
            // MiniCafeTotalLabel
            // 
            MiniCafeTotalLabel.AutoSize = true;
            MiniCafeTotalLabel.Font = new Font("Segoe UI Semibold", 48F, FontStyle.Bold, GraphicsUnit.Point, 204);
            MiniCafeTotalLabel.Location = new Point(70, 10);
            MiniCafeTotalLabel.Name = "MiniCafeTotalLabel";
            MiniCafeTotalLabel.Size = new Size(73, 86);
            MiniCafeTotalLabel.TabIndex = 0;
            MiniCafeTotalLabel.Text = "0";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(TotalToPayLabel);
            groupBox3.Controls.Add(pictureBox1);
            groupBox3.Controls.Add(PayButton);
            groupBox3.Location = new Point(12, 311);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(548, 125);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Всего к оплате";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(515, 101);
            label12.Name = "label12";
            label12.Size = new Size(26, 15);
            label12.TabIndex = 12;
            label12.Text = "грн";
            // 
            // TotalToPayLabel
            // 
            TotalToPayLabel.AutoSize = true;
            TotalToPayLabel.Font = new Font("Segoe UI Semibold", 48F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TotalToPayLabel.Location = new Point(345, 28);
            TotalToPayLabel.Name = "TotalToPayLabel";
            TotalToPayLabel.Size = new Size(73, 86);
            TotalToPayLabel.TabIndex = 11;
            TotalToPayLabel.Text = "0";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.nbkkkjij;
            pictureBox1.Location = new Point(6, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // PayButton
            // 
            PayButton.Location = new Point(107, 22);
            PayButton.Name = "PayButton";
            PayButton.Size = new Size(146, 97);
            PayButton.TabIndex = 0;
            PayButton.Text = "Оплатить";
            PayButton.UseVisualStyleBackColor = true;
            PayButton.Click += PayButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 444);
            Controls.Add(groupBox3);
            Controls.Add(MiniCafeGroupBox);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Заправка у Ашота";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            GasolinePayGroupBox.ResumeLayout(false);
            GasolinePayGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AmountNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)CountNumeric).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            MiniCafeGroupBox.ResumeLayout(false);
            MiniCafeGroupBox.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox MiniCafeGroupBox;
        private GroupBox groupBox3;
        private PictureBox pictureBox1;
        private Button PayButton;
        private ComboBox GasolineComboBox;
        private Label label2;
        private Label label1;
        private TextBox PriceTextBox;
        private GroupBox groupBox4;
        private RadioButton AmountRadioButton;
        private RadioButton CountRadioButton;
        private Label label3;
        private GroupBox GasolinePayGroupBox;
        private Label gasStationTotalLabel;
        private Label label5;
        private Label label4;
        private NumericUpDown AmountNumeric;
        private NumericUpDown CountNumeric;
        private Label GasolinePayGroupBoxLabel;
        private GroupBox groupBox6;
        private Label label8;
        private Label MiniCafeTotalLabel;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label TotalToPayLabel;
    }
}
