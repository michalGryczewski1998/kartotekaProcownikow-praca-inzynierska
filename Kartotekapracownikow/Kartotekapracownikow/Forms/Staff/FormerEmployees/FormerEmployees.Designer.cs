﻿
namespace Kartotekapracownikow.Forms.Staff.FormerEmployees
{
    partial class FormerEmployees
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
            this.dawniPracownicyGB = new System.Windows.Forms.GroupBox();
            this.OdswiezBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.zaznaczonyPracownikLabel = new System.Windows.Forms.Label();
            this.DaneZwolnienieDGW = new System.Windows.Forms.DataGridView();
            this.dawniPracownicyGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DaneZwolnienieDGW)).BeginInit();
            this.SuspendLayout();
            // 
            // dawniPracownicyGB
            // 
            this.dawniPracownicyGB.Controls.Add(this.DaneZwolnienieDGW);
            this.dawniPracownicyGB.Location = new System.Drawing.Point(12, 12);
            this.dawniPracownicyGB.Name = "dawniPracownicyGB";
            this.dawniPracownicyGB.Size = new System.Drawing.Size(936, 367);
            this.dawniPracownicyGB.TabIndex = 0;
            this.dawniPracownicyGB.TabStop = false;
            this.dawniPracownicyGB.Text = "Byli Pracownicy";
            // 
            // OdswiezBTN
            // 
            this.OdswiezBTN.Location = new System.Drawing.Point(870, 382);
            this.OdswiezBTN.Name = "OdswiezBTN";
            this.OdswiezBTN.Size = new System.Drawing.Size(75, 23);
            this.OdswiezBTN.TabIndex = 1;
            this.OdswiezBTN.Text = "Odśwież";
            this.OdswiezBTN.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pracownik: ";
            // 
            // zaznaczonyPracownikLabel
            // 
            this.zaznaczonyPracownikLabel.AutoSize = true;
            this.zaznaczonyPracownikLabel.Location = new System.Drawing.Point(80, 390);
            this.zaznaczonyPracownikLabel.Name = "zaznaczonyPracownikLabel";
            this.zaznaczonyPracownikLabel.Size = new System.Drawing.Size(0, 15);
            this.zaznaczonyPracownikLabel.TabIndex = 3;
            // 
            // DaneZwolnienieDGW
            // 
            this.DaneZwolnienieDGW.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.DaneZwolnienieDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DaneZwolnienieDGW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DaneZwolnienieDGW.Location = new System.Drawing.Point(3, 19);
            this.DaneZwolnienieDGW.Name = "DaneZwolnienieDGW";
            this.DaneZwolnienieDGW.RowTemplate.Height = 25;
            this.DaneZwolnienieDGW.Size = new System.Drawing.Size(930, 345);
            this.DaneZwolnienieDGW.TabIndex = 0;
            this.DaneZwolnienieDGW.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DaneZwolnienieDGW_CellContentClick);
            // 
            // FormerEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 450);
            this.Controls.Add(this.zaznaczonyPracownikLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OdswiezBTN);
            this.Controls.Add(this.dawniPracownicyGB);
            this.Name = "FormerEmployees";
            this.Text = "FormerEmployees";
            this.Load += new System.EventHandler(this.FormerEmployees_Load);
            this.dawniPracownicyGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DaneZwolnienieDGW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox dawniPracownicyGB;
        private System.Windows.Forms.Button OdswiezBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label zaznaczonyPracownikLabel;
        private System.Windows.Forms.DataGridView DaneZwolnienieDGW;
    }
}