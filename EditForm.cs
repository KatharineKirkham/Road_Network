using RoadMapping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoadMapping
{
    public partial class EditForm : Form
    {
        private MapForm mapForm;
        private FormMethods formMethods;
        private List<string> featureList;
        private List<string> roadList;
        private string roadFileName;
        private string featureFileName;
        private string search;
        
        public EditForm()
        {
            InitializeComponent();
            formMethods = new FormMethods();

            editFeatureGroupBox.Visible = false;
            editRoadGroupBox.Visible = false;
            updateButton.Visible = false;

            featureList = formMethods.GetFeatureList();
            roadList = formMethods.GetRoadList();
            roadFileName = formMethods.GetRoadFile();
            featureFileName = formMethods.GetFeatureFile();

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            search = searchTextBox.Text;
            string filename;
            string[] searchInfo;
            List<string> list;

            if (roadRadioButton.Checked)
            {
                filename = roadFileName;
                list = roadList;
                searchInfo = formMethods.SearchInList(list, search);

                //if search couldn't be found
                if (searchInfo == null)
                {
                    MessageBox.Show("Item couldn't be found");
                    return;
                }

                editRoadGroupBox.Visible = true;
                updateButton.Visible = true;
                //inserting information in road group box
                roadNameTextBox.Text = searchInfo[0];
                point1TextBox.Text = searchInfo[1];
                point2TextBox.Text = searchInfo[2];
                speedLimitComboBox.Text = searchInfo[3];
                distanceTextBox.Text = searchInfo[4];
                //road timing goes here
                roadTypeComboBox.Text = searchInfo[6];
                notesTextBox.Text = searchInfo[7];

            }

            else if (featureRadioButton.Checked)
            {
                filename = featureFileName;
                list = featureList;
                searchInfo = formMethods.SearchInList(list, search);

                //if search couldn't be found
                if (searchInfo == null)
                {
                    MessageBox.Show("Item couldn't be found");
                    return;
                }

                editFeatureGroupBox.Visible = true;
                updateButton.Visible = true;
                //inserting information in feature group box
                featureNameTextBox.Text = searchInfo[0];
                featureTypeComboBox.Text = searchInfo[1];
                longitudeTextBox.Text = searchInfo[2];
                latitudeTextBox.Text = searchInfo[3];
            }
            //if neither radio button selected
            else
            {
                MessageBox.Show("Please select one of the options");
                return;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string filename;
            List<string> editList;
            string newString = "";
            string newItemName;
            bool validDetails = false;

            if (roadRadioButton.Checked)
            {
                //takes input as variables
                newItemName = roadNameTextBox.Text;

                string point1 = point1TextBox.Text;
                string point2 = point2TextBox.Text;

                string speedLimit = speedLimitComboBox.Text;
                string distance = distanceTextBox.Text;

                string roadType = roadTypeComboBox.Text;
                string notes = notesTextBox.Text;

                editList = roadList;
                filename = roadFileName;

                //if points are valid nodes, and distance is in float format
                if (formMethods.SearchInList(featureList, point1) != null && formMethods.SearchInList(featureList, point2)
                    != null && formMethods.IsFloat(distance))
                {
                    validDetails = true;

                    //works out the estimated time
                    string roadTime = Convert.ToString(formMethods.RoadTimeEstimate(distance, speedLimit));
                    newString = $"{newItemName}|{point1}|{point2}|{speedLimit}|{distance}|{roadTime}|{roadType}|{notes}";
                }

            }
            else if (featureRadioButton.Checked)
            {
                //takes inputs as variables
                newItemName = featureNameTextBox.Text;

                string featureType = featureTypeComboBox.Text;
                string longitude = longitudeTextBox.Text;
                string latitude = latitudeTextBox.Text;

                editList = featureList;
                filename = featureFileName;
                newString = $"{newItemName}|{featureType}|{longitude}|{latitude}";

                if (formMethods.IsFloat(longitude) == true && formMethods.IsFloat(latitude) == true)
                {
                    validDetails = true;
                }

            }
            else
            {
                editList = null;
                filename = null;
                newItemName = null;
                return;
            }

            //if passed input validation
            if (validDetails)
            {
                //delete from list
                formMethods.DeleteFromList(editList, search);

                //adds the new string to the list
                editList.Add(newString);
                formMethods.OverwriteFile(filename, editList);
                MessageBox.Show("Changes added successfully");
            }
            else
            {
                MessageBox.Show("Invalid details");
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            mapForm = new MapForm();
            mapForm.Show();
            this.Close();
        }
    }
}
