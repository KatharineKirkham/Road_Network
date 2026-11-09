using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using RoadMapping;

namespace RoadMapping
{
    public partial class AddRoadForm : Form
    {
        private MapForm mapForm;
        private FormMethods formMethods;
        public AddRoadForm()
        {
            InitializeComponent();
            formMethods = new FormMethods();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            List<string> featureList = formMethods.GetFeatureList();
            string filename = formMethods.GetRoadFile();
            string roadName = roadNameTextBox.Text;

            //need to check point names are equal to node names
            string point1 = point1TextBox.Text;
            string point2 = point2TextBox.Text;

            string speedLimit = speedLimitComboBox.Text;
            string distance = distanceTextBox.Text;

            string roadType = roadTypeComboBox.Text;
            string notes = notesTextBox.Text;

            //if points are valid nodes, and distance is in float format
            if (formMethods.SearchInList(featureList, point1) != null && formMethods.SearchInList(featureList, point2) != null &&
                formMethods.IsFloat(distance))
            {
                //works out the estimated time 
                string roadTime = Convert.ToString(formMethods.RoadTimeEstimate(distance, speedLimit));

                string newString = $"{roadName}|{point1}|{point2}|{speedLimit}|{distance}|{roadTime}|{roadType}|{notes}";

                //adds it to the road file
                using (StreamWriter sw = new StreamWriter(filename, true))
                {
                    sw.WriteLine(newString);
                }
                MessageBox.Show("Changes added successfully");
            }
            else
            {
                MessageBox.Show("Invalid details.");
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //opens a new mapForm
            mapForm = new MapForm();
            mapForm.Show();
            this.Close();
        }
    }
}