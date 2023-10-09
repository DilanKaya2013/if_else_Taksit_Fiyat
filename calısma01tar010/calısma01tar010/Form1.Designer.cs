namespace calısma01tar010
{
    partial class Form1
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
            this.grbSecimyap = new System.Windows.Forms.GroupBox();
            this.rbPesin = new System.Windows.Forms.RadioButton();
            this.rbTaksit2 = new System.Windows.Forms.RadioButton();
            this.rbTaksit6 = new System.Windows.Forms.RadioButton();
            this.rbTaksit9 = new System.Windows.Forms.RadioButton();
            this.rbTaksit12 = new System.Windows.Forms.RadioButton();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblToplamtutar = new System.Windows.Forms.Label();
            this.lblTaksittutar = new System.Windows.Forms.Label();
            this.grbBilgigirisi = new System.Windows.Forms.GroupBox();
            this.grbCıkıs = new System.Windows.Forms.GroupBox();
            this.grbSecimyap.SuspendLayout();
            this.grbBilgigirisi.SuspendLayout();
            this.grbCıkıs.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbSecimyap
            // 
            this.grbSecimyap.Controls.Add(this.rbTaksit12);
            this.grbSecimyap.Controls.Add(this.rbTaksit9);
            this.grbSecimyap.Controls.Add(this.rbTaksit6);
            this.grbSecimyap.Controls.Add(this.rbTaksit2);
            this.grbSecimyap.Controls.Add(this.rbPesin);
            this.grbSecimyap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grbSecimyap.Location = new System.Drawing.Point(12, 12);
            this.grbSecimyap.Name = "grbSecimyap";
            this.grbSecimyap.Size = new System.Drawing.Size(112, 210);
            this.grbSecimyap.TabIndex = 0;
            this.grbSecimyap.TabStop = false;
            this.grbSecimyap.Text = "Seçim Yap";
            // 
            // rbPesin
            // 
            this.rbPesin.AutoSize = true;
            this.rbPesin.Location = new System.Drawing.Point(6, 32);
            this.rbPesin.Name = "rbPesin";
            this.rbPesin.Size = new System.Drawing.Size(61, 19);
            this.rbPesin.TabIndex = 0;
            this.rbPesin.TabStop = true;
            this.rbPesin.Text = "Peşin";
            this.rbPesin.UseVisualStyleBackColor = true;
            // 
            // rbTaksit2
            // 
            this.rbTaksit2.AutoSize = true;
            this.rbTaksit2.Location = new System.Drawing.Point(6, 67);
            this.rbTaksit2.Name = "rbTaksit2";
            this.rbTaksit2.Size = new System.Drawing.Size(75, 19);
            this.rbTaksit2.TabIndex = 1;
            this.rbTaksit2.TabStop = true;
            this.rbTaksit2.Text = "2 Taksit";
            this.rbTaksit2.UseVisualStyleBackColor = true;
            // 
            // rbTaksit6
            // 
            this.rbTaksit6.AutoSize = true;
            this.rbTaksit6.Location = new System.Drawing.Point(6, 102);
            this.rbTaksit6.Name = "rbTaksit6";
            this.rbTaksit6.Size = new System.Drawing.Size(75, 19);
            this.rbTaksit6.TabIndex = 2;
            this.rbTaksit6.TabStop = true;
            this.rbTaksit6.Text = "6 Taksit";
            this.rbTaksit6.UseVisualStyleBackColor = true;
            // 
            // rbTaksit9
            // 
            this.rbTaksit9.AutoSize = true;
            this.rbTaksit9.Location = new System.Drawing.Point(6, 137);
            this.rbTaksit9.Name = "rbTaksit9";
            this.rbTaksit9.Size = new System.Drawing.Size(75, 19);
            this.rbTaksit9.TabIndex = 3;
            this.rbTaksit9.TabStop = true;
            this.rbTaksit9.Text = "9 Taksit";
            this.rbTaksit9.UseVisualStyleBackColor = true;
            // 
            // rbTaksit12
            // 
            this.rbTaksit12.AutoSize = true;
            this.rbTaksit12.Location = new System.Drawing.Point(6, 172);
            this.rbTaksit12.Name = "rbTaksit12";
            this.rbTaksit12.Size = new System.Drawing.Size(83, 19);
            this.rbTaksit12.TabIndex = 4;
            this.rbTaksit12.TabStop = true;
            this.rbTaksit12.Text = "12 Taksit";
            this.rbTaksit12.UseVisualStyleBackColor = true;
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFiyat.Location = new System.Drawing.Point(19, 49);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(41, 15);
            this.lblFiyat.TabIndex = 1;
            this.lblFiyat.Text = "Fiyat:";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(69, 46);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(100, 20);
            this.txtFiyat.TabIndex = 2;
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.Aquamarine;
            this.btnHesapla.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHesapla.Location = new System.Drawing.Point(69, 99);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(100, 47);
            this.btnHesapla.TabIndex = 3;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblToplamtutar
            // 
            this.lblToplamtutar.AutoSize = true;
            this.lblToplamtutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamtutar.Location = new System.Drawing.Point(19, 30);
            this.lblToplamtutar.Name = "lblToplamtutar";
            this.lblToplamtutar.Size = new System.Drawing.Size(86, 13);
            this.lblToplamtutar.TabIndex = 4;
            this.lblToplamtutar.Text = "Toplam Tutar:";
            // 
            // lblTaksittutar
            // 
            this.lblTaksittutar.AutoSize = true;
            this.lblTaksittutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTaksittutar.Location = new System.Drawing.Point(19, 63);
            this.lblTaksittutar.Name = "lblTaksittutar";
            this.lblTaksittutar.Size = new System.Drawing.Size(76, 13);
            this.lblTaksittutar.TabIndex = 5;
            this.lblTaksittutar.Text = "Taksit tutar:";
            // 
            // grbBilgigirisi
            // 
            this.grbBilgigirisi.Controls.Add(this.btnHesapla);
            this.grbBilgigirisi.Controls.Add(this.lblFiyat);
            this.grbBilgigirisi.Controls.Add(this.txtFiyat);
            this.grbBilgigirisi.Location = new System.Drawing.Point(156, 12);
            this.grbBilgigirisi.Name = "grbBilgigirisi";
            this.grbBilgigirisi.Size = new System.Drawing.Size(197, 210);
            this.grbBilgigirisi.TabIndex = 6;
            this.grbBilgigirisi.TabStop = false;
            this.grbBilgigirisi.Text = "Bilgi Girin";
            // 
            // grbCıkıs
            // 
            this.grbCıkıs.Controls.Add(this.lblTaksittutar);
            this.grbCıkıs.Controls.Add(this.lblToplamtutar);
            this.grbCıkıs.Location = new System.Drawing.Point(156, 249);
            this.grbCıkıs.Name = "grbCıkıs";
            this.grbCıkıs.Size = new System.Drawing.Size(197, 142);
            this.grbCıkıs.TabIndex = 7;
            this.grbCıkıs.TabStop = false;
            this.grbCıkıs.Text = "Çıkış";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 420);
            this.Controls.Add(this.grbCıkıs);
            this.Controls.Add(this.grbBilgigirisi);
            this.Controls.Add(this.grbSecimyap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbSecimyap.ResumeLayout(false);
            this.grbSecimyap.PerformLayout();
            this.grbBilgigirisi.ResumeLayout(false);
            this.grbBilgigirisi.PerformLayout();
            this.grbCıkıs.ResumeLayout(false);
            this.grbCıkıs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbSecimyap;
        private System.Windows.Forms.RadioButton rbTaksit12;
        private System.Windows.Forms.RadioButton rbTaksit9;
        private System.Windows.Forms.RadioButton rbTaksit6;
        private System.Windows.Forms.RadioButton rbTaksit2;
        private System.Windows.Forms.RadioButton rbPesin;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblToplamtutar;
        private System.Windows.Forms.Label lblTaksittutar;
        private System.Windows.Forms.GroupBox grbBilgigirisi;
        private System.Windows.Forms.GroupBox grbCıkıs;
    }
}

