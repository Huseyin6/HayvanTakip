namespace HayvanTakip.Forms
{
    partial class IslemEkrani
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gelirbutton = new System.Windows.Forms.Button();
            this.giderButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.islemPaneli = new System.Windows.Forms.Panel();
            this.iptalButton = new System.Windows.Forms.Button();
            this.onayButton = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.aciklamaBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.islemSecimPaneli = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.islemPaneli.SuspendLayout();
            this.islemSecimPaneli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gelirbutton
            // 
            this.gelirbutton.BackColor = System.Drawing.Color.Aqua;
            this.gelirbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gelirbutton.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gelirbutton.Location = new System.Drawing.Point(111, 26);
            this.gelirbutton.Name = "gelirbutton";
            this.gelirbutton.Size = new System.Drawing.Size(82, 42);
            this.gelirbutton.TabIndex = 0;
            this.gelirbutton.Text = "Gelir";
            this.gelirbutton.UseVisualStyleBackColor = false;
            this.gelirbutton.Click += new System.EventHandler(this.gelirbutton_Click);
            // 
            // giderButton
            // 
            this.giderButton.BackColor = System.Drawing.Color.Red;
            this.giderButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.giderButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giderButton.Location = new System.Drawing.Point(199, 26);
            this.giderButton.Name = "giderButton";
            this.giderButton.Size = new System.Drawing.Size(82, 42);
            this.giderButton.TabIndex = 1;
            this.giderButton.Text = "Gider";
            this.giderButton.UseVisualStyleBackColor = false;
            this.giderButton.Click += new System.EventHandler(this.giderButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(86, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lütfen İşlem Türünü Seçiniz ";
            // 
            // islemPaneli
            // 
            this.islemPaneli.Controls.Add(this.iptalButton);
            this.islemPaneli.Controls.Add(this.onayButton);
            this.islemPaneli.Controls.Add(this.maskedTextBox1);
            this.islemPaneli.Controls.Add(this.aciklamaBox);
            this.islemPaneli.Controls.Add(this.comboBox1);
            this.islemPaneli.Controls.Add(this.dateTimePicker1);
            this.islemPaneli.Controls.Add(this.label5);
            this.islemPaneli.Controls.Add(this.label4);
            this.islemPaneli.Controls.Add(this.label3);
            this.islemPaneli.Controls.Add(this.label2);
            this.islemPaneli.Location = new System.Drawing.Point(9, 12);
            this.islemPaneli.Name = "islemPaneli";
            this.islemPaneli.Size = new System.Drawing.Size(388, 108);
            this.islemPaneli.TabIndex = 3;
            // 
            // iptalButton
            // 
            this.iptalButton.BackColor = System.Drawing.Color.Tomato;
            this.iptalButton.Location = new System.Drawing.Point(298, 48);
            this.iptalButton.Name = "iptalButton";
            this.iptalButton.Size = new System.Drawing.Size(75, 35);
            this.iptalButton.TabIndex = 9;
            this.iptalButton.Text = "İptal";
            this.iptalButton.UseVisualStyleBackColor = false;
            this.iptalButton.Click += new System.EventHandler(this.iptalButton_Click);
            // 
            // onayButton
            // 
            this.onayButton.BackColor = System.Drawing.Color.SpringGreen;
            this.onayButton.Location = new System.Drawing.Point(189, 48);
            this.onayButton.Name = "onayButton";
            this.onayButton.Size = new System.Drawing.Size(75, 35);
            this.onayButton.TabIndex = 8;
            this.onayButton.Text = "Ekle";
            this.onayButton.UseVisualStyleBackColor = false;
            this.onayButton.Click += new System.EventHandler(this.onayButton_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(63, 78);
            this.maskedTextBox1.Mask = "00000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(79, 20);
            this.maskedTextBox1.TabIndex = 7;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // aciklamaBox
            // 
            this.aciklamaBox.Location = new System.Drawing.Point(226, 10);
            this.aciklamaBox.Name = "aciklamaBox";
            this.aciklamaBox.Size = new System.Drawing.Size(147, 20);
            this.aciklamaBox.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(63, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(79, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(63, 10);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(79, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Indigo;
            this.label5.Location = new System.Drawing.Point(17, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tutar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(156, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Açıklama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(17, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "İşlem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(18, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tarih";
            // 
            // islemSecimPaneli
            // 
            this.islemSecimPaneli.Controls.Add(this.label1);
            this.islemSecimPaneli.Controls.Add(this.gelirbutton);
            this.islemSecimPaneli.Controls.Add(this.giderButton);
            this.islemSecimPaneli.Location = new System.Drawing.Point(12, 2);
            this.islemSecimPaneli.Name = "islemSecimPaneli";
            this.islemSecimPaneli.Size = new System.Drawing.Size(362, 76);
            this.islemSecimPaneli.TabIndex = 4;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // IslemEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 126);
            this.Controls.Add(this.islemSecimPaneli);
            this.Controls.Add(this.islemPaneli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "IslemEkrani";
            this.Text = "IslemEkrani";
            this.islemPaneli.ResumeLayout(false);
            this.islemPaneli.PerformLayout();
            this.islemSecimPaneli.ResumeLayout(false);
            this.islemSecimPaneli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gelirbutton;
        private System.Windows.Forms.Button giderButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel islemPaneli;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button iptalButton;
        public System.Windows.Forms.Button onayButton;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox aciklamaBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel islemSecimPaneli;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}