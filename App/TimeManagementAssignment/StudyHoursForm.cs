using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeManagementAssignment
{
    public partial class StudyHoursForm : Form
    {
        public static string  PassingWeeklyhours;
        public StudyHoursForm()
        {
            InitializeComponent();
        }

        private void ActivitiesButton_Click(object sender, EventArgs e)
        {
            //FUNC: Hide the controls and capture the window screen
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;   //Hide the border
            activitiesButton.Visible = false;
            redoPanel.Visible = false;
            Bitmap studyHoursPicture = new Bitmap(this.Width, this.Height);
            DrawToBitmap(studyHoursPicture, new Rectangle(0, 0, studyHoursPicture.Width, studyHoursPicture.Height));
            studyHoursPicture.Save("C:\\Users\\Public\\Downloads\\studyHoursPicture.bmp", ImageFormat.Bmp);
          //  MessageBox.Show("Captured");

            //Go to Activity-A Form
            this.Hide();
            ActivityAForm openActivityA = new ActivityAForm();
            openActivityA.ShowDialog();
        }

        private void RedoButton_Click(object sender, EventArgs e)
        {
            //Go back to Begin Assignment Form
            //Clear existing text boxes
            moduleCode1.Text = "";
            credits1.Text = "";
            notLrnHrs1.Text = "";
            hrsPerWeek1.Text = "";

            moduleCode2.Text = "";
            credits2.Text = "";
            notLrnHrs2.Text = "";
            hrsPerWeek2.Text = "";

            moduleCode3.Text = "";
            credits3.Text = "";
            notLrnHrs3.Text = "";
            hrsPerWeek3.Text = "";

            moduleCode4.Text = "";
            credits4.Text = "";
            notLrnHrs4.Text = "";
            hrsPerWeek4.Text = "";

            moduleCode5.Text = "";
            credits5.Text = "";
            notLrnHrs5.Text = "";
            hrsPerWeek5.Text = "";

            moduleCode6.Text = "";
            credits6.Text = "";
            notLrnHrs6.Text = "";
            hrsPerWeek6.Text = "";

            moduleCode7.Text = "";
            credits7.Text = "";
            notLrnHrs7.Text = "";
            hrsPerWeek7.Text = "";
            //Clear passing variables
            ModulesForm.passingM1Code = "";
            ModulesForm.passingM2Code = "";
            ModulesForm.passingM3Code = "";
            ModulesForm.passingM4Code = "";
            ModulesForm.passingM5Code = "";
            ModulesForm.passingM6Code = "";
            ModulesForm.passingM7Code = "";
            this.Hide();
            ModulesForm openBeginAssgnmnt = new ModulesForm();
            openBeginAssgnmnt.ShowDialog();
        }

        private void StudyHoursForm_Load(object sender, EventArgs e)
        {
            //Passing student details
            nameLabel.Text = MainMenuForm.passingName.ToString();
            surnameLabel.Text = MainMenuForm.passingSurname.ToString();
            stdNmbrLabel.Text = MainMenuForm.passingStdNmbr.ToString();

            //Passing Module1 Information
            moduleCode1.Text = ModulesForm.passingM1Code.ToString();
            credits1.Text = ModulesForm.passingM1Cred.ToString();
            notLrnHrs1.Text = ModulesForm.passingM1Not.ToString();
            hrsPerWeek1.Text = ModulesForm.passingM1WklyHrs.ToString();

            //Passing Module2 Information
            moduleCode2.Text = ModulesForm.passingM2Code.ToString();
            credits2.Text = ModulesForm.passingM2Cred.ToString();
            notLrnHrs2.Text = ModulesForm.passingM2Not.ToString();
            hrsPerWeek2.Text = ModulesForm.passingM2WklyHrs.ToString();

            /*
            if (String.IsNullOrEmpty(stdNmbrLabel.Text.ToString()) == false)
               
            
                    nameLabel.Visible = true;
                    surnameLabel.Visible = true;
            stdNmbrLabel.Visible = true;             
                //Passing Module1 Information
            */  
            
            
            //Passing Module3 Information
            moduleCode3.Text = ModulesForm.passingM3Code.ToString();
            credits3.Text = ModulesForm.passingM3Cred.ToString();
            notLrnHrs3.Text = ModulesForm.passingM3Not.ToString();
            hrsPerWeek3.Text = ModulesForm.passingM3WklyHrs.ToString();

            //Passing Module4 Information
            moduleCode4.Text = ModulesForm.passingM4Code.ToString();
            credits4.Text = ModulesForm.passingM4Cred.ToString();
            notLrnHrs4.Text = ModulesForm.passingM4Not.ToString();
            hrsPerWeek4.Text = ModulesForm.passingM4WklyHrs.ToString();

            //Passing Module5 Information
            moduleCode5.Text = ModulesForm.passingM5Code.ToString();
            credits5.Text = ModulesForm.passingM5Cred.ToString();
            notLrnHrs5.Text = ModulesForm.passingM5Not.ToString();
            hrsPerWeek5.Text = ModulesForm.passingM5WklyHrs.ToString();

            //Passing Module6 Information
            moduleCode6.Text = ModulesForm.passingM6Code.ToString();
            credits6.Text = ModulesForm.passingM6Cred.ToString();
            notLrnHrs6.Text = ModulesForm.passingM6Not.ToString();
            hrsPerWeek6.Text = ModulesForm.passingM6WklyHrs.ToString();

            //Passing Module7 Information
            moduleCode7.Text = ModulesForm.passingM7Code.ToString();
            credits7.Text = ModulesForm.passingM7Cred.ToString();
            notLrnHrs7.Text = ModulesForm.passingM7Not.ToString();
            hrsPerWeek7.Text = ModulesForm.passingM7WklyHrs.ToString();

            //Passing Student Information from MainMenu FOrm
            if (moduleCode1.Text == "00000000")
            {
                moduleCode1.Visible = false;
                credits1.Visible = false;
                notLrnHrs1.Visible = false;
                hrsPerWeek1.Visible = false;
            }
            if (moduleCode2.Text == "00000000")
            {
                moduleCode2.Visible = false;
                credits2.Visible = false;
                notLrnHrs2.Visible = false;
                hrsPerWeek2.Visible = false;
            }

            if (moduleCode3.Text == "00000000")
            {
                moduleCode3.Visible = false;
                credits3.Visible = false;
                notLrnHrs3.Visible = false;
                hrsPerWeek3.Visible = false;
            }

            if (moduleCode4.Text == "00000000")
            {
                moduleCode4.Visible = false;
                credits4.Visible = false;
                notLrnHrs4.Visible = false;
                hrsPerWeek4.Visible = false;
            }

            if (moduleCode5.Text == "00000000")
            {
                moduleCode5.Visible = false;
                credits5.Visible = false;
                notLrnHrs5.Visible = false;
                hrsPerWeek5.Visible = false;
            }

            if (moduleCode6.Text == "00000000")
            {
                moduleCode6.Visible = false;
                credits6.Visible = false;
                notLrnHrs6.Visible = false;
                hrsPerWeek6.Visible = false;
            }

            if (moduleCode7.Text == "00000000")
            {
                moduleCode7.Visible = false;
                credits7.Visible = false;
                notLrnHrs7.Visible = false;
                hrsPerWeek7.Visible = false;
            }

            //Display total study hours per week
            totalWeeklyHours.Text = ModulesForm.totalWeeklyHours.ToString();
            PassingWeeklyhours = totalWeeklyHours.Text;
            //Error Handling of incorrect semester code entry
            /*
            if (BeginAssignmentForm.passingSemester1 >= 1 & BeginAssignmentForm.passingSemester1 <= 9)
            {
                activitiesButton.Visible = true;
            }
            else
            { 
                MessageBox.Show("The Module code " + BeginAssignmentForm.passingM1Code + " is typed incorrectly, please click redo");
                activitiesButton.Visible = false;
            }

            if (BeginAssignmentForm.passingSemester2 >= 1 & BeginAssignmentForm.passingSemester2 <= 9)
            {
                activitiesButton.Visible = true;
            }
            else
            { 
                MessageBox.Show("The Module code " + BeginAssignmentForm.passingM2Code + " is typed incorrectly, please click redo");
                activitiesButton.Visible = false;
            }

            if (BeginAssignmentForm.passingSemester3 >= 1 & BeginAssignmentForm.passingSemester3 <= 9)
            {
                activitiesButton.Visible = true;
            }
            else
            { 
                MessageBox.Show("The Module code " + BeginAssignmentForm.passingM3Code + " is typed incorrectly, please click redo");
                activitiesButton.Visible = false;
            }

            if (BeginAssignmentForm.passingSemester4 >= 1 & BeginAssignmentForm.passingSemester4 <= 9)
            {
                activitiesButton.Visible = true;
            }
            else
            { 
                MessageBox.Show("The Module code " + BeginAssignmentForm.passingM4Code + " is typed incorrectly, please click redo");
                activitiesButton.Visible = false;
            }

            if (BeginAssignmentForm.passingSemester5 >= 1 & BeginAssignmentForm.passingSemester5 <= 9)
            {
                activitiesButton.Visible = true;
            }
            else
            {                
                MessageBox.Show("The Module code " + BeginAssignmentForm.passingM5Code + " is typed incorrectly, please click redo");
                activitiesButton.Visible = false;
            }

            if (BeginAssignmentForm.passingSemester6 >= 1 & BeginAssignmentForm.passingSemester6 <= 9)
            {
                activitiesButton.Visible = true;
            }
            else
            { 
                MessageBox.Show("The Module code " + BeginAssignmentForm.passingM6Code + " is typed incorrectly, please click redo");
                activitiesButton.Visible = false;
            }

            if (BeginAssignmentForm.passingSemester7 >= 1 & BeginAssignmentForm.passingSemester7 <= 9)
            {
                activitiesButton.Visible = true;
            }
            else
            { 
                MessageBox.Show("The Module code " + BeginAssignmentForm.passingM7Code + " is typed incorrectly, please click redo");
                activitiesButton.Visible = false;
            }
            */
            //Error Handling of incorrect module code entry
            if (hrsPerWeek1.Text == "0")
            {
                MessageBox.Show("The First module code " + ModulesForm.passingM1Code + " is typed incorrectly, please click Redo");
                activitiesButton.Visible = false;
            }
            if (hrsPerWeek2.Text == "0")
            {
                if (hrsPerWeek2.Visible == true)
                {
                    MessageBox.Show("The Second module code " + ModulesForm.passingM2Code + " is typed incorrectly, please click Redo");
                    activitiesButton.Visible = false;
                }
            }
            if (hrsPerWeek3.Text == "0")
            {
                if (hrsPerWeek3.Visible == true)
                {
                    MessageBox.Show("The Third module code " + ModulesForm.passingM3Code + " is typed incorrectly, please click Redo");
                    activitiesButton.Visible = false;
                }
            }
            if (hrsPerWeek4.Text == "0")
            {
                if (hrsPerWeek4.Visible == true)
                {
                    MessageBox.Show("The Fourth module code " + ModulesForm.passingM4Code + " is typed incorrectly, please click Redo");
                    activitiesButton.Visible = false;
                }
            }
            if (hrsPerWeek5.Text == "0")
            {
                if (hrsPerWeek5.Visible == true)
                {
                    MessageBox.Show("The Fifth module code " + ModulesForm.passingM5Code + " is typed incorrectly, please click Redo");
                    activitiesButton.Visible = false;
                }
            }
            if (hrsPerWeek6.Text == "0")
            {
                if (hrsPerWeek6.Visible == true)
                {
                    MessageBox.Show("The Sixth module code " + ModulesForm.passingM6Code + " is typed incorrectly, please click Redo");
                    activitiesButton.Visible = false;
                }
            }
            if (hrsPerWeek7.Text == "0")
            {
                if (hrsPerWeek7.Visible == true)
                {
                    MessageBox.Show("The Seventh module code " + ModulesForm.passingM7Code + " is typed incorrectly, please click Redo");

                }
            }
            /*
            if (String.IsNullOrEmpty(moduleCode1.Text.ToString()) == false)
            {
                moduleCode1.Visible = true;
                credits1.Visible = true;
                notLrnHrs1.Visible = true;
            }
            */
            /*
            if (String.IsNullOrEmpty(moduleCode2.Text) == false)
            {
                moduleCode2.Visible = true;
                credits2.Visible = true;
                notLrnHrs2.Visible = true;
            }
            */
        }
    }
}
