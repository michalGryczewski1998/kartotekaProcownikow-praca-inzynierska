
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
            this.daneDGW = new System.Windows.Forms.DataGridView();
            this.krajowiPracownicyBTN = new System.Windows.Forms.Button();
            this.zagraniczniPracownicy = new System.Windows.Forms.Button();
            this.panelPracownicy = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelBazyDanych = new System.Windows.Forms.GroupBox();
            this.przybornikGB = new System.Windows.Forms.GroupBox();
            this.infoStatus = new System.Windows.Forms.Label();
            this.wyszukiwanieGB = new System.Windows.Forms.GroupBox();
            this.wyszukajBTN = new System.Windows.Forms.Button();
            this.nazwiskoPracownikaWyszukaj = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.daneDGW)).BeginInit();
            this.panelPracownicy.SuspendLayout();
            this.panelBazyDanych.SuspendLayout();
            this.przybornikGB.SuspendLayout();
            this.wyszukiwanieGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // daneDGW
            // 
            this.daneDGW.AllowUserToAddRows = false;
            this.daneDGW.AllowUserToDeleteRows = false;
            this.daneDGW.BackgroundColor = System.Drawing.SystemColors.Control;
            this.daneDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.daneDGW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.daneDGW.GridColor = System.Drawing.Color.White;
            this.daneDGW.Location = new System.Drawing.Point(3, 19);
            this.daneDGW.Name = "daneDGW";
            this.daneDGW.ReadOnly = true;
            this.daneDGW.RowTemplate.Height = 25;
            this.daneDGW.Size = new System.Drawing.Size(757, 353);
            this.daneDGW.TabIndex = 0;
            this.daneDGW.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.daneDGW_CellContentClick);
            // 
            // krajowiPracownicyBTN
            // 
            this.krajowiPracownicyBTN.Location = new System.Drawing.Point(15, 22);
            this.krajowiPracownicyBTN.Name = "krajowiPracownicyBTN";
            this.krajowiPracownicyBTN.Size = new System.Drawing.Size(142, 35);
            this.krajowiPracownicyBTN.TabIndex = 1;
            this.krajowiPracownicyBTN.Text = "Krajowi Pracownicy";
            this.krajowiPracownicyBTN.UseVisualStyleBackColor = true;
            this.krajowiPracownicyBTN.Click += new System.EventHandler(this.krajowiPracownicyBTN_Click);
            // 
            // zagraniczniPracownicy
            // 
            this.zagraniczniPracownicy.Location = new System.Drawing.Point(14, 63);
            this.zagraniczniPracownicy.Name = "zagraniczniPracownicy";
            this.zagraniczniPracownicy.Size = new System.Drawing.Size(143, 35);
            this.zagraniczniPracownicy.TabIndex = 2;
            this.zagraniczniPracownicy.Text = "Zagraniczni Pracownicy";
            this.zagraniczniPracownicy.UseVisualStyleBackColor = true;
            this.zagraniczniPracownicy.Click += new System.EventHandler(this.ZagraniczniPracownicy_Click);
            // 
            // panelPracownicy
            // 
            this.panelPracownicy.Controls.Add(this.groupBox1);
            this.panelPracownicy.Controls.Add(this.panelBazyDanych);
            this.panelPracownicy.Controls.Add(this.przybornikGB);
            this.panelPracownicy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPracownicy.Location = new System.Drawing.Point(0, 0);
            this.panelPracownicy.Name = "panelPracownicy";
            this.panelPracownicy.Size = new System.Drawing.Size(939, 469);
            this.panelPracownicy.TabIndex = 4;
            this.panelPracownicy.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 437);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(939, 32);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // panelBazyDanych
            // 
            this.panelBazyDanych.Controls.Add(this.daneDGW);
            this.panelBazyDanych.Location = new System.Drawing.Point(173, 12);
            this.panelBazyDanych.Name = "panelBazyDanych";
            this.panelBazyDanych.Size = new System.Drawing.Size(763, 375);
            this.panelBazyDanych.TabIndex = 4;
            this.panelBazyDanych.TabStop = false;
            this.panelBazyDanych.Text = "Panel";
            // 
            // przybornikGB
            // 
            this.przybornikGB.Controls.Add(this.infoStatus);
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
            // infoStatus
            // 
            this.infoStatus.AutoSize = true;
            this.infoStatus.Location = new System.Drawing.Point(15, 206);
            this.infoStatus.Name = "infoStatus";
            this.infoStatus.Size = new System.Drawing.Size(0, 15);
            this.infoStatus.TabIndex = 4;
            // 
            // wyszukiwanieGB
            // 
            this.wyszukiwanieGB.Controls.Add(this.wyszukajBTN);
            this.wyszukiwanieGB.Controls.Add(this.nazwiskoPracownikaWyszukaj);
            this.wyszukiwanieGB.Location = new System.Drawing.Point(8, 104);
            this.wyszukiwanieGB.Name = "wyszukiwanieGB";
            this.wyszukiwanieGB.Size = new System.Drawing.Size(155, 95);
            this.wyszukiwanieGB.TabIndex = 3;
            this.wyszukiwanieGB.TabStop = false;
            this.wyszukiwanieGB.Text = "Wyszukiwanie";
            // 
            // wyszukajBTN
            // 
            this.wyszukajBTN.Location = new System.Drawing.Point(6, 51);
            this.wyszukajBTN.Name = "wyszukajBTN";
            this.wyszukajBTN.Size = new System.Drawing.Size(143, 35);
            this.wyszukajBTN.TabIndex = 3;
            this.wyszukajBTN.Text = "Wyszukaj po Nazwisku";
            this.wyszukajBTN.UseVisualStyleBackColor = true;
            this.wyszukajBTN.Click += new System.EventHandler(this.WyszukajBTN_Click);
            // 
            // nazwiskoPracownikaWyszukaj
            // 
            this.nazwiskoPracownikaWyszukaj.Location = new System.Drawing.Point(7, 22);
            this.nazwiskoPracownikaWyszukaj.Name = "nazwiskoPracownikaWyszukaj";
            this.nazwiskoPracownikaWyszukaj.Size = new System.Drawing.Size(142, 23);
            this.nazwiskoPracownikaWyszukaj.TabIndex = 1;
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 469);
            this.Controls.Add(this.panelPracownicy);
            this.Name = "Employees";
            this.Text = "Pracownicy";
            this.Load += new System.EventHandler(this.Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.daneDGW)).EndInit();
            this.panelPracownicy.ResumeLayout(false);
            this.panelBazyDanych.ResumeLayout(false);
            this.przybornikGB.ResumeLayout(false);
            this.przybornikGB.PerformLayout();
            this.wyszukiwanieGB.ResumeLayout(false);
            this.wyszukiwanieGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView daneDGW;
        private System.Windows.Forms.Button krajowiPracownicyBTN;
        private System.Windows.Forms.Button zagraniczniPracownicy;
        private System.Windows.Forms.Panel panelPracownicy;
        private System.Windows.Forms.GroupBox przybornikGB;
        private System.Windows.Forms.GroupBox panelBazyDanych;
        private System.Windows.Forms.GroupBox wyszukiwanieGB;
        private System.Windows.Forms.TextBox nazwiskoPracownikaWyszukaj;
        private System.Windows.Forms.Button wyszukajBTN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label infoStatus;
    }
}