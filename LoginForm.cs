using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Text;
using System.Text.RegularExpressions;

namespace RoadMapping
{
    public partial class LoginForm : Form
    {
        private MapForm mapForm;
        private string fileName;

        public LoginForm()
        {
            InitializeComponent();
            newAccountGroupBox.Visible = false;
            fileName = Path.Combine(AppContext.BaseDirectory,"Data","AccountList.txt");
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string userInput = username + password;

            if (CheckPassword(userInput))
            {
                //opens the map form
                mapForm = new MapForm();
                if (Application.OpenForms.OfType<MapForm>().Count() == 0)
                {
                    mapForm = new MapForm();
                    mapForm.Show();
                }
                else
                {
                    mapForm.Focus();
                }

                //hides the login form
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Invalid details.");
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            string username = newUsernameTextBox.Text;
            string password = newPasswordTextBox.Text;

            //if input validation requirements are met, add the new username and password to the file
            if (InputValidation(username, password) == true)
            {
                AddToAccounts(username, password);
            }
        }

        private void newAccountButton_Click(object sender, EventArgs e)
        {
            newAccountGroupBox.Visible = true;
        }

        //a function which returns true if username and password are in accounts file
        private bool CheckPassword(string userInput)
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line == userInput)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        
        //a functions which returns true if input validation requirements are met
        private bool InputValidation(string username, string password)
        {
            bool requirementsMet = false;

            Regex hasNumber = new Regex(@"[0-9]+");
            Regex hasUpperChar = new Regex(@"[A-Z]+");
            Regex hasLowerChar = new Regex(@"[a-z]+");

            if (!hasUpperChar.IsMatch(password))
            {
                MessageBox.Show("Password should contain at least one uppercase and lowercase letter.");
            }
            else if (!hasLowerChar.IsMatch(password))
            {
                MessageBox.Show("Password should contain at least one uppercase and lowercase letter.");
            }
            else if (!hasNumber.IsMatch(password))
            {
                MessageBox.Show("Password should contain a mix of letters and numbers.");
            }
            else if (password.Length < 8 || password.Length > 20)
            {
                MessageBox.Show("Password should be between 8 and 20 characters long.");
            }
            else if (username.Length < 8 || username.Length > 20)
            {
                MessageBox.Show("Password should be between 8 and 20 characters long.");
            }
            //if the username and password meet input validation requirements
            else
            {
                requirementsMet = true;
            }

            return requirementsMet;
        }

        //a procedure which adds the new username and password to the file
        private void AddToAccounts(string username, string password)
        {
            using (StreamWriter sw = new StreamWriter(fileName, true))
            {
                sw.WriteLine(username + password);
            }
            MessageBox.Show("New account created");
        }
    }
}