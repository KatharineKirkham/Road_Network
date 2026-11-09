namespace RoadMapping
{
    partial class EditForm
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
            editRoadGroupBox = new GroupBox();
            point2TextBox = new TextBox();
            label8 = new Label();
            point1TextBox = new TextBox();
            notesTextBox = new TextBox();
            label7 = new Label();
            roadTypeComboBox = new ComboBox();
            label6 = new Label();
            distanceTextBox = new MaskedTextBox();
            label5 = new Label();
            speedLimitComboBox = new ComboBox();
            label4 = new Label();
            roadNameTextBox = new MaskedTextBox();
            label3 = new Label();
            editFeatureGroupBox = new GroupBox();
            label12 = new Label();
            label11 = new Label();
            latitudeTextBox = new TextBox();
            label9 = new Label();
            label10 = new Label();
            longitudeTextBox = new TextBox();
            featureTypeComboBox = new ComboBox();
            featureNameTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            searchGroupBox = new GroupBox();
            featureRadioButton = new RadioButton();
            roadRadioButton = new RadioButton();
            searchTextBox = new TextBox();
            searchButton = new Button();
            backButton = new Button();
            editRoadGroupBox.SuspendLayout();
            editFeatureGroupBox.SuspendLayout();
            searchGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // updateButton
            // 
            updateButton.Location = new Point(263, 424);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(291, 62);
            updateButton.TabIndex = 6;
            updateButton.Text = "Save Changes";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += saveButton_Click;
            // 
            // editRoadGroupBox
            // 
            editRoadGroupBox.BackColor = SystemColors.Control;
            editRoadGroupBox.Controls.Add(point2TextBox);
            editRoadGroupBox.Controls.Add(label8);
            editRoadGroupBox.Controls.Add(point1TextBox);
            editRoadGroupBox.Controls.Add(notesTextBox);
            editRoadGroupBox.Controls.Add(label7);
            editRoadGroupBox.Controls.Add(roadTypeComboBox);
            editRoadGroupBox.Controls.Add(label6);
            editRoadGroupBox.Controls.Add(distanceTextBox);
            editRoadGroupBox.Controls.Add(label5);
            editRoadGroupBox.Controls.Add(speedLimitComboBox);
            editRoadGroupBox.Controls.Add(label4);
            editRoadGroupBox.Controls.Add(roadNameTextBox);
            editRoadGroupBox.Controls.Add(label3);
            editRoadGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            editRoadGroupBox.Location = new Point(431, 35);
            editRoadGroupBox.Name = "editRoadGroupBox";
            editRoadGroupBox.Size = new Size(291, 365);
            editRoadGroupBox.TabIndex = 7;
            editRoadGroupBox.TabStop = false;
            editRoadGroupBox.Text = "Edit road:";
            // 
            // point2TextBox
            // 
            point2TextBox.Location = new Point(148, 107);
            point2TextBox.Name = "point2TextBox";
            point2TextBox.Size = new Size(100, 23);
            point2TextBox.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 78);
            label8.Name = "label8";
            label8.Size = new Size(63, 15);
            label8.TabIndex = 8;
            label8.Text = "Endpoints:";
            // 
            // point1TextBox
            // 
            point1TextBox.Location = new Point(24, 107);
            point1TextBox.Name = "point1TextBox";
            point1TextBox.Size = new Size(99, 23);
            point1TextBox.TabIndex = 8;
            // 
            // notesTextBox
            // 
            notesTextBox.Location = new Point(24, 280);
            notesTextBox.Multiline = true;
            notesTextBox.Name = "notesTextBox";
            notesTextBox.Size = new Size(250, 63);
            notesTextBox.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 262);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 19;
            label7.Text = "Notes:";
            // 
            // roadTypeComboBox
            // 
            roadTypeComboBox.FormattingEnabled = true;
            roadTypeComboBox.Items.AddRange(new object[] { "A-road", "B-road", "Motorway", "Private road" });
            roadTypeComboBox.Location = new Point(23, 220);
            roadTypeComboBox.Name = "roadTypeComboBox";
            roadTypeComboBox.Size = new Size(121, 23);
            roadTypeComboBox.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 202);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 17;
            label6.Text = "Road type:";
            // 
            // distanceTextBox
            // 
            distanceTextBox.Location = new Point(148, 166);
            distanceTextBox.Name = "distanceTextBox";
            distanceTextBox.Size = new Size(42, 23);
            distanceTextBox.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(148, 148);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 15;
            label5.Text = "Distance (km):";
            // 
            // speedLimitComboBox
            // 
            speedLimitComboBox.FormattingEnabled = true;
            speedLimitComboBox.Items.AddRange(new object[] { "5", "10", "20", "30", "40", "50", "60", "70" });
            speedLimitComboBox.Location = new Point(24, 166);
            speedLimitComboBox.Name = "speedLimitComboBox";
            speedLimitComboBox.Size = new Size(57, 23);
            speedLimitComboBox.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 148);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 14;
            label4.Text = "Speed limit (mph):";
            // 
            // roadNameTextBox
            // 
            roadNameTextBox.Location = new Point(17, 38);
            roadNameTextBox.Name = "roadNameTextBox";
            roadNameTextBox.Size = new Size(251, 23);
            roadNameTextBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 20);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 5;
            label3.Text = "Name:";
            // 
            // editFeatureGroupBox
            // 
            editFeatureGroupBox.Controls.Add(label12);
            editFeatureGroupBox.Controls.Add(label11);
            editFeatureGroupBox.Controls.Add(latitudeTextBox);
            editFeatureGroupBox.Controls.Add(label9);
            editFeatureGroupBox.Controls.Add(label10);
            editFeatureGroupBox.Controls.Add(longitudeTextBox);
            editFeatureGroupBox.Controls.Add(featureTypeComboBox);
            editFeatureGroupBox.Controls.Add(featureNameTextBox);
            editFeatureGroupBox.Location = new Point(31, 167);
            editFeatureGroupBox.Name = "editFeatureGroupBox";
            editFeatureGroupBox.Size = new Size(375, 233);
            editFeatureGroupBox.TabIndex = 8;
            editFeatureGroupBox.TabStop = false;
            editFeatureGroupBox.Text = "Edit feature:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(175, 169);
            label12.Name = "label12";
            label12.Size = new Size(64, 15);
            label12.TabIndex = 96;
            label12.Text = "Longitude:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(13, 169);
            label11.Name = "label11";
            label11.Size = new Size(53, 15);
            label11.TabIndex = 96;
            label11.Text = "Latitude:";
            // 
            // latitudeTextBox
            // 
            latitudeTextBox.Location = new Point(14, 187);
            latitudeTextBox.Name = "latitudeTextBox";
            latitudeTextBox.Size = new Size(100, 23);
            latitudeTextBox.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 110);
            label9.Name = "label9";
            label9.Size = new Size(76, 15);
            label9.TabIndex = 13;
            label9.Text = "Choose type:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(14, 31);
            label10.Name = "label10";
            label10.Size = new Size(42, 15);
            label10.TabIndex = 12;
            label10.Text = "Name:";
            // 
            // longitudeTextBox
            // 
            longitudeTextBox.Location = new Point(175, 187);
            longitudeTextBox.Name = "longitudeTextBox";
            longitudeTextBox.Size = new Size(100, 23);
            longitudeTextBox.TabIndex = 11;
            // 
            // featureTypeComboBox
            // 
            featureTypeComboBox.FormattingEnabled = true;
            featureTypeComboBox.Items.AddRange(new object[] { "City", "Town", "Village", "River", "Forest" });
            featureTypeComboBox.Location = new Point(14, 128);
            featureTypeComboBox.Name = "featureTypeComboBox";
            featureTypeComboBox.Size = new Size(121, 23);
            featureTypeComboBox.TabIndex = 10;
            // 
            // featureNameTextBox
            // 
            featureNameTextBox.Location = new Point(14, 62);
            featureNameTextBox.Name = "featureNameTextBox";
            featureNameTextBox.Size = new Size(173, 23);
            featureNameTextBox.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(175, 169);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 16;
            label1.Text = "Latitude:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 169);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 14;
            label2.Text = "Longitude:";
            // 
            // searchGroupBox
            // 
            searchGroupBox.Controls.Add(featureRadioButton);
            searchGroupBox.Controls.Add(roadRadioButton);
            searchGroupBox.Location = new Point(31, 55);
            searchGroupBox.Name = "searchGroupBox";
            searchGroupBox.Size = new Size(169, 35);
            searchGroupBox.TabIndex = 9;
            searchGroupBox.TabStop = false;
            // 
            // featureRadioButton
            // 
            featureRadioButton.AutoSize = true;
            featureRadioButton.Location = new Point(88, 9);
            featureRadioButton.Name = "featureRadioButton";
            featureRadioButton.Size = new Size(64, 19);
            featureRadioButton.TabIndex = 10;
            featureRadioButton.TabStop = true;
            featureRadioButton.Text = "Feature";
            featureRadioButton.UseVisualStyleBackColor = true;
            // 
            // roadRadioButton
            // 
            roadRadioButton.AutoSize = true;
            roadRadioButton.Location = new Point(14, 9);
            roadRadioButton.Name = "roadRadioButton";
            roadRadioButton.Size = new Size(52, 19);
            roadRadioButton.TabIndex = 10;
            roadRadioButton.TabStop = true;
            roadRadioButton.Text = "Road";
            roadRadioButton.UseVisualStyleBackColor = true;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(31, 96);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(187, 23);
            searchTextBox.TabIndex = 10;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(240, 96);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 23);
            searchButton.TabIndex = 10;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // backButton
            // 
            backButton.Location = new Point(31, 12);
            backButton.Name = "backButton";
            backButton.Size = new Size(75, 23);
            backButton.TabIndex = 95;
            backButton.Text = "Go back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 521);
            Controls.Add(backButton);
            Controls.Add(searchButton);
            Controls.Add(searchGroupBox);
            Controls.Add(editFeatureGroupBox);
            Controls.Add(editRoadGroupBox);
            Controls.Add(searchTextBox);
            Controls.Add(updateButton);
            Name = "EditForm";
            Text = "Edit";
            editRoadGroupBox.ResumeLayout(false);
            editRoadGroupBox.PerformLayout();
            editFeatureGroupBox.ResumeLayout(false);
            editFeatureGroupBox.PerformLayout();
            searchGroupBox.ResumeLayout(false);
            searchGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button updateButton;
        private GroupBox editRoadGroupBox;
        private Label label8;
        private TextBox point1TextBox;
        private TextBox notesTextBox;
        private Label label7;
        private ComboBox roadTypeComboBox;
        private Label label6;
        private MaskedTextBox distanceTextBox;
        private Label label5;
        private ComboBox speedLimitComboBox;
        private Label label4;
        private MaskedTextBox roadNameTextBox;
        private Label label3;
        private TextBox point2TextBox;
        private GroupBox editFeatureGroupBox;
        private Label label1;
        private TextBox latitudeTextBox;
        private Label label2;
        private Label label9;
        private Label label10;
        private TextBox longitudeTextBox;
        private ComboBox featureTypeComboBox;
        private TextBox featureNameTextBox;
        private GroupBox searchGroupBox;
        private RadioButton roadRadioButton;
        private TextBox searchTextBox;
        private RadioButton featureRadioButton;
        private Button searchButton;
        private Button backButton;
        private Label label12;
        private Label label11;
    }
}