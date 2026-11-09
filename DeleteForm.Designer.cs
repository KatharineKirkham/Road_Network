namespace RoadMapping
{
    partial class DeleteForm
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
            deleteTextBox = new TextBox();
            updateButton = new Button();
            groupBox1 = new GroupBox();
            roadRadioButton = new RadioButton();
            featureRadioButton = new RadioButton();
            backButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // deleteTextBox
            // 
            deleteTextBox.Location = new Point(18, 132);
            deleteTextBox.Name = "deleteTextBox";
            deleteTextBox.Size = new Size(163, 23);
            deleteTextBox.TabIndex = 0;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(187, 132);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(75, 23);
            updateButton.TabIndex = 1;
            updateButton.Text = "Confirm";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += confirmButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(roadRadioButton);
            groupBox1.Controls.Add(featureRadioButton);
            groupBox1.Location = new Point(12, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 55);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Select:";
            // 
            // roadRadioButton
            // 
            roadRadioButton.AutoSize = true;
            roadRadioButton.Location = new Point(76, 22);
            roadRadioButton.Name = "roadRadioButton";
            roadRadioButton.Size = new Size(52, 19);
            roadRadioButton.TabIndex = 3;
            roadRadioButton.TabStop = true;
            roadRadioButton.Text = "Road";
            roadRadioButton.UseVisualStyleBackColor = true;
            // 
            // featureRadioButton
            // 
            featureRadioButton.AutoSize = true;
            featureRadioButton.Location = new Point(6, 22);
            featureRadioButton.Name = "featureRadioButton";
            featureRadioButton.Size = new Size(64, 19);
            featureRadioButton.TabIndex = 3;
            featureRadioButton.TabStop = true;
            featureRadioButton.Text = "Feature";
            featureRadioButton.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            backButton.Location = new Point(12, 12);
            backButton.Name = "backButton";
            backButton.Size = new Size(75, 23);
            backButton.TabIndex = 192;
            backButton.Text = "Go back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // DeleteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 210);
            Controls.Add(backButton);
            Controls.Add(groupBox1);
            Controls.Add(updateButton);
            Controls.Add(deleteTextBox);
            Name = "DeleteForm";
            Text = "Delete";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox deleteTextBox;
        private Button updateButton;
        private GroupBox groupBox1;
        private RadioButton roadRadioButton;
        private RadioButton featureRadioButton;
        private Button backButton;
    }
}