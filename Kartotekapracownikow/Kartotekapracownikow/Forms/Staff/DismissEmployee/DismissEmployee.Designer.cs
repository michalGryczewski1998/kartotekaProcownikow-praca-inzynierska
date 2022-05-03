
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
            this.daneDGW = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.zwolnijPracownikaGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.daneDGW)).BeginInit();
            this.SuspendLayout();
            // 
            // zwolnijPracownikaGB
            // 
            this.zwolnijPracownikaGB.Controls.Add(this.daneDGW);
            this.zwolnijPracownikaGB.Controls.Add(this.button1);
            this.zwolnijPracownikaGB.Location = new System.Drawing.Point(13, 13);
            this.zwolnijPracownikaGB.Name = "zwolnijPracownikaGB";
            this.zwolnijPracownikaGB.Size = new System.Drawing.Size(936, 367);
            this.zwolnijPracownikaGB.TabIndex = 0;
            this.zwolnijPracownikaGB.TabStop = false;
            this.zwolnijPracownikaGB.Text = "Zwolnienia pracowników";
            // 
            // daneDGW
            // 
            this.daneDGW.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.daneDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.daneDGW.Location = new System.Drawing.Point(6, 22);
            this.daneDGW.Name = "daneDGW";
            this.daneDGW.RowTemplate.Height = 25;
            this.daneDGW.Size = new System.Drawing.Size(922, 284);
            this.daneDGW.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(853, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Zwolnij";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DismissEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 450);
            this.Controls.Add(this.zwolnijPracownikaGB);
            this.Name = "DismissEmployee";
            this.Text = "DismissEmployee";
            this.Load += new System.EventHandler(this.DismissEmployee_Load);
            this.zwolnijPracownikaGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.daneDGW)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox zwolnijPracownikaGB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView daneDGW;
    }
}