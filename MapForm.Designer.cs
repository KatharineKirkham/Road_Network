namespace RoadMapping
{
    partial class MapForm
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
            mainMenuStrip = new MenuStrip();
            selectRouteToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem = new ToolStripMenuItem();
            addRoadToolStripMenuItem = new ToolStripMenuItem();
            addFeatureToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            signOutToolStripMenuItem = new ToolStripMenuItem();
            point1TextBox = new TextBox();
            point2TextBox = new TextBox();
            quickestRouteListBox = new ListBox();
            selectRouteGroupBox = new GroupBox();
            searchButton = new Button();
            label2 = new Label();
            label1 = new Label();
            mainMenuStrip.SuspendLayout();
            selectRouteGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // mainMenuStrip
            // 
            mainMenuStrip.BackColor = SystemColors.GradientActiveCaption;
            mainMenuStrip.Dock = DockStyle.None;
            mainMenuStrip.Items.AddRange(new ToolStripItem[] { selectRouteToolStripMenuItem, addToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem, signOutToolStripMenuItem });
            mainMenuStrip.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            mainMenuStrip.Location = new Point(982, 0);
            mainMenuStrip.Name = "mainMenuStrip";
            mainMenuStrip.Padding = new Padding(6, 2, 6, 2);
            mainMenuStrip.Size = new Size(168, 370);
            mainMenuStrip.Stretch = false;
            mainMenuStrip.TabIndex = 0;
            mainMenuStrip.Text = "menuStrip1";
            // 
            // selectRouteToolStripMenuItem
            // 
            selectRouteToolStripMenuItem.BackColor = SystemColors.ActiveCaption;
            selectRouteToolStripMenuItem.Margin = new Padding(0, 20, 0, 0);
            selectRouteToolStripMenuItem.Name = "selectRouteToolStripMenuItem";
            selectRouteToolStripMenuItem.Padding = new Padding(40, 30, 40, 0);
            selectRouteToolStripMenuItem.Size = new Size(155, 49);
            selectRouteToolStripMenuItem.Text = "Select Route";
            selectRouteToolStripMenuItem.Click += selectRouteToolStripMenuItem_Click;
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.BackColor = SystemColors.ActiveCaption;
            addToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addRoadToolStripMenuItem, addFeatureToolStripMenuItem });
            addToolStripMenuItem.Margin = new Padding(0, 20, 0, 0);
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Padding = new Padding(40, 30, 40, 0);
            addToolStripMenuItem.Size = new Size(155, 49);
            addToolStripMenuItem.Text = "Add";
            // 
            // addRoadToolStripMenuItem
            // 
            addRoadToolStripMenuItem.Name = "addRoadToolStripMenuItem";
            addRoadToolStripMenuItem.Size = new Size(180, 22);
            addRoadToolStripMenuItem.Text = "Road";
            addRoadToolStripMenuItem.Click += addRoadToolStripMenuItem_Click;
            // 
            // addFeatureToolStripMenuItem
            // 
            addFeatureToolStripMenuItem.Name = "addFeatureToolStripMenuItem";
            addFeatureToolStripMenuItem.Size = new Size(180, 22);
            addFeatureToolStripMenuItem.Text = "Feature";
            addFeatureToolStripMenuItem.Click += addFeatureToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.BackColor = SystemColors.ActiveCaption;
            editToolStripMenuItem.Margin = new Padding(0, 20, 0, 0);
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Padding = new Padding(40, 30, 40, 0);
            editToolStripMenuItem.Size = new Size(155, 49);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.BackColor = SystemColors.ActiveCaption;
            deleteToolStripMenuItem.Margin = new Padding(0, 20, 0, 0);
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Padding = new Padding(40, 30, 40, 0);
            deleteToolStripMenuItem.Size = new Size(155, 49);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // signOutToolStripMenuItem
            // 
            signOutToolStripMenuItem.BackColor = SystemColors.ActiveCaption;
            signOutToolStripMenuItem.Margin = new Padding(0, 20, 0, 0);
            signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            signOutToolStripMenuItem.Padding = new Padding(40, 30, 40, 0);
            signOutToolStripMenuItem.Size = new Size(155, 49);
            signOutToolStripMenuItem.Text = "Sign out";
            signOutToolStripMenuItem.Click += signOutToolStripMenuItem_Click;
            // 
            // point1TextBox
            // 
            point1TextBox.Location = new Point(6, 34);
            point1TextBox.Name = "point1TextBox";
            point1TextBox.Size = new Size(150, 23);
            point1TextBox.TabIndex = 1;
            // 
            // point2TextBox
            // 
            point2TextBox.Location = new Point(6, 78);
            point2TextBox.Name = "point2TextBox";
            point2TextBox.Size = new Size(150, 23);
            point2TextBox.TabIndex = 2;
            // 
            // quickestRouteListBox
            // 
            quickestRouteListBox.BackColor = SystemColors.GradientActiveCaption;
            quickestRouteListBox.FormattingEnabled = true;
            quickestRouteListBox.ItemHeight = 15;
            quickestRouteListBox.Location = new Point(6, 136);
            quickestRouteListBox.Name = "quickestRouteListBox";
            quickestRouteListBox.Size = new Size(156, 244);
            quickestRouteListBox.TabIndex = 3;
            // 
            // selectRouteGroupBox
            // 
            selectRouteGroupBox.BackColor = SystemColors.GradientActiveCaption;
            selectRouteGroupBox.Controls.Add(searchButton);
            selectRouteGroupBox.Controls.Add(label2);
            selectRouteGroupBox.Controls.Add(quickestRouteListBox);
            selectRouteGroupBox.Controls.Add(label1);
            selectRouteGroupBox.Controls.Add(point1TextBox);
            selectRouteGroupBox.Controls.Add(point2TextBox);
            selectRouteGroupBox.Location = new Point(984, 354);
            selectRouteGroupBox.Name = "selectRouteGroupBox";
            selectRouteGroupBox.Size = new Size(162, 401);
            selectRouteGroupBox.TabIndex = 4;
            selectRouteGroupBox.TabStop = false;
            selectRouteGroupBox.Visible = false;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(37, 107);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 23);
            searchButton.TabIndex = 5;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 60);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 5;
            label2.Text = "End point:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 16);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 5;
            label1.Text = "Start point:";
            // 
            // MapForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1146, 761);
            Controls.Add(selectRouteGroupBox);
            Controls.Add(mainMenuStrip);
            MainMenuStrip = mainMenuStrip;
            Name = "MapForm";
            Text = "Map";
            Paint += MapForm_Paint;
            mainMenuStrip.ResumeLayout(false);
            mainMenuStrip.PerformLayout();
            selectRouteGroupBox.ResumeLayout(false);
            selectRouteGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mainMenuStrip;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private MenuStrip addMenuStrip;
        private ToolStripMenuItem enterPointToolStripMenuItem;
        private ComboBox comboBox1;
        private ToolStripMenuItem selectRouteToolStripMenuItem;
        private ToolStripMenuItem addRoadToolStripMenuItem;
        private ToolStripMenuItem addFeatureToolStripMenuItem;
        private ToolStripMenuItem signOutToolStripMenuItem;
        private TextBox point1TextBox;
        private TextBox point2TextBox;
        private ListBox quickestRouteListBox;
        private GroupBox selectRouteGroupBox;
        private Label label2;
        private Label label1;
        private Button searchButton;
    }
}