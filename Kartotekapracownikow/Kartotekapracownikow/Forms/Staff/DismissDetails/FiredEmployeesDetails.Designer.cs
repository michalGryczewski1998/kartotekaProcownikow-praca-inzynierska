
namespace Kartotekapracownikow.Forms.Staff.DismissDetails
{
    partial class FiredEmployeesDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.ImieZwalnianegoPracownikaTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PrzyczynaZwolnieniaTB = new System.Windows.Forms.TextBox();
            this.OpisZwolnieniaPanel = new System.Windows.Forms.Panel();
            this.OpisZwolnieniaTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ZwolnijPracownikaBTN = new System.Windows.Forms.Button();
            this.WyczyscBTN = new System.Windows.Forms.Button();
            this.AnulujBTN = new System.Windows.Forms.Button();
            this.PrzyczynaZwolnieniaEP = new System.Windows.Forms.ErrorProvider(this.components);
            this.OpisZwolnieniaEP = new System.Windows.Forms.ErrorProvider(this.components);
            this.OdswiezBTN = new System.Windows.Forms.Button();
            this.OpisZwolnieniaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrzyczynaZwolnieniaEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpisZwolnieniaEP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zwalniany pracownik: ";
            // 
            // ImieZwalnianegoPracownikaTB
            // 
            this.ImieZwalnianegoPracownikaTB.Location = new System.Drawing.Point(149, 13);
            this.ImieZwalnianegoPracownikaTB.Name = "ImieZwalnianegoPracownikaTB";
            this.ImieZwalnianegoPracownikaTB.ReadOnly = true;
            this.ImieZwalnianegoPracownikaTB.Size = new System.Drawing.Size(158, 23);
            this.ImieZwalnianegoPracownikaTB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Przyczyna zwolnienia";
            // 
            // PrzyczynaZwolnieniaTB
            // 
            this.PrzyczynaZwolnieniaTB.Location = new System.Drawing.Point(149, 53);
            this.PrzyczynaZwolnieniaTB.Name = "PrzyczynaZwolnieniaTB";
            this.PrzyczynaZwolnieniaTB.Size = new System.Drawing.Size(158, 23);
            this.PrzyczynaZwolnieniaTB.TabIndex = 3;
            this.PrzyczynaZwolnieniaTB.Validating += new System.ComponentModel.CancelEventHandler(this.PrzyczynaZwolnieniaTB_Validating);
            // 
            // OpisZwolnieniaPanel
            // 
            this.OpisZwolnieniaPanel.Controls.Add(this.OpisZwolnieniaTB);
            this.OpisZwolnieniaPanel.Location = new System.Drawing.Point(13, 126);
            this.OpisZwolnieniaPanel.Name = "OpisZwolnieniaPanel";
            this.OpisZwolnieniaPanel.Size = new System.Drawing.Size(775, 312);
            this.OpisZwolnieniaPanel.TabIndex = 4;
            // 
            // OpisZwolnieniaTB
            // 
            this.OpisZwolnieniaTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpisZwolnieniaTB.Location = new System.Drawing.Point(0, 0);
            this.OpisZwolnieniaTB.Multiline = true;
            this.OpisZwolnieniaTB.Name = "OpisZwolnieniaTB";
            this.OpisZwolnieniaTB.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.OpisZwolnieniaTB.Size = new System.Drawing.Size(775, 312);
            this.OpisZwolnieniaTB.TabIndex = 5;
            this.OpisZwolnieniaTB.Validating += new System.ComponentModel.CancelEventHandler(this.OpisZwolnieniaTB_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Opis zwolnienia";
            // 
            // ZwolnijPracownikaBTN
            // 
            this.ZwolnijPracownikaBTN.Location = new System.Drawing.Point(654, 444);
            this.ZwolnijPracownikaBTN.Name = "ZwolnijPracownikaBTN";
            this.ZwolnijPracownikaBTN.Size = new System.Drawing.Size(133, 39);
            this.ZwolnijPracownikaBTN.TabIndex = 6;
            this.ZwolnijPracownikaBTN.Text = "Zwolnij Pracownika";
            this.ZwolnijPracownikaBTN.UseVisualStyleBackColor = true;
            this.ZwolnijPracownikaBTN.Click += new System.EventHandler(this.ZwolnijPracownikaBTN_Click);
            // 
            // WyczyscBTN
            // 
            this.WyczyscBTN.Location = new System.Drawing.Point(515, 444);
            this.WyczyscBTN.Name = "WyczyscBTN";
            this.WyczyscBTN.Size = new System.Drawing.Size(133, 39);
            this.WyczyscBTN.TabIndex = 7;
            this.WyczyscBTN.Text = "Wyczyść";
            this.WyczyscBTN.UseVisualStyleBackColor = true;
            this.WyczyscBTN.Click += new System.EventHandler(this.button2_Click);
            // 
            // AnulujBTN
            // 
            this.AnulujBTN.Location = new System.Drawing.Point(13, 444);
            this.AnulujBTN.Name = "AnulujBTN";
            this.AnulujBTN.Size = new System.Drawing.Size(133, 39);
            this.AnulujBTN.TabIndex = 8;
            this.AnulujBTN.Text = "Anuluj";
            this.AnulujBTN.UseVisualStyleBackColor = true;
            this.AnulujBTN.Click += new System.EventHandler(this.button3_Click);
            // 
            // PrzyczynaZwolnieniaEP
            // 
            this.PrzyczynaZwolnieniaEP.ContainerControl = this;
            // 
            // OpisZwolnieniaEP
            // 
            this.OpisZwolnieniaEP.ContainerControl = this;
            // 
            // OdswiezBTN
            // 
            this.OdswiezBTN.Location = new System.Drawing.Point(440, 444);
            this.OdswiezBTN.Name = "OdswiezBTN";
            this.OdswiezBTN.Size = new System.Drawing.Size(69, 39);
            this.OdswiezBTN.TabIndex = 9;
            this.OdswiezBTN.Text = "Odśwież";
            this.OdswiezBTN.UseVisualStyleBackColor = true;
            this.OdswiezBTN.Click += new System.EventHandler(this.button4_Click);
            // 
            // FiredEmployeesDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.OdswiezBTN);
            this.Controls.Add(this.AnulujBTN);
            this.Controls.Add(this.WyczyscBTN);
            this.Controls.Add(this.ZwolnijPracownikaBTN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OpisZwolnieniaPanel);
            this.Controls.Add(this.PrzyczynaZwolnieniaTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ImieZwalnianegoPracownikaTB);
            this.Controls.Add(this.label1);
            this.Name = "FiredEmployeesDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Szczegóły zwolnienia";
            this.Load += new System.EventHandler(this.FiredEmployeesDetails_Load);
            this.OpisZwolnieniaPanel.ResumeLayout(false);
            this.OpisZwolnieniaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrzyczynaZwolnieniaEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpisZwolnieniaEP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ImieZwalnianegoPracownikaTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PrzyczynaZwolnieniaTB;
        private System.Windows.Forms.Panel OpisZwolnieniaPanel;
        private System.Windows.Forms.TextBox OpisZwolnieniaTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ZwolnijPracownikaBTN;
        private System.Windows.Forms.Button WyczyscBTN;
        private System.Windows.Forms.Button AnulujBTN;
        private System.Windows.Forms.ErrorProvider PrzyczynaZwolnieniaEP;
        private System.Windows.Forms.ErrorProvider OpisZwolnieniaEP;
        private System.Windows.Forms.Button OdswiezBTN;
    }
}