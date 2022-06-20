
namespace Kartotekapracownikow.Forms.Email
{
    partial class EmailMessage
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.AdresOdbiorcyTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TrescTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.EmailOdbiorcaEP = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.TematTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.EmailOdbiorcaEP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Do:";
            // 
            // AdresOdbiorcyTB
            // 
            this.AdresOdbiorcyTB.Location = new System.Drawing.Point(84, 13);
            this.AdresOdbiorcyTB.Name = "AdresOdbiorcyTB";
            this.AdresOdbiorcyTB.Size = new System.Drawing.Size(483, 23);
            this.AdresOdbiorcyTB.TabIndex = 1;
            this.AdresOdbiorcyTB.Validating += new System.ComponentModel.CancelEventHandler(this.AdresOdbiorcyTB_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Załącznik:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Treść wiadomości:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(84, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(483, 23);
            this.textBox2.TabIndex = 4;
            // 
            // TrescTB
            // 
            this.TrescTB.Location = new System.Drawing.Point(12, 141);
            this.TrescTB.Multiline = true;
            this.TrescTB.Name = "TrescTB";
            this.TrescTB.Size = new System.Drawing.Size(555, 349);
            this.TrescTB.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(414, 497);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 51);
            this.button1.TabIndex = 6;
            this.button1.Text = "Wyślij";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(255, 497);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 51);
            this.button2.TabIndex = 7;
            this.button2.Text = "Dodaj załącznik";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EmailOdbiorcaEP
            // 
            this.EmailOdbiorcaEP.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Temat:";
            // 
            // TematTB
            // 
            this.TematTB.Location = new System.Drawing.Point(84, 86);
            this.TematTB.Name = "TematTB";
            this.TematTB.Size = new System.Drawing.Size(483, 23);
            this.TematTB.TabIndex = 9;
            // 
            // EmailMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 560);
            this.Controls.Add(this.TematTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TrescTB);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AdresOdbiorcyTB);
            this.Controls.Add(this.label1);
            this.MinimizeBox = false;
            this.Name = "EmailMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wysyłanie wiadomości E-mail";
            ((System.ComponentModel.ISupportInitialize)(this.EmailOdbiorcaEP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AdresOdbiorcyTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox TrescTB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider EmailOdbiorcaEP;
        private System.Windows.Forms.TextBox TematTB;
        private System.Windows.Forms.Label label4;
    }
}