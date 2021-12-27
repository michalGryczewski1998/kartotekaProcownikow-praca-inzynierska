
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
            this.pracownicyGB = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // pracownicyGB
            // 
            this.pracownicyGB.Location = new System.Drawing.Point(12, 12);
            this.pracownicyGB.Name = "pracownicyGB";
            this.pracownicyGB.Size = new System.Drawing.Size(776, 308);
            this.pracownicyGB.TabIndex = 0;
            this.pracownicyGB.TabStop = false;
            this.pracownicyGB.Text = "Pracownicy";
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pracownicyGB);
            this.Name = "Employees";
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Employees_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox pracownicyGB;
    }
}