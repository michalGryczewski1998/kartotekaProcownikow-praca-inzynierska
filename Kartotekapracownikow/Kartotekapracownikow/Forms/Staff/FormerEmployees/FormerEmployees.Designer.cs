
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
            this.SuspendLayout();
            // 
            // dawniPracownicyGB
            // 
            this.dawniPracownicyGB.Location = new System.Drawing.Point(12, 12);
            this.dawniPracownicyGB.Name = "dawniPracownicyGB";
            this.dawniPracownicyGB.Size = new System.Drawing.Size(776, 283);
            this.dawniPracownicyGB.TabIndex = 0;
            this.dawniPracownicyGB.TabStop = false;
            this.dawniPracownicyGB.Text = "Byli Pracownicy";
            // 
            // FormerEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dawniPracownicyGB);
            this.Name = "FormerEmployees";
            this.Text = "FormerEmployees";
            this.Load += new System.EventHandler(this.FormerEmployees_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox dawniPracownicyGB;
    }
}