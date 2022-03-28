
namespace Kartotekapracownikow.Forms.Staff.EmployessInfo
{
    partial class EmployessInfo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.edytujBTN = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.edytujZatrudnienieBTN = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.edytujBTN);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 203);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dane Podstawowe";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 175);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // edytujBTN
            // 
            this.edytujBTN.Location = new System.Drawing.Point(694, 174);
            this.edytujBTN.Name = "edytujBTN";
            this.edytujBTN.Size = new System.Drawing.Size(75, 23);
            this.edytujBTN.TabIndex = 0;
            this.edytujBTN.Text = "Edytuj";
            this.edytujBTN.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.edytujZatrudnienieBTN);
            this.groupBox2.Location = new System.Drawing.Point(13, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(775, 216);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dane o Zatrudnieniu";
            // 
            // edytujZatrudnienieBTN
            // 
            this.edytujZatrudnienieBTN.Location = new System.Drawing.Point(694, 187);
            this.edytujZatrudnienieBTN.Name = "edytujZatrudnienieBTN";
            this.edytujZatrudnienieBTN.Size = new System.Drawing.Size(75, 23);
            this.edytujZatrudnienieBTN.TabIndex = 1;
            this.edytujZatrudnienieBTN.Text = "Edytuj";
            this.edytujZatrudnienieBTN.UseVisualStyleBackColor = true;
            // 
            // EmployessInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "EmployessInfo";
            this.Text = "Informacje o Pracowniku";
            this.Load += new System.EventHandler(this.EmployessInfo_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button edytujBTN;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button edytujZatrudnienieBTN;
    }
}