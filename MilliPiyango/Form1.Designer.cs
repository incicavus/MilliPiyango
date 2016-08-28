namespace MilliPiyango
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBilet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSon3 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSon2 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbAmorti = new System.Windows.Forms.ListBox();
            this.btnSonuc = new System.Windows.Forms.Button();
            this.btnYeniCekilis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MilliPiyango.Properties.Resources.milli_piyango_yilbasi_cekilisi;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtBilet
            // 
            this.txtBilet.Enabled = false;
            this.txtBilet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBilet.Location = new System.Drawing.Point(312, 118);
            this.txtBilet.Multiline = true;
            this.txtBilet.Name = "txtBilet";
            this.txtBilet.Size = new System.Drawing.Size(147, 37);
            this.txtBilet.TabIndex = 1;
            this.txtBilet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(93, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Son 3";
            // 
            // lbSon3
            // 
            this.lbSon3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSon3.FormattingEnabled = true;
            this.lbSon3.ItemHeight = 16;
            this.lbSon3.Location = new System.Drawing.Point(68, 312);
            this.lbSon3.Name = "lbSon3";
            this.lbSon3.Size = new System.Drawing.Size(105, 148);
            this.lbSon3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(244, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Son 2";
            // 
            // lbSon2
            // 
            this.lbSon2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSon2.FormattingEnabled = true;
            this.lbSon2.ItemHeight = 16;
            this.lbSon2.Location = new System.Drawing.Point(219, 312);
            this.lbSon2.Name = "lbSon2";
            this.lbSon2.Size = new System.Drawing.Size(105, 148);
            this.lbSon2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(395, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amorti";
            // 
            // lbAmorti
            // 
            this.lbAmorti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbAmorti.FormattingEnabled = true;
            this.lbAmorti.ItemHeight = 16;
            this.lbAmorti.Location = new System.Drawing.Point(370, 312);
            this.lbAmorti.Name = "lbAmorti";
            this.lbAmorti.Size = new System.Drawing.Size(105, 148);
            this.lbAmorti.TabIndex = 3;
            // 
            // btnSonuc
            // 
            this.btnSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSonuc.Location = new System.Drawing.Point(68, 472);
            this.btnSonuc.Name = "btnSonuc";
            this.btnSonuc.Size = new System.Drawing.Size(117, 33);
            this.btnSonuc.TabIndex = 4;
            this.btnSonuc.Text = "Çekiliş Sonucu";
            this.btnSonuc.UseVisualStyleBackColor = true;
            this.btnSonuc.Click += new System.EventHandler(this.btnSonuc_Click);
            // 
            // btnYeniCekilis
            // 
            this.btnYeniCekilis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniCekilis.Location = new System.Drawing.Point(358, 472);
            this.btnYeniCekilis.Name = "btnYeniCekilis";
            this.btnYeniCekilis.Size = new System.Drawing.Size(117, 33);
            this.btnYeniCekilis.TabIndex = 4;
            this.btnYeniCekilis.Text = "Yeni Çekiliş";
            this.btnYeniCekilis.UseVisualStyleBackColor = true;
            this.btnYeniCekilis.Click += new System.EventHandler(this.btnYeniCekilis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 517);
            this.Controls.Add(this.btnYeniCekilis);
            this.Controls.Add(this.btnSonuc);
            this.Controls.Add(this.lbAmorti);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbSon2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbSon3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBilet);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBilet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbSon3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbSon2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbAmorti;
        private System.Windows.Forms.Button btnSonuc;
        private System.Windows.Forms.Button btnYeniCekilis;
    }
}

