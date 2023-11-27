namespace Aplikacija_za_biblioteku
{
    partial class FormKorisnik
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
            this.ftraziKor = new System.Windows.Forms.TextBox();
            this.btnTrazi = new System.Windows.Forms.Button();
            this.fListKor = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ftraziKor
            // 
            this.ftraziKor.Location = new System.Drawing.Point(12, 12);
            this.ftraziKor.Name = "ftraziKor";
            this.ftraziKor.Size = new System.Drawing.Size(126, 20);
            this.ftraziKor.TabIndex = 0;
            this.ftraziKor.Text = "ime i prezime korisnika";
            // 
            // btnTrazi
            // 
            this.btnTrazi.Location = new System.Drawing.Point(417, 304);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(75, 23);
            this.btnTrazi.TabIndex = 1;
            this.btnTrazi.Text = "trazi";
            this.btnTrazi.UseVisualStyleBackColor = true;
            this.btnTrazi.Click += new System.EventHandler(this.btnTrazi_Click);
            // 
            // fListKor
            // 
            this.fListKor.FormattingEnabled = true;
            this.fListKor.Location = new System.Drawing.Point(12, 39);
            this.fListKor.Name = "fListKor";
            this.fListKor.Size = new System.Drawing.Size(480, 251);
            this.fListKor.TabIndex = 2;
            // 
            // FormKorisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 339);
            this.Controls.Add(this.fListKor);
            this.Controls.Add(this.btnTrazi);
            this.Controls.Add(this.ftraziKor);
            this.Name = "FormKorisnik";
            this.Text = "Korisnik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ftraziKor;
        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.ListBox fListKor;
    }
}