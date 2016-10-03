namespace MyApplication
{
	partial class RegisterForm
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
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SignUp = new System.Windows.Forms.Button();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberLable = new System.Windows.Forms.Label();
            this.EmailLable = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.UsernameLabel.Location = new System.Drawing.Point(21, 15);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(65, 13);
            this.UsernameLabel.TabIndex = 0;
            this.UsernameLabel.Text = "&Username";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsernameTextBox.Location = new System.Drawing.Point(131, 12);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(307, 21);
            this.UsernameTextBox.TabIndex = 1;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordTextBox.Location = new System.Drawing.Point(131, 39);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(307, 21);
            this.PasswordTextBox.TabIndex = 3;
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FullNameTextBox.Location = new System.Drawing.Point(131, 66);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(307, 21);
            this.FullNameTextBox.TabIndex = 5;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.PasswordLabel.Location = new System.Drawing.Point(21, 42);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(61, 13);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "&Password";
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.FullNameLabel.Location = new System.Drawing.Point(21, 69);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(59, 13);
            this.FullNameLabel.TabIndex = 4;
            this.FullNameLabel.Text = "&FullName";
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(291, 158);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 7;
            this.ResetButton.Text = "&Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            this.ResetButton.MouseEnter += new System.EventHandler(this.SignUp_MouseEnter);
            this.ResetButton.MouseLeave += new System.EventHandler(this.SignUp_MouseLeave);
            // 
            // SignUp
            // 
            this.SignUp.Location = new System.Drawing.Point(210, 158);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(75, 23);
            this.SignUp.TabIndex = 6;
            this.SignUp.Text = "SignUp";
            this.SignUp.UseVisualStyleBackColor = true;
            this.SignUp.Click += new System.EventHandler(this.SubmitButton_Click);
            this.SignUp.MouseEnter += new System.EventHandler(this.SignUp_MouseEnter);
            this.SignUp.MouseLeave += new System.EventHandler(this.SignUp_MouseLeave);
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(131, 120);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(307, 21);
            this.PhoneNumberTextBox.TabIndex = 11;
            // 
            // PhoneNumberLable
            // 
            this.PhoneNumberLable.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.PhoneNumberLable.AutoSize = true;
            this.PhoneNumberLable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.PhoneNumberLable.Location = new System.Drawing.Point(23, 120);
            this.PhoneNumberLable.Name = "PhoneNumberLable";
            this.PhoneNumberLable.Size = new System.Drawing.Size(87, 13);
            this.PhoneNumberLable.TabIndex = 10;
            this.PhoneNumberLable.Text = "&PhoneNumber";
            // 
            // EmailLable
            // 
            this.EmailLable.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.EmailLable.AutoSize = true;
            this.EmailLable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.EmailLable.Location = new System.Drawing.Point(23, 93);
            this.EmailLable.Name = "EmailLable";
            this.EmailLable.Size = new System.Drawing.Size(38, 13);
            this.EmailLable.TabIndex = 8;
            this.EmailLable.Text = "&Email";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EmailTextBox.Location = new System.Drawing.Point(131, 93);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(307, 21);
            this.EmailTextBox.TabIndex = 9;
            // 
            // RegisterForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::MyApplication.Properties.Resources.Chrysanthemum;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(470, 202);
            this.Controls.Add(this.PhoneNumberTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.PhoneNumberLable);
            this.Controls.Add(this.EmailLable);
            this.Controls.Add(this.SignUp);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.FullNameLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.FullNameTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.UsernameLabel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimumSize = new System.Drawing.Size(266, 166);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up ";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label UsernameLabel;
		private System.Windows.Forms.TextBox UsernameTextBox;
		private System.Windows.Forms.TextBox PasswordTextBox;
		private System.Windows.Forms.TextBox FullNameTextBox;
		private System.Windows.Forms.Label PasswordLabel;
		private System.Windows.Forms.Label FullNameLabel;
		private System.Windows.Forms.Button ResetButton;
		private System.Windows.Forms.Button SignUp;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.Label PhoneNumberLable;
        private System.Windows.Forms.Label EmailLable;
        private System.Windows.Forms.TextBox EmailTextBox;
	}
}

