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

namespace RoadMapping
{
    public partial class AddFeatureForm : Form
    {
        private MapForm mapForm;
        private FormMethods formMethods;
        public AddFeatureForm()
        {
            InitializeComponent();
            formMethods = new FormMethods();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            //takes inputs as variables
            string featureName = featureNameTextBox.Text;
            string featureType = featureTypeComboBox.Text;
            string longitude = longitudeTextBox.Text;
            string latitude = latitudeTextBox.Text;

            string filename = formMethods.GetFeatureFile();
            string newString = $"{featureName}|{featureType}|{longitude}|{latitude}";

            //if longitude and latitude are in float format
            if (formMethods.IsFloat(longitude) == true && formMethods.IsFloat(latitude) == true)
            {
                //add to file
                using (StreamWriter sw = new StreamWriter(filename, true))
                {
                    sw.WriteLine(newString);
                }
                MessageBox.Show("Changes added successfully");
            }
            else
            {
                MessageBox.Show("Invalid details");
            }

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //opens a new MapForm           
            mapForm = new MapForm();
            mapForm.Show();
            this.Close();
        }
    }
}
