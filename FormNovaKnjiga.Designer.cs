namespace Aplikacija_za_biblioteku
{
    partial class FormNovaKnjiga
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.fAutor = new System.Windows.Forms.TextBox();
            this.fNaslov = new System.Windows.Forms.TextBox();
            this.fIzdavac = new System.Windows.Forms.TextBox();
            this.fGodIzd = new System.Windows.Forms.TextBox();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 360);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(264, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(246, 360);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // fAutor
            // 
            this.fAutor.Location = new System.Drawing.Point(603, 89);
            this.fAutor.Name = "fAutor";
            this.fAutor.Size = new System.Drawing.Size(100, 20);
            this.fAutor.TabIndex = 2;
            // 
            // fNaslov
            // 
            this.fNaslov.Location = new System.Drawing.Point(603, 133);
            this.fNaslov.Name = "fNaslov";
            this.fNaslov.Size = new System.Drawing.Size(100, 20);
            this.fNaslov.TabIndex = 3;
            // 
            // fIzdavac
            // 
            this.fIzdavac.Location = new System.Drawing.Point(603, 179);
            this.fIzdavac.Name = "fIzdavac";
            this.fIzdavac.Size = new System.Drawing.Size(100, 20);
            this.fIzdavac.TabIndex = 4;
            // 
            // fGodIzd
            // 
            this.fGodIzd.Location = new System.Drawing.Point(603, 221);
            this.fGodIzd.Name = "fGodIzd";
            this.fGodIzd.Size = new System.Drawing.Size(100, 20);
            this.fGodIzd.TabIndex = 5;
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(617, 342);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(75, 23);
            this.btnUnesi.TabIndex = 7;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(600, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Autor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(600, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Naslov:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(600, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Izdavac:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(600, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Godina izdavanja:";
            // 
            // FormNovaKnjiga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.fGodIzd);
            this.Controls.Add(this.fIzdavac);
            this.Controls.Add(this.fNaslov);
            this.Controls.Add(this.fAutor);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormNovaKnjiga";
            this.Text = "FormNovaKnjiga";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox fAutor;
        private System.Windows.Forms.TextBox fNaslov;
        private System.Windows.Forms.TextBox fIzdavac;
        private System.Windows.Forms.TextBox fGodIzd;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}