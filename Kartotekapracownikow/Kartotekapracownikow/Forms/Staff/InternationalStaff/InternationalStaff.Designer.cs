
namespace Kartotekapracownikow.Forms.InternationalStaff
{
    partial class InternationalStaff
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
            this.zagraniczniPracownicyGB = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // zagraniczniPracownicyGB
            // 
            this.zagraniczniPracownicyGB.Location = new System.Drawing.Point(13, 13);
            this.zagraniczniPracownicyGB.Name = "zagraniczniPracownicyGB";
            this.zagraniczniPracownicyGB.Size = new System.Drawing.Size(775, 312);
            this.zagraniczniPracownicyGB.TabIndex = 0;
            this.zagraniczniPracownicyGB.TabStop = false;
            this.zagraniczniPracownicyGB.Text = "Pracownicy Zagraniczni";
            // 
            // InternationalStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.zagraniczniPracownicyGB);
            this.Name = "InternationalStaff";
            this.Text = "InternationalStaff";
            this.Load += new System.EventHandler(this.InternationalStaff_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox zagraniczniPracownicyGB;
    }
}