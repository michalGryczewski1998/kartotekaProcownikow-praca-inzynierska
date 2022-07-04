
namespace Kartotekapracownikow.Forms.Staff.InternationalStaff
{
    partial class DaneZatrudnienie
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TypZezwoleniaInformacjaTB = new System.Windows.Forms.TextBox();
            this.TypZezwoleniaCB = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.DataWygasnieciaKartyPobytuTymczasowegoDTP = new System.Windows.Forms.DateTimePicker();
            this.PobytCzasowyCB = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TypKlasaWizyTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NumerKontrolnyTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NumerWizyTB = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DokumentPobytowyBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TypZezwoleniaInformacjaTB);
            this.groupBox3.Controls.Add(this.TypZezwoleniaCB);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(433, 186);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Typ zezwolenia na pracę w Polsce";
            // 
            // TypZezwoleniaInformacjaTB
            // 
            this.TypZezwoleniaInformacjaTB.Location = new System.Drawing.Point(7, 72);
            this.TypZezwoleniaInformacjaTB.Multiline = true;
            this.TypZezwoleniaInformacjaTB.Name = "TypZezwoleniaInformacjaTB";
            this.TypZezwoleniaInformacjaTB.ReadOnly = true;
            this.TypZezwoleniaInformacjaTB.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TypZezwoleniaInformacjaTB.Size = new System.Drawing.Size(404, 108);
            this.TypZezwoleniaInformacjaTB.TabIndex = 2;
            // 
            // TypZezwoleniaCB
            // 
            this.TypZezwoleniaCB.FormattingEnabled = true;
            this.TypZezwoleniaCB.Items.AddRange(new object[] {
            "Typ - A",
            "Typ - B",
            "Typ - C",
            "Typ - D",
            "Typ - E",
            "Typ - S ( Sezonowa )"});
            this.TypZezwoleniaCB.Location = new System.Drawing.Point(7, 42);
            this.TypZezwoleniaCB.Name = "TypZezwoleniaCB";
            this.TypZezwoleniaCB.Size = new System.Drawing.Size(404, 23);
            this.TypZezwoleniaCB.TabIndex = 1;
            this.TypZezwoleniaCB.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(205, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Zezwolenie na pracę dla cudzoziemca";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.DataWygasnieciaKartyPobytuTymczasowegoDTP);
            this.groupBox2.Controls.Add(this.PobytCzasowyCB);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.TypKlasaWizyTB);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.NumerKontrolnyTB);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.NumerWizyTB);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.DokumentPobytowyBTN);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(433, 375);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacje o pobycie";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 318);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 15);
            this.label12.TabIndex = 43;
            this.label12.Text = "Data wygaśnięcia";
            // 
            // DataWygasnieciaKartyPobytuTymczasowegoDTP
            // 
            this.DataWygasnieciaKartyPobytuTymczasowegoDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataWygasnieciaKartyPobytuTymczasowegoDTP.Location = new System.Drawing.Point(114, 312);
            this.DataWygasnieciaKartyPobytuTymczasowegoDTP.Name = "DataWygasnieciaKartyPobytuTymczasowegoDTP";
            this.DataWygasnieciaKartyPobytuTymczasowegoDTP.Size = new System.Drawing.Size(297, 23);
            this.DataWygasnieciaKartyPobytuTymczasowegoDTP.TabIndex = 42;
            // 
            // PobytCzasowyCB
            // 
            this.PobytCzasowyCB.AutoSize = true;
            this.PobytCzasowyCB.Location = new System.Drawing.Point(7, 287);
            this.PobytCzasowyCB.Name = "PobytCzasowyCB";
            this.PobytCzasowyCB.Size = new System.Drawing.Size(182, 19);
            this.PobytCzasowyCB.TabIndex = 41;
            this.PobytCzasowyCB.Text = "Zezwolenie na pobyt czasowy";
            this.PobytCzasowyCB.UseVisualStyleBackColor = true;
            this.PobytCzasowyCB.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(114, 17);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(297, 23);
            this.textBox3.TabIndex = 40;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 15);
            this.label11.TabIndex = 39;
            this.label11.Text = "Miejsce wydania";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(114, 104);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(297, 23);
            this.textBox2.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 15);
            this.label10.TabIndex = 37;
            this.label10.Text = "Numer paszportu";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(297, 23);
            this.textBox1.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 15);
            this.label9.TabIndex = 35;
            this.label9.Text = "Wpisy";
            // 
            // TypKlasaWizyTB
            // 
            this.TypKlasaWizyTB.Location = new System.Drawing.Point(114, 162);
            this.TypKlasaWizyTB.Name = "TypKlasaWizyTB";
            this.TypKlasaWizyTB.Size = new System.Drawing.Size(297, 23);
            this.TypKlasaWizyTB.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 15);
            this.label6.TabIndex = 33;
            this.label6.Text = "Wiza Typ/Klasa ";
            // 
            // NumerKontrolnyTB
            // 
            this.NumerKontrolnyTB.Location = new System.Drawing.Point(114, 75);
            this.NumerKontrolnyTB.Name = "NumerKontrolnyTB";
            this.NumerKontrolnyTB.Size = new System.Drawing.Size(297, 23);
            this.NumerKontrolnyTB.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 31;
            this.label5.Text = "Numer kontrolny";
            // 
            // NumerWizyTB
            // 
            this.NumerWizyTB.Location = new System.Drawing.Point(114, 46);
            this.NumerWizyTB.Name = "NumerWizyTB";
            this.NumerWizyTB.Size = new System.Drawing.Size(297, 23);
            this.NumerWizyTB.TabIndex = 30;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(114, 220);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(297, 23);
            this.dateTimePicker2.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "Ważność wizy do:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(114, 191);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(297, 23);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "Ważność wizy od:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(5, 281);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.MaximumSize = new System.Drawing.Size(0, 2);
            this.label2.MinimumSize = new System.Drawing.Size(410, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(410, 2);
            this.label2.TabIndex = 25;
            // 
            // DokumentPobytowyBTN
            // 
            this.DokumentPobytowyBTN.Location = new System.Drawing.Point(176, 250);
            this.DokumentPobytowyBTN.Name = "DokumentPobytowyBTN";
            this.DokumentPobytowyBTN.Size = new System.Drawing.Size(235, 28);
            this.DokumentPobytowyBTN.TabIndex = 24;
            this.DokumentPobytowyBTN.Text = "Przeglądaj";
            this.DokumentPobytowyBTN.UseVisualStyleBackColor = true;
            this.DokumentPobytowyBTN.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Skan dokumentu pobytowego";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Numer wizy";
            // 
            // DaneZatrudnienie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 591);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "DaneZatrudnienie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zezwolenie na pracę ";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TypZezwoleniaInformacjaTB;
        private System.Windows.Forms.ComboBox TypZezwoleniaCB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button DokumentPobytowyBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumerWizyTB;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NumerKontrolnyTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker DataWygasnieciaKartyPobytuTymczasowegoDTP;
        private System.Windows.Forms.CheckBox PobytCzasowyCB;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TypKlasaWizyTB;
        private System.Windows.Forms.Label label6;
    }
}