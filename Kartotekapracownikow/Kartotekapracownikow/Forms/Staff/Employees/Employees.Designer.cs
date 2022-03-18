
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
            this.przybornikGB = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panelPracownicy.SuspendLayout();
            this.przybornikGB.SuspendLayout();
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
            this.dataGridView.Location = new System.Drawing.Point(173, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(627, 450);
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
            this.panelPracownicy.Controls.Add(this.przybornikGB);
            this.panelPracownicy.Controls.Add(this.dataGridView);
            this.panelPracownicy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPracownicy.Location = new System.Drawing.Point(0, 0);
            this.panelPracownicy.Name = "panelPracownicy";
            this.panelPracownicy.Size = new System.Drawing.Size(800, 450);
            this.panelPracownicy.TabIndex = 4;
            this.panelPracownicy.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // przybornikGB
            // 
            this.przybornikGB.Controls.Add(this.krajowiPracownicyBTN);
            this.przybornikGB.Controls.Add(this.zagraniczniPracownicy);
            this.przybornikGB.Location = new System.Drawing.Point(4, 12);
            this.przybornikGB.Name = "przybornikGB";
            this.przybornikGB.Size = new System.Drawing.Size(163, 222);
            this.przybornikGB.TabIndex = 3;
            this.przybornikGB.TabStop = false;
            this.przybornikGB.Text = "Przybornik";
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
            this.przybornikGB.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button krajowiPracownicyBTN;
        private System.Windows.Forms.Button zagraniczniPracownicy;
        private System.Windows.Forms.Panel panelPracownicy;
        private System.Windows.Forms.GroupBox przybornikGB;
    }
}