namespace Aplikacija_za_biblioteku
{
    partial class FormKnjige
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
            this.fListaKnj = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fTrazi = new System.Windows.Forms.TextBox();
            this.btnTrazi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fListaKnj
            // 
            this.fListaKnj.FormattingEnabled = true;
            this.fListaKnj.Location = new System.Drawing.Point(28, 55);
            this.fListaKnj.Name = "fListaKnj";
            this.fListaKnj.Size = new System.Drawing.Size(402, 186);
            this.fListaKnj.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "lista knjiga";
            // 
            // fTrazi
            // 
            this.fTrazi.Location = new System.Drawing.Point(217, 29);
            this.fTrazi.Name = "fTrazi";
            this.fTrazi.Size = new System.Drawing.Size(100, 20);
            this.fTrazi.TabIndex = 2;
            this.fTrazi.Text = "search";
            // 
            // btnTrazi
            // 
            this.btnTrazi.Location = new System.Drawing.Point(355, 247);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(75, 23);
            this.btnTrazi.TabIndex = 3;
            this.btnTrazi.Text = "trazi";
            this.btnTrazi.UseVisualStyleBackColor = true;
            this.btnTrazi.Click += new System.EventHandler(this.btnTrazi_Click);
            // 
            // FormKnjige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 280);
            this.Controls.Add(this.btnTrazi);
            this.Controls.Add(this.fTrazi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fListaKnj);
            this.Name = "FormKnjige";
            this.Text = "Knjige";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox fListaKnj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fTrazi;
        private System.Windows.Forms.Button btnTrazi;
    }
}