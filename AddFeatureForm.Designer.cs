namespace RoadMapping
{
    partial class AddFeatureForm
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
            featureNameTextBox = new TextBox();
            featureTypeComboBox = new ComboBox();
            longitudeTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            updateButton = new Button();
            latitudeTextBox = new TextBox();
            label4 = new Label();
            backButton = new Button();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // featureNameTextBox
            // 
            featureNameTextBox.Location = new Point(12, 84);
            featureNameTextBox.Name = "featureNameTextBox";
            featureNameTextBox.Size = new Size(147, 23);
            featureNameTextBox.TabIndex = 0;
            // 
            // featureTypeComboBox
            // 
            featureTypeComboBox.FormattingEnabled = true;
            featureTypeComboBox.Items.AddRange(new object[] { "City", "Town", "Village", "Junction", "Roundabout", "Endpoint" });
            featureTypeComboBox.Location = new Point(12, 150);
            featureTypeComboBox.Name = "featureTypeComboBox";
            featureTypeComboBox.Size = new Size(121, 23);
            featureTypeComboBox.TabIndex = 1;
            // 
            // longitudeTextBox
            // 
            longitudeTextBox.Location = new Point(141, 233);
            longitudeTextBox.Name = "longitudeTextBox";
            longitudeTextBox.Size = new Size(100, 23);
            longitudeTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 3;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 78);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 4;
            label2.Text = "Choose type:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(141, 201);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 5;
            label3.Text = "Longitude:";
            // 
            // updateButton
            // 
            updateButton.Location = new Point(12, 281);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(103, 58);
            updateButton.TabIndex = 6;
            updateButton.Text = "Save changes";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // latitudeTextBox
            // 
            latitudeTextBox.Location = new Point(12, 233);
            latitudeTextBox.Name = "latitudeTextBox";
            latitudeTextBox.Size = new Size(100, 23);
            latitudeTextBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 201);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 8;
            label4.Text = "Latitude:";
            // 
            // backButton
            // 
            backButton.Location = new Point(12, 12);
            backButton.Name = "backButton";
            backButton.Size = new Size(75, 23);
            backButton.TabIndex = 93;
            backButton.Text = "Go back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 66);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 2070;
            label5.Text = "Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 132);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 4008;
            label6.Text = "Type";
            // 
            // AddFeatureForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 367);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(backButton);
            Controls.Add(label4);
            Controls.Add(latitudeTextBox);
            Controls.Add(updateButton);
            Controls.Add(label3);
            Controls.Add(longitudeTextBox);
            Controls.Add(featureTypeComboBox);
            Controls.Add(featureNameTextBox);
            Name = "AddFeatureForm";
            Text = "Add feature";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox featureNameTextBox;
        private ComboBox featureTypeComboBox;
        private TextBox longitudeTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button updateButton;
        private TextBox latitudeTextBox;
        private Label label4;
        private Button backButton;
        private Label label5;
        private Label label6;
    }
}