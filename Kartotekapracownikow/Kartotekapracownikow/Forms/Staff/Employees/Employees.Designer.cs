
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
            this.wszyscyPracownicyBTN = new System.Windows.Forms.Button();
            this.zagraniczniPracownicy = new System.Windows.Forms.Button();
            this.szukajBTN = new System.Windows.Forms.Button();
            this.panelPracownicy = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panelPracownicy.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView.GridColor = System.Drawing.Color.White;
            this.dataGridView.Location = new System.Drawing.Point(287, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(513, 450);
            this.dataGridView.TabIndex = 0;
            // 
            // wszyscyPracownicyBTN
            // 
            this.wszyscyPracownicyBTN.Location = new System.Drawing.Point(3, 392);
            this.wszyscyPracownicyBTN.Name = "wszyscyPracownicyBTN";
            this.wszyscyPracownicyBTN.Size = new System.Drawing.Size(79, 55);
            this.wszyscyPracownicyBTN.TabIndex = 1;
            this.wszyscyPracownicyBTN.Text = "Wszyscy Pracownicy";
            this.wszyscyPracownicyBTN.UseVisualStyleBackColor = true;
            // 
            // zagraniczniPracownicy
            // 
            this.zagraniczniPracownicy.Location = new System.Drawing.Point(88, 392);
            this.zagraniczniPracownicy.Name = "zagraniczniPracownicy";
            this.zagraniczniPracownicy.Size = new System.Drawing.Size(79, 55);
            this.zagraniczniPracownicy.TabIndex = 2;
            this.zagraniczniPracownicy.Text = "Zagraniczni Pracownicy";
            this.zagraniczniPracownicy.UseVisualStyleBackColor = true;
            // 
            // szukajBTN
            // 
            this.szukajBTN.BackColor = System.Drawing.SystemColors.Control;
            this.szukajBTN.Location = new System.Drawing.Point(202, 392);
            this.szukajBTN.Name = "szukajBTN";
            this.szukajBTN.Size = new System.Drawing.Size(79, 55);
            this.szukajBTN.TabIndex = 3;
            this.szukajBTN.Text = "Szukaj";
            this.szukajBTN.UseVisualStyleBackColor = false;
            this.szukajBTN.Click += new System.EventHandler(this.szukajBTN_Click);
            // 
            // panelPracownicy
            // 
            this.panelPracownicy.Controls.Add(this.wszyscyPracownicyBTN);
            this.panelPracownicy.Controls.Add(this.dataGridView);
            this.panelPracownicy.Controls.Add(this.szukajBTN);
            this.panelPracownicy.Controls.Add(this.zagraniczniPracownicy);
            this.panelPracownicy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPracownicy.Location = new System.Drawing.Point(0, 0);
            this.panelPracownicy.Name = "panelPracownicy";
            this.panelPracownicy.Size = new System.Drawing.Size(800, 450);
            this.panelPracownicy.TabIndex = 4;
            this.panelPracownicy.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button wszyscyPracownicyBTN;
        private System.Windows.Forms.Button zagraniczniPracownicy;
        private System.Windows.Forms.Button szukajBTN;
        private System.Windows.Forms.Panel panelPracownicy;
    }
}