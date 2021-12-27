
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
            this.button1 = new System.Windows.Forms.Button();
            this.zwolnijPracownikaGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // zwolnijPracownikaGB
            // 
            this.zwolnijPracownikaGB.Controls.Add(this.button1);
            this.zwolnijPracownikaGB.Location = new System.Drawing.Point(13, 13);
            this.zwolnijPracownikaGB.Name = "zwolnijPracownikaGB";
            this.zwolnijPracownikaGB.Size = new System.Drawing.Size(775, 298);
            this.zwolnijPracownikaGB.TabIndex = 0;
            this.zwolnijPracownikaGB.TabStop = false;
            this.zwolnijPracownikaGB.Text = "Zwolnienia pracowników";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(694, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Zwolnij";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DismissEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.zwolnijPracownikaGB);
            this.Name = "DismissEmployee";
            this.Text = "DismissEmployee";
            this.Load += new System.EventHandler(this.DismissEmployee_Load);
            this.zwolnijPracownikaGB.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox zwolnijPracownikaGB;
        private System.Windows.Forms.Button button1;
    }
}