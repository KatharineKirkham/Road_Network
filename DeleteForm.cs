using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoadMapping
{
    public partial class DeleteForm : Form
    {
        private MapForm mapForm;
        private FormMethods formMethods;
        public DeleteForm()
        {
            InitializeComponent();
            formMethods = new FormMethods();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            string roadFilename = formMethods.GetRoadFile();
            string featureFilename = formMethods.GetFeatureFile();
            List<string> roadList = formMethods.GetRoadList();
            List<string> featureList = formMethods.GetFeatureList();
            string itemToDelete = deleteTextBox.Text;

            if (roadRadioButton.Checked)
            {
                //if the road is not in the roadList, displays error message
                if (formMethods.SearchInList(roadList, itemToDelete) == null)
                {
                    MessageBox.Show("Road does not exist.");
                    return;
                }

                //deleting road from list and file
                formMethods.DeleteFromList(roadList, itemToDelete);
                formMethods.OverwriteFile(roadFilename, roadList);
                
                MessageBox.Show("Changes saved successfully");

            }
            else if (featureRadioButton.Checked)
            {
                //if the feature is not in the featureList, displays error message
                if (formMethods.SearchInList(featureList, itemToDelete) == null)
                {
                    MessageBox.Show("Feature does not exist.");
                    return;
                }

                //deleting connected roads to node
                DeleteConnectedRoads(roadList, itemToDelete);
                formMethods.OverwriteFile(roadFilename, roadList);

                //deleting feature from list and file
                formMethods.DeleteFromList(featureList, itemToDelete);
                formMethods.OverwriteFile(featureFilename, featureList);
                
                MessageBox.Show("Changes saved successfully");
            }
            else
            {
                //if neither radio button is selected
                MessageBox.Show("Please select either a road or feature");
                return;
            }
        }

        //a function to delete the roads which contain the specific node within
        private void DeleteConnectedRoads(List<string> list, string node)
        {
            //going through each line in list
            foreach (string line in list.ToList())
            {
                string[] lineInfo = line.Split("|");
                //if the road contains the name of the node as an endpoint
                if (lineInfo[1] == node || lineInfo[2] == node)
                {
                    list.Remove(line);
                }
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
