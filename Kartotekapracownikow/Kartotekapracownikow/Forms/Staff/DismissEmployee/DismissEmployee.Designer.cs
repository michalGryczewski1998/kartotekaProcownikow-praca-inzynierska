
namespace Kartotekapracownikow.Forms.Staff.DismissEmployee
{
    partial class DismissEmployee
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
            this.zwolnijPracownikaGB = new System.Windows.Forms.GroupBox();
            this.PracownicyZagraniczniSzukajBTN = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.zaznaczonyPracownikLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.daneDGW = new System.Windows.Forms.DataGridView();
            this.zwolnijPracownikaGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.daneDGW)).BeginInit();
            this.SuspendLayout();
            // 
            // zwolnijPracownikaGB
            // 
            this.zwolnijPracownikaGB.Controls.Add(this.PracownicyZagraniczniSzukajBTN);
            this.zwolnijPracownikaGB.Controls.Add(this.button2);
            this.zwolnijPracownikaGB.Controls.Add(this.zaznaczonyPracownikLabel);
            this.zwolnijPracownikaGB.Controls.Add(this.label2);
            this.zwolnijPracownikaGB.Controls.Add(this.label1);
            this.zwolnijPracownikaGB.Controls.Add(this.daneDGW);
            this.zwolnijPracownikaGB.Location = new System.Drawing.Point(13, 13);
            this.zwolnijPracownikaGB.Name = "zwolnijPracownikaGB";
            this.zwolnijPracownikaGB.Size = new System.Drawing.Size(936, 367);
            this.zwolnijPracownikaGB.TabIndex = 0;
            this.zwolnijPracownikaGB.TabStop = false;
            this.zwolnijPracownikaGB.Text = "Zwolnienia pracowników";
            // 
            // PracownicyZagraniczniSzukajBTN
            // 
            this.PracownicyZagraniczniSzukajBTN.Location = new System.Drawing.Point(752, 338);
            this.PracownicyZagraniczniSzukajBTN.Name = "PracownicyZagraniczniSzukajBTN";
            this.PracownicyZagraniczniSzukajBTN.Size = new System.Drawing.Size(176, 23);
            this.PracownicyZagraniczniSzukajBTN.TabIndex = 6;
            this.PracownicyZagraniczniSzukajBTN.Text = "Pracownicy z zagranicy";
            this.PracownicyZagraniczniSzukajBTN.UseVisualStyleBackColor = true;
            this.PracownicyZagraniczniSzukajBTN.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(672, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Odśwież";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // zaznaczonyPracownikLabel
            // 
            this.zaznaczonyPracownikLabel.AutoSize = true;
            this.zaznaczonyPracownikLabel.Location = new System.Drawing.Point(147, 313);
            this.zaznaczonyPracownikLabel.Name = "zaznaczonyPracownikLabel";
            this.zaznaczonyPracownikLabel.Size = new System.Drawing.Size(0, 15);
            this.zaznaczonyPracownikLabel.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Zaznaczony pracownik: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(666, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 2;
            // 
            // daneDGW
            // 
            this.daneDGW.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.daneDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.daneDGW.Location = new System.Drawing.Point(6, 22);
            this.daneDGW.Name = "daneDGW";
            this.daneDGW.RowTemplate.Height = 25;
            this.daneDGW.Size = new System.Drawing.Size(922, 284);
            this.daneDGW.TabIndex = 1;
            this.daneDGW.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DaneDGW_CellContentClick);
            // 
            // DismissEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 450);
            this.Controls.Add(this.zwolnijPracownikaGB);
            this.Name = "DismissEmployee";
            this.Text = "DismissEmployee";
            this.Load += new System.EventHandler(this.DismissEmployee_Load);
            this.zwolnijPracownikaGB.ResumeLayout(false);
            this.zwolnijPracownikaGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.daneDGW)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox zwolnijPracownikaGB;
        private System.Windows.Forms.DataGridView daneDGW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label zaznaczonyPracownikLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button PracownicyZagraniczniSzukajBTN;
    }
}