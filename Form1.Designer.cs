namespace VucutKitleİndexHesap
{
    partial class VKI
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_hesapla = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.LblSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(144, 110);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "50";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "170";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kilonuz (KG) :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Boyunuz (CM) :";
            // 
            // button_hesapla
            // 
            this.button_hesapla.ForeColor = System.Drawing.Color.DarkBlue;
            this.button_hesapla.Location = new System.Drawing.Point(143, 156);
            this.button_hesapla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_hesapla.Name = "button_hesapla";
            this.button_hesapla.Size = new System.Drawing.Size(88, 37);
            this.button_hesapla.TabIndex = 7;
            this.button_hesapla.Text = "Hesapla";
            this.button_hesapla.UseVisualStyleBackColor = true;
            this.button_hesapla.Click += new System.EventHandler(this.button_hesapla_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Cinsiyetiniz :";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(144, 22);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(53, 17);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Kadın";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(144, 49);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(54, 17);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "Erkek";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.ForeColor = System.Drawing.Color.DarkBlue;
            this.BtnTemizle.Location = new System.Drawing.Point(256, 156);
            this.BtnTemizle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(88, 37);
            this.BtnTemizle.TabIndex = 16;
            this.BtnTemizle.Text = "Temizle";
            this.BtnTemizle.UseVisualStyleBackColor = true;
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // LblSonuc
            // 
            this.LblSonuc.AutoSize = true;
            this.LblSonuc.Location = new System.Drawing.Point(89, 205);
            this.LblSonuc.Name = "LblSonuc";
            this.LblSonuc.Size = new System.Drawing.Size(0, 13);
            this.LblSonuc.TabIndex = 17;
            // 
            // VKI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(381, 238);
            this.Controls.Add(this.LblSonuc);
            this.Controls.Add(this.BtnTemizle);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_hesapla);
            this.Name = "VKI";
            this.Text = " Vücut Kitle İndeksi Hesaplama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_hesapla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button BtnTemizle;
        private System.Windows.Forms.Label LblSonuc;
    }
}

