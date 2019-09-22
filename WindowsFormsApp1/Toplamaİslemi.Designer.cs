namespace WindowsFormsApp1
{
    partial class FormToplama
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
            this.Toplama = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.btnTopla = new System.Windows.Forms.Button();
            this.txtİkinciSayi = new System.Windows.Forms.TextBox();
            this.txtBirinciSayi = new System.Windows.Forms.TextBox();
            this.lblİkinciSayi = new System.Windows.Forms.Label();
            this.lblBirinciSayi = new System.Windows.Forms.Label();
            this.lvlog = new System.Windows.Forms.TabPage();
            this.Toplama.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Toplama
            // 
            this.Toplama.Controls.Add(this.tabPage1);
            this.Toplama.Controls.Add(this.lvlog);
            this.Toplama.Location = new System.Drawing.Point(-1, 12);
            this.Toplama.Name = "Toplama";
            this.Toplama.SelectedIndex = 0;
            this.Toplama.Size = new System.Drawing.Size(1433, 642);
            this.Toplama.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtSonuc);
            this.tabPage1.Controls.Add(this.btnTopla);
            this.tabPage1.Controls.Add(this.txtİkinciSayi);
            this.tabPage1.Controls.Add(this.txtBirinciSayi);
            this.tabPage1.Controls.Add(this.lblİkinciSayi);
            this.tabPage1.Controls.Add(this.lblBirinciSayi);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1425, 616);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Toplama";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtSonuc
            // 
            this.txtSonuc.Location = new System.Drawing.Point(473, 107);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(100, 20);
            this.txtSonuc.TabIndex = 11;
            // 
            // btnTopla
            // 
            this.btnTopla.Location = new System.Drawing.Point(335, 104);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(75, 23);
            this.btnTopla.TabIndex = 10;
            this.btnTopla.Text = "Topla";
            this.btnTopla.UseVisualStyleBackColor = true;
            // 
            // txtİkinciSayi
            // 
            this.txtİkinciSayi.Location = new System.Drawing.Point(164, 131);
            this.txtİkinciSayi.Name = "txtİkinciSayi";
            this.txtİkinciSayi.Size = new System.Drawing.Size(133, 20);
            this.txtİkinciSayi.TabIndex = 9;
            // 
            // txtBirinciSayi
            // 
            this.txtBirinciSayi.Location = new System.Drawing.Point(164, 81);
            this.txtBirinciSayi.Name = "txtBirinciSayi";
            this.txtBirinciSayi.Size = new System.Drawing.Size(135, 20);
            this.txtBirinciSayi.TabIndex = 8;
            // 
            // lblİkinciSayi
            // 
            this.lblİkinciSayi.AutoSize = true;
            this.lblİkinciSayi.Location = new System.Drawing.Point(68, 134);
            this.lblİkinciSayi.Name = "lblİkinciSayi";
            this.lblİkinciSayi.Size = new System.Drawing.Size(55, 13);
            this.lblİkinciSayi.TabIndex = 7;
            this.lblİkinciSayi.Text = "İkinci Sayı";
            // 
            // lblBirinciSayi
            // 
            this.lblBirinciSayi.AutoSize = true;
            this.lblBirinciSayi.Location = new System.Drawing.Point(68, 81);
            this.lblBirinciSayi.Name = "lblBirinciSayi";
            this.lblBirinciSayi.Size = new System.Drawing.Size(58, 13);
            this.lblBirinciSayi.TabIndex = 6;
            this.lblBirinciSayi.Text = "Birinci Sayı";
            // 
            // lvlog
            // 
            this.lvlog.Location = new System.Drawing.Point(4, 22);
            this.lvlog.Name = "lvlog";
            this.lvlog.Padding = new System.Windows.Forms.Padding(3);
            this.lvlog.Size = new System.Drawing.Size(1425, 616);
            this.lvlog.TabIndex = 1;
            this.lvlog.Text = "lvlog";
            this.lvlog.UseVisualStyleBackColor = true;
            // 
            // FormToplama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 716);
            this.Controls.Add(this.Toplama);
            this.Name = "FormToplama";
            this.Text = "Toplama İslemi";
            this.Shown += new System.EventHandler(this.FormToplama_Shown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormToplama_KeyPress);
            this.Toplama.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl Toplama;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage lvlog;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.TextBox txtİkinciSayi;
        private System.Windows.Forms.TextBox txtBirinciSayi;
        private System.Windows.Forms.Label lblİkinciSayi;
        private System.Windows.Forms.Label lblBirinciSayi;
    }
}

