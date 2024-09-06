using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeManagementAssignment
{
    public partial class MainMenuForm : Form
    {
        // Declaring public variable to pass this Form information to another
        public static string passingName, passingSurname, passingStdNmbr;

        public MainMenuForm()
        {
            InitializeComponent();
        }

        //Go to the Assingment Window
        //BUTTON: Begin
        private void BeginButton_Click(object sender, EventArgs e)
        {

            //Declaring Name and Surname variables
            string name = nameTextBox.Text;
            string surname = surnameTextBox.Text.ToString();
            string studentNumber = stdNmbrTextBox.Text.ToString();
            
            //Validate the length of the Student Number input
            //When student number is empty
            if (stdNmbrTextBox.TextLength == 0)
            {
                MessageBox.Show("Student number cannot be empty.", "Empty Student Number:");
            }
            //When student number characters are less than 10
            else if (stdNmbrTextBox.TextLength < 10)
            {
                MessageBox.Show("The student number must be 10-digit numbers only.", "Short Student Number:");
            }
            //When student number characters are greater than 10
            else if (stdNmbrTextBox.TextLength > 10)
            {
                MessageBox.Show("Please input your 10-digits UFS student number.", "Long Student Number:");
            }
            //When the lenght is correct [10 digits], validate the Student Number
            else 
            {
                Int32.TryParse(studentNumber[0].ToString(), out int stdNum1stChar);   //Get student number first character
                Int32.TryParse(studentNumber[1].ToString(), out int stdNum2ndChar);   //Get student number first character

                //VALIDATE: The 10-digit student number
                if ((stdNum1stChar == 1 & stdNum2ndChar == 9) | (stdNum1stChar == 2 & stdNum2ndChar == 0))
                {
                    //Handle variables to be passed to other forms
                    passingName = name.ToUpper();
                    passingSurname = surname.ToUpper();
                    passingStdNmbr = studentNumber;

                    //Open Begin Assignment Form
                    this.Hide();
                    ModulesForm openAsstForm = new ModulesForm();
                    openAsstForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Your student number " + studentNumber + " is invalid... \nPlease enter the correct student number.", "Invalid Student Number:");
                }
                //END OF VALIDATE

            }
            /*
            passingName = name.ToUpper();
            passingSurname = surname.ToUpper();
            passingStdNmbr = studentNumber;
            
            if (stdNmbrTextBox.Text == "")
            {
                MessageBox.Show("Please insert a student number");
                stdNmbrTextBox.Select();
            }
            else
            {
                //Open Begin Assignment Form
                this.Hide();
                ModulesForm openAsstForm = new ModulesForm();
                openAsstForm.ShowDialog();
            }
            */

        }   //END: Button Begin

        private void nameTextBox_Leave(object sender, EventArgs e)
        {
            //condition for text box and rubric button click
            if (nameTextBox.Text == "")
            {
                MessageBox.Show("Please insert a Name first");
                nameTextBox.Select();
            }
            else
            {
                nameTextBox.Text = char.ToUpper(nameTextBox.Text[0]).ToString() + nameTextBox.Text.ToString().Substring(1);
                surnameTextBox.Select();
            }
            
        }

        private void surnameTextBox_Leave(object sender, EventArgs e)
        {
            if (surnameTextBox.Text == "")
            {
                MessageBox.Show("Please insert a Surname first");
                surnameTextBox.Select();
            }
            else
            {
                surnameTextBox.Text = char.ToUpper(surnameTextBox.Text[0]).ToString() + surnameTextBox.Text.ToString().Substring(1);
                stdNmbrTextBox.Select();
            }

        }

        //HANDLES: Force user to type certain keys only
        //Force the user to type alphabets only on Name textbox
        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
            
        }
        //Force the user to type alphabets only on Surname textbox
        private void surnameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
            
        }
        //Force the user to type numbers only on Student Number textbox
        private void stdNmbrTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
            
        }
        //END OF HANDLES

        //Upon loading the page, send cursor to Name textbox
        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            nameTextBox.Select();
        }
        
    }
}
