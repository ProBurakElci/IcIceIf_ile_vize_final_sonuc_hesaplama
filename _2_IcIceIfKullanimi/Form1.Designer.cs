namespace _2_IcIceIfKullanimi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBilgileriniz = new System.Windows.Forms.Label();
            this.txtVize1 = new System.Windows.Forms.TextBox();
            this.txtVize2 = new System.Windows.Forms.TextBox();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "1.Vize";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "2.Vize";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Final";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 249);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bilgileriniz";
            // 
            // lblBilgileriniz
            // 
            this.lblBilgileriniz.AutoSize = true;
            this.lblBilgileriniz.ForeColor = System.Drawing.Color.Red;
            this.lblBilgileriniz.Location = new System.Drawing.Point(160, 249);
            this.lblBilgileriniz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBilgileriniz.Name = "lblBilgileriniz";
            this.lblBilgileriniz.Size = new System.Drawing.Size(37, 16);
            this.lblBilgileriniz.TabIndex = 4;
            this.lblBilgileriniz.Text = "label";
            // 
            // txtVize1
            // 
            this.txtVize1.Location = new System.Drawing.Point(136, 63);
            this.txtVize1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVize1.Name = "txtVize1";
            this.txtVize1.Size = new System.Drawing.Size(132, 22);
            this.txtVize1.TabIndex = 5;
            // 
            // txtVize2
            // 
            this.txtVize2.Location = new System.Drawing.Point(136, 105);
            this.txtVize2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVize2.Name = "txtVize2";
            this.txtVize2.Size = new System.Drawing.Size(132, 22);
            this.txtVize2.TabIndex = 6;
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(136, 148);
            this.txtFinal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(132, 22);
            this.txtFinal.TabIndex = 7;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(136, 196);
            this.btnHesapla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(100, 28);
            this.btnHesapla.TabIndex = 8;
            this.btnHesapla.Text = "HESAPLA";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.txtVize2);
            this.Controls.Add(this.txtVize1);
            this.Controls.Add(this.lblBilgileriniz);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBilgileriniz;
        private System.Windows.Forms.TextBox txtVize1;
        private System.Windows.Forms.TextBox txtVize2;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.Button btnHesapla;
    }
}

