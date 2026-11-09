namespace RoadMapping
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            enterButton = new Button();
            passwordTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            usernameTextBox = new MaskedTextBox();
            newAccountButton = new Button();
            signInGroupBox = new GroupBox();
            newAccountGroupBox = new GroupBox();
            createButton = new Button();
            label3 = new Label();
            newUsernameTextBox = new MaskedTextBox();
            newPasswordTextBox = new TextBox();
            label4 = new Label();
            signInGroupBox.SuspendLayout();
            newAccountGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // enterButton
            // 
            enterButton.Location = new Point(219, 18);
            enterButton.Name = "enterButton";
            enterButton.Size = new Size(72, 52);
            enterButton.TabIndex = 0;
            enterButton.Text = "Enter";
            enterButton.UseVisualStyleBackColor = true;
            enterButton.Click += enterButton_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(75, 48);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(138, 23);
            passwordTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 48);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 2;
            label1.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 3;
            label2.Text = "Username:";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(75, 16);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(138, 23);
            usernameTextBox.TabIndex = 4;
            // 
            // newAccountButton
            // 
            newAccountButton.Location = new Point(60, 111);
            newAccountButton.Name = "newAccountButton";
            newAccountButton.Size = new Size(178, 40);
            newAccountButton.TabIndex = 5;
            newAccountButton.Text = "Create new account";
            newAccountButton.UseVisualStyleBackColor = true;
            newAccountButton.Click += newAccountButton_Click;
            // 
            // signInGroupBox
            // 
            signInGroupBox.Controls.Add(label2);
            signInGroupBox.Controls.Add(usernameTextBox);
            signInGroupBox.Controls.Add(newAccountButton);
            signInGroupBox.Controls.Add(enterButton);
            signInGroupBox.Controls.Add(passwordTextBox);
            signInGroupBox.Controls.Add(label1);
            signInGroupBox.Location = new Point(38, 50);
            signInGroupBox.Name = "signInGroupBox";
            signInGroupBox.Size = new Size(297, 174);
            signInGroupBox.TabIndex = 6;
            signInGroupBox.TabStop = false;
            signInGroupBox.Text = "Sign in:";
            // 
            // newAccountGroupBox
            // 
            newAccountGroupBox.Controls.Add(createButton);
            newAccountGroupBox.Controls.Add(label3);
            newAccountGroupBox.Controls.Add(newUsernameTextBox);
            newAccountGroupBox.Controls.Add(newPasswordTextBox);
            newAccountGroupBox.Controls.Add(label4);
            newAccountGroupBox.Location = new Point(351, 50);
            newAccountGroupBox.Name = "newAccountGroupBox";
            newAccountGroupBox.Size = new Size(297, 100);
            newAccountGroupBox.TabIndex = 7;
            newAccountGroupBox.TabStop = false;
            newAccountGroupBox.Text = "Create new account:";
            // 
            // createButton
            // 
            createButton.Location = new Point(219, 26);
            createButton.Name = "createButton";
            createButton.Size = new Size(72, 52);
            createButton.TabIndex = 9;
            createButton.Text = "Create";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 26);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 7;
            label3.Text = "Username:";
            // 
            // newUsernameTextBox
            // 
            newUsernameTextBox.Location = new Point(85, 23);
            newUsernameTextBox.Name = "newUsernameTextBox";
            newUsernameTextBox.Size = new Size(128, 23);
            newUsernameTextBox.TabIndex = 8;
            // 
            // newPasswordTextBox
            // 
            newPasswordTextBox.Location = new Point(85, 55);
            newPasswordTextBox.Name = "newPasswordTextBox";
            newPasswordTextBox.Size = new Size(128, 23);
            newPasswordTextBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 55);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 6;
            label4.Text = "Password:";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 337);
            Controls.Add(newAccountGroupBox);
            Controls.Add(signInGroupBox);
            Name = "LoginForm";
            Text = "Login";
            signInGroupBox.ResumeLayout(false);
            signInGroupBox.PerformLayout();
            newAccountGroupBox.ResumeLayout(false);
            newAccountGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button enterButton;
        private TextBox passwordTextBox;
        private Label label1;
        private Label label2;
        private MaskedTextBox usernameTextBox;
        private Button newAccountButton;
        private GroupBox signInGroupBox;
        private GroupBox newAccountGroupBox;
        private Button createButton;
        private Label label3;
        private MaskedTextBox newUsernameTextBox;
        private TextBox newPasswordTextBox;
        private Label label4;
    }
}