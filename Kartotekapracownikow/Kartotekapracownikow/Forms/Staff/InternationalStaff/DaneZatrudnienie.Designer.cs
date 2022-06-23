
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.WizaTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TypZezwoleniaInformacjaTB);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(417, 186);
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
            this.TypZezwoleniaInformacjaTB.Size = new System.Drawing.Size(404, 108);
            this.TypZezwoleniaInformacjaTB.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Typ - A",
            "Typ - B",
            "Typ - C",
            "Typ - D",
            "Typ - E",
            "Typ - S"});
            this.comboBox1.Location = new System.Drawing.Point(7, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(404, 23);
            this.comboBox1.TabIndex = 1;
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
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.WizaTB);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(417, 138);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacje o pobycie";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(176, 48);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(235, 23);
            this.textBox6.TabIndex = 22;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 51);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(163, 15);
            this.label17.TabIndex = 21;
            this.label17.Text = "Zezwolenie na bobyt czasowy";
            // 
            // WizaTB
            // 
            this.WizaTB.Location = new System.Drawing.Point(176, 19);
            this.WizaTB.Name = "WizaTB";
            this.WizaTB.Size = new System.Drawing.Size(235, 23);
            this.WizaTB.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Wiza";
            // 
            // DaneZatrudnienie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "DaneZatrudnienie";
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox WizaTB;
        private System.Windows.Forms.Label label7;
    }
}