namespace RoadMapping
{
    partial class AddRoadForm
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
            updateButton = new Button();
            point2TextBox = new MaskedTextBox();
            notesTextBox = new TextBox();
            point1TextBox = new MaskedTextBox();
            label7 = new Label();
            roadTypeComboBox = new ComboBox();
            label6 = new Label();
            distanceTextBox = new MaskedTextBox();
            label5 = new Label();
            speedLimitComboBox = new ComboBox();
            label4 = new Label();
            roadNameTextBox = new MaskedTextBox();
            label2 = new Label();
            backButton = new Button();
            label3 = new Label();
            label1 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // updateButton
            // 
            updateButton.Location = new Point(101, 493);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(148, 61);
            updateButton.TabIndex = 4;
            updateButton.Text = "Save changes";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // point2TextBox
            // 
            point2TextBox.Location = new Point(42, 218);
            point2TextBox.Name = "point2TextBox";
            point2TextBox.Size = new Size(172, 23);
            point2TextBox.TabIndex = 13;
            // 
            // notesTextBox
            // 
            notesTextBox.Location = new Point(42, 412);
            notesTextBox.Multiline = true;
            notesTextBox.Name = "notesTextBox";
            notesTextBox.Size = new Size(250, 63);
            notesTextBox.TabIndex = 4;
            // 
            // point1TextBox
            // 
            point1TextBox.Location = new Point(41, 156);
            point1TextBox.Name = "point1TextBox";
            point1TextBox.Size = new Size(172, 23);
            point1TextBox.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(42, 394);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 19;
            label7.Text = "Notes:";
            // 
            // roadTypeComboBox
            // 
            roadTypeComboBox.FormattingEnabled = true;
            roadTypeComboBox.Items.AddRange(new object[] { "A-road", "B-road", "Motorway", "Private road" });
            roadTypeComboBox.Location = new Point(41, 352);
            roadTypeComboBox.Name = "roadTypeComboBox";
            roadTypeComboBox.Size = new Size(135, 23);
            roadTypeComboBox.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 334);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 17;
            label6.Text = "Road type:";
            // 
            // distanceTextBox
            // 
            distanceTextBox.Location = new Point(166, 298);
            distanceTextBox.Name = "distanceTextBox";
            distanceTextBox.Size = new Size(42, 23);
            distanceTextBox.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(166, 280);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 15;
            label5.Text = "Distance (km):";
            // 
            // speedLimitComboBox
            // 
            speedLimitComboBox.FormattingEnabled = true;
            speedLimitComboBox.Items.AddRange(new object[] { "5", "10", "20", "30", "40", "50", "60", "70" });
            speedLimitComboBox.Location = new Point(42, 298);
            speedLimitComboBox.Name = "speedLimitComboBox";
            speedLimitComboBox.Size = new Size(57, 23);
            speedLimitComboBox.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 280);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 14;
            label4.Text = "Speed limit (mph):";
            // 
            // roadNameTextBox
            // 
            roadNameTextBox.Location = new Point(41, 84);
            roadNameTextBox.Name = "roadNameTextBox";
            roadNameTextBox.Size = new Size(251, 23);
            roadNameTextBox.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 5;
            label2.Text = "Name:";
            // 
            // backButton
            // 
            backButton.Location = new Point(29, 12);
            backButton.Name = "backButton";
            backButton.Size = new Size(75, 23);
            backButton.TabIndex = 18;
            backButton.Text = "Go back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 66);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 6459;
            label3.Text = "Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 138);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 6460;
            label1.Text = "Point 1:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(42, 200);
            label8.Name = "label8";
            label8.Size = new Size(47, 15);
            label8.TabIndex = 6461;
            label8.Text = "Point 2:";
            // 
            // AddRoadForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 565);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(point2TextBox);
            Controls.Add(point1TextBox);
            Controls.Add(label3);
            Controls.Add(updateButton);
            Controls.Add(backButton);
            Controls.Add(notesTextBox);
            Controls.Add(label7);
            Controls.Add(roadTypeComboBox);
            Controls.Add(label6);
            Controls.Add(distanceTextBox);
            Controls.Add(label5);
            Controls.Add(speedLimitComboBox);
            Controls.Add(label4);
            Controls.Add(roadNameTextBox);
            Name = "AddRoadForm";
            Text = "Add road";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label7;
        private ComboBox roadTypeComboBox;
        private Label label6;
        private MaskedTextBox distanceTextBox;
        private Label label5;
        private ComboBox speedLimitComboBox;
        private Label label4;
        private MaskedTextBox roadNameTextBox;
        private TextBox notesTextBox;
        private Button updateButton;
        private MaskedTextBox point1TextBox;
        private MaskedTextBox point2TextBox;
        private Button backButton;
        private Label label2;
        private Label label3;
        private Label label1;
        private Label label8;
    }
}