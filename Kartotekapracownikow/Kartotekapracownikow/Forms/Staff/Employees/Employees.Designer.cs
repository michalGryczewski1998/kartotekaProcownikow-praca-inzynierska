﻿
namespace Kartotekapracownikow.Forms.Employees
{
    partial class Employees
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.krajowiPracownicyBTN = new System.Windows.Forms.Button();
            this.zagraniczniPracownicy = new System.Windows.Forms.Button();
            this.panelPracownicy = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelBazyDanych = new System.Windows.Forms.GroupBox();
            this.przybornikGB = new System.Windows.Forms.GroupBox();
            this.wyszukiwanieGB = new System.Windows.Forms.GroupBox();
            this.nazwiskoPracownikaWyszukaj = new System.Windows.Forms.TextBox();
            this.imiePracownikaWyszukaj = new System.Windows.Forms.TextBox();
            this.wyszukajBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panelPracownicy.SuspendLayout();
            this.panelBazyDanych.SuspendLayout();
            this.przybornikGB.SuspendLayout();
            this.wyszukiwanieGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.GridColor = System.Drawing.Color.White;
            this.dataGridView.Location = new System.Drawing.Point(3, 19);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(609, 356);
            this.dataGridView.TabIndex = 0;
            // 
            // krajowiPracownicyBTN
            // 
            this.krajowiPracownicyBTN.Location = new System.Drawing.Point(8, 22);
            this.krajowiPracownicyBTN.Name = "krajowiPracownicyBTN";
            this.krajowiPracownicyBTN.Size = new System.Drawing.Size(149, 35);
            this.krajowiPracownicyBTN.TabIndex = 1;
            this.krajowiPracownicyBTN.Text = "Krajowi Pracownicy";
            this.krajowiPracownicyBTN.UseVisualStyleBackColor = true;
            this.krajowiPracownicyBTN.Click += new System.EventHandler(this.krajowiPracownicyBTN_Click);
            // 
            // zagraniczniPracownicy
            // 
            this.zagraniczniPracownicy.Location = new System.Drawing.Point(8, 63);
            this.zagraniczniPracownicy.Name = "zagraniczniPracownicy";
            this.zagraniczniPracownicy.Size = new System.Drawing.Size(149, 35);
            this.zagraniczniPracownicy.TabIndex = 2;
            this.zagraniczniPracownicy.Text = "Zagraniczni Pracownicy";
            this.zagraniczniPracownicy.UseVisualStyleBackColor = true;
            // 
            // panelPracownicy
            // 
            this.panelPracownicy.Controls.Add(this.groupBox1);
            this.panelPracownicy.Controls.Add(this.panelBazyDanych);
            this.panelPracownicy.Controls.Add(this.przybornikGB);
            this.panelPracownicy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPracownicy.Location = new System.Drawing.Point(0, 0);
            this.panelPracownicy.Name = "panelPracownicy";
            this.panelPracownicy.Size = new System.Drawing.Size(800, 450);
            this.panelPracownicy.TabIndex = 4;
            this.panelPracownicy.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 393);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 57);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // panelBazyDanych
            // 
            this.panelBazyDanych.Controls.Add(this.dataGridView);
            this.panelBazyDanych.Location = new System.Drawing.Point(173, 12);
            this.panelBazyDanych.Name = "panelBazyDanych";
            this.panelBazyDanych.Size = new System.Drawing.Size(615, 378);
            this.panelBazyDanych.TabIndex = 4;
            this.panelBazyDanych.TabStop = false;
            this.panelBazyDanych.Text = "Panel";
            // 
            // przybornikGB
            // 
            this.przybornikGB.Controls.Add(this.wyszukiwanieGB);
            this.przybornikGB.Controls.Add(this.krajowiPracownicyBTN);
            this.przybornikGB.Controls.Add(this.zagraniczniPracownicy);
            this.przybornikGB.Location = new System.Drawing.Point(4, 12);
            this.przybornikGB.Name = "przybornikGB";
            this.przybornikGB.Size = new System.Drawing.Size(163, 375);
            this.przybornikGB.TabIndex = 3;
            this.przybornikGB.TabStop = false;
            this.przybornikGB.Text = "Przybornik";
            // 
            // wyszukiwanieGB
            // 
            this.wyszukiwanieGB.Controls.Add(this.wyszukajBTN);
            this.wyszukiwanieGB.Controls.Add(this.nazwiskoPracownikaWyszukaj);
            this.wyszukiwanieGB.Controls.Add(this.imiePracownikaWyszukaj);
            this.wyszukiwanieGB.Location = new System.Drawing.Point(8, 104);
            this.wyszukiwanieGB.Name = "wyszukiwanieGB";
            this.wyszukiwanieGB.Size = new System.Drawing.Size(155, 265);
            this.wyszukiwanieGB.TabIndex = 3;
            this.wyszukiwanieGB.TabStop = false;
            this.wyszukiwanieGB.Text = "Wyszukiwanie";
            // 
            // nazwiskoPracownikaWyszukaj
            // 
            this.nazwiskoPracownikaWyszukaj.Location = new System.Drawing.Point(7, 52);
            this.nazwiskoPracownikaWyszukaj.Name = "nazwiskoPracownikaWyszukaj";
            this.nazwiskoPracownikaWyszukaj.Size = new System.Drawing.Size(142, 23);
            this.nazwiskoPracownikaWyszukaj.TabIndex = 1;
            this.nazwiskoPracownikaWyszukaj.Text = "Nazwisko";
            // 
            // imiePracownikaWyszukaj
            // 
            this.imiePracownikaWyszukaj.Location = new System.Drawing.Point(7, 23);
            this.imiePracownikaWyszukaj.Name = "imiePracownikaWyszukaj";
            this.imiePracownikaWyszukaj.Size = new System.Drawing.Size(142, 23);
            this.imiePracownikaWyszukaj.TabIndex = 0;
            this.imiePracownikaWyszukaj.Text = "Imię";
            // 
            // wyszukajBTN
            // 
            this.wyszukajBTN.Location = new System.Drawing.Point(0, 81);
            this.wyszukajBTN.Name = "wyszukajBTN";
            this.wyszukajBTN.Size = new System.Drawing.Size(149, 35);
            this.wyszukajBTN.TabIndex = 3;
            this.wyszukajBTN.Text = "Wyszukaj Pracownika";
            this.wyszukajBTN.UseVisualStyleBackColor = true;
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelPracownicy);
            this.Name = "Employees";
            this.Text = "Pracownicy";
            this.Load += new System.EventHandler(this.Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panelPracownicy.ResumeLayout(false);
            this.panelBazyDanych.ResumeLayout(false);
            this.przybornikGB.ResumeLayout(false);
            this.wyszukiwanieGB.ResumeLayout(false);
            this.wyszukiwanieGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button krajowiPracownicyBTN;
        private System.Windows.Forms.Button zagraniczniPracownicy;
        private System.Windows.Forms.Panel panelPracownicy;
        private System.Windows.Forms.GroupBox przybornikGB;
        private System.Windows.Forms.GroupBox panelBazyDanych;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox wyszukiwanieGB;
        private System.Windows.Forms.TextBox nazwiskoPracownikaWyszukaj;
        private System.Windows.Forms.TextBox imiePracownikaWyszukaj;
        private System.Windows.Forms.Button wyszukajBTN;
    }
}