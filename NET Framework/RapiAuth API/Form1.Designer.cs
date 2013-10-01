namespace RapiAuth_API
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
            this.token = new System.Windows.Forms.TextBox();
            this.kod = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // token
            // 
            this.token.Location = new System.Drawing.Point(13, 13);
            this.token.Name = "token";
            this.token.Size = new System.Drawing.Size(218, 22);
            this.token.TabIndex = 0;
            this.token.KeyUp += new System.Windows.Forms.KeyEventHandler(this.token_KeyUp);
            // 
            // kod
            // 
            this.kod.Location = new System.Drawing.Point(237, 13);
            this.kod.Name = "kod";
            this.kod.Size = new System.Drawing.Size(218, 22);
            this.kod.TabIndex = 1;
            this.kod.KeyUp += new System.Windows.Forms.KeyEventHandler(this.token_KeyUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(461, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Kontrol";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 55);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kod);
            this.Controls.Add(this.token);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox token;
        private System.Windows.Forms.TextBox kod;
        private System.Windows.Forms.Button button1;
    }
}

