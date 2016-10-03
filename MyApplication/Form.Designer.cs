namespace MyApplication
{
    partial class UpdateProfileForm
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
            this.LoginButton = new System.Windows.Forms.Button();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginButton.BackColor = System.Drawing.SystemColors.Control;
            this.LoginButton.ForeColor = System.Drawing.Color.Black;
            this.LoginButton.Location = new System.Drawing.Point(105, 107);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(122, 28);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "&Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            this.LoginButton.DragLeave += new System.EventHandler(this.SignUp_DragLeave);
            this.LoginButton.MouseEnter += new System.EventHandler(this.SignUp_MouseEnter);
            this.LoginButton.MouseLeave += new System.EventHandler(this.SignUp_DragLeave);
            // 
            // SignUpButton
            // 
            this.SignUpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SignUpButton.BackColor = System.Drawing.SystemColors.Control;
            this.SignUpButton.ForeColor = System.Drawing.Color.Black;
            this.SignUpButton.Location = new System.Drawing.Point(248, 107);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(122, 28);
            this.SignUpButton.TabIndex = 5;
            this.SignUpButton.Text = "&SignUp";
            this.SignUpButton.UseVisualStyleBackColor = false;
            this.SignUpButton.Click += new System.EventHandler(this.SignUp_Click);
            this.SignUpButton.DragLeave += new System.EventHandler(this.SignUp_DragLeave);
            this.SignUpButton.MouseEnter += new System.EventHandler(this.SignUp_MouseEnter);
            this.SignUpButton.MouseLeave += new System.EventHandler(this.SignUp_DragLeave);
            // 
            // UpdateProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(465, 200);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.LoginButton);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "UpdateProfileForm";
            this.Text = "UpdateProfileForm";
            this.Load += new System.EventHandler(this.UpdateProfileForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button SignUpButton;
    }
}