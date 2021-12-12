
namespace Kartotekapracownikow
{
    partial class Main
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
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pracownikaBTN = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelWyswietlajacy = new System.Windows.Forms.Panel();
            this.status = new System.Windows.Forms.StatusStrip();
            this.statusWersja = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusUzytkownik = new System.Windows.Forms.ToolStripStatusLabel();
            this.wyswietlanieForms = new System.Windows.Forms.TabControl();
            this.mainTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelWyswietlajacy.SuspendLayout();
            this.status.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.tabPage1);
            this.mainTabControl.Controls.Add(this.tabPage2);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(839, 72);
            this.mainTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitter1);
            this.tabPage1.Controls.Add(this.pracownikaBTN);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(831, 44);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ogólne";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(85, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 38);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // pracownikaBTN
            // 
            this.pracownikaBTN.Dock = System.Windows.Forms.DockStyle.Left;
            this.pracownikaBTN.Location = new System.Drawing.Point(3, 3);
            this.pracownikaBTN.Name = "pracownikaBTN";
            this.pracownikaBTN.Size = new System.Drawing.Size(82, 38);
            this.pracownikaBTN.TabIndex = 0;
            this.pracownikaBTN.Text = "Pracownicy";
            this.pracownikaBTN.UseVisualStyleBackColor = true;
            this.pracownikaBTN.Click += new System.EventHandler(this.pracownikaBTN_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(831, 44);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panelWyswietlajacy
            // 
            this.panelWyswietlajacy.Controls.Add(this.wyswietlanieForms);
            this.panelWyswietlajacy.Location = new System.Drawing.Point(0, 72);
            this.panelWyswietlajacy.Name = "panelWyswietlajacy";
            this.panelWyswietlajacy.Size = new System.Drawing.Size(839, 369);
            this.panelWyswietlajacy.TabIndex = 1;
            // 
            // status
            // 
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusWersja,
            this.statusUzytkownik});
            this.status.Location = new System.Drawing.Point(0, 419);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(839, 22);
            this.status.TabIndex = 2;
            this.status.Text = "statusStrip1";
            // 
            // statusWersja
            // 
            this.statusWersja.Name = "statusWersja";
            this.statusWersja.Size = new System.Drawing.Size(72, 17);
            this.statusWersja.Text = "Wersja: 1.0.0";
            // 
            // statusUzytkownik
            // 
            this.statusUzytkownik.Name = "statusUzytkownik";
            this.statusUzytkownik.Size = new System.Drawing.Size(139, 17);
            this.statusUzytkownik.Text = "Zalogowany jako: Michał";
            // 
            // wyswietlanieForms
            // 
            this.wyswietlanieForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wyswietlanieForms.Location = new System.Drawing.Point(0, 0);
            this.wyswietlanieForms.Name = "wyswietlanieForms";
            this.wyswietlanieForms.SelectedIndex = 0;
            this.wyswietlanieForms.Size = new System.Drawing.Size(839, 369);
            this.wyswietlanieForms.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 441);
            this.Controls.Add(this.status);
            this.Controls.Add(this.panelWyswietlajacy);
            this.Controls.Add(this.mainTabControl);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kartoteka";
            this.Load += new System.EventHandler(this.Main_Load);
            this.mainTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panelWyswietlajacy.ResumeLayout(false);
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button pracownikaBTN;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panelWyswietlajacy;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel statusWersja;
        private System.Windows.Forms.ToolStripStatusLabel statusUzytkownik;
        private System.Windows.Forms.TabControl wyswietlanieForms;
    }
}