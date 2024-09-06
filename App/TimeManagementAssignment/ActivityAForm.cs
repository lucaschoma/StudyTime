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
using static System.Windows.Forms.DomainUpDown;

namespace TimeManagementAssignment
{
    public partial class ActivityAForm : Form
    {
        public static double PassingclassA;
        public static double PassingMinutesA;
        public static double PassingMinutesAndHours;
        public ActivityAForm()
        {
            InitializeComponent();
            activityA1.SelectedIndex = -1;
        }

        //Global variables
        public static class Globals
        {
            public static Int32 totalMinutes = 0;
            public static Int32 totalHours = 0;
        }

        //  Next Button: performs a screen capture, create and/or update or insert data into the database, 
        // then open the next form
        private void NextButton_Click(object sender, EventArgs e)
        {
            //Hide the controls and capture the window screen
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;   //Hide the border
            nextButton.Visible = false;
            backButton.Visible = false;
            Bitmap activityAPicture = new Bitmap(this.Width, this.Height);
            DrawToBitmap(activityAPicture, new Rectangle(0, 0, activityAPicture.Width, activityAPicture.Height));
            activityAPicture.Save("C:\\Users\\Public\\Downloads\\activityA-Picture.bmp", ImageFormat.Bmp);
            // MessageBox.Show("Captured");

            // TO DO: Store the activities hours and minutes in a database


            //Go to Activity B Form
            PassingclassA = double.Parse(hoursValue.Text);
            PassingMinutesA = double.Parse(minutesValue.Text);
            PassingMinutesAndHours = Math.Round(7*(PassingclassA + (PassingMinutesA / 60)),0);

           // MessageBox.Show(PassingMinutesAndHours.ToString());

            ActivityBForm openActivityB = new ActivityBForm();
            openActivityB.Show();
            Visible = false;
            
        }

        //  Back Button: opens the previous form
        private void BackButton_Click(object sender, EventArgs e)
        {
            //Go back to Activity B Form
            StudyHoursForm openStudyHours = new StudyHoursForm();
            openStudyHours.Show();
            Visible = false;
        }

        //START: Class A, Activity 1
        private void ActivityA1_SelectedItemChanged(object sender, EventArgs e)
        {
            //Store and display the selected option value from the activities (A1) UpDownDomain
            int activityA1Index = this.activityA1.SelectedIndex;
            string activityA1Selection = this.activityA1.Items[activityA1Index].ToString();
        }

        private void HoursA1_ValueChanged(object sender, EventArgs e)
        {
            //Store and display the selected option value from the hours (A1) UpDownDomain
            object hoursA1Value = (hoursA1.Value + hoursA2.Value + hoursA3.Value + hoursA4.Value + hoursA5.Value +
                hoursA6.Value + hoursA7.Value).ToString();
            hoursValue.Text = hoursA1Value.ToString();
        }

        private void MinutesA1_ValueChanged(object sender, EventArgs e)
        {
            //Store and display the numeric value from the minutes (A1) numericDomain
            object minutesA1Value = (minutesA1.Value + minutesA2.Value + minutesA3.Value + minutesA4.Value
                + minutesA5.Value + minutesA6.Value + minutesA7.Value).ToString();
            minutesValue.Text = minutesA1Value.ToString();           
            
        }
        //END: Class A, Activity 1

        //START: Class A, Activity 2
        private void ActivityA2_SelectedItemChanged(object sender, EventArgs e)
        {
            //Store and display the selected option value from the activities (A1) UpDownDomain
            int activityA2Index = this.activityA2.SelectedIndex;
            string activityA2Selection = this.activityA2.Items[activityA2Index].ToString();
        }
        private void HoursA2_ValueChanged(object sender, EventArgs e)
        {
            //Store and display the selected option value from the hours (A1) UpDownDomain
            object hoursA2Value = (hoursA1.Value + hoursA2.Value + hoursA3.Value + hoursA4.Value + hoursA5.Value +
                hoursA6.Value + hoursA7.Value).ToString();
            hoursValue.Text = hoursA2Value.ToString();
        }

        private void MinutesA2_ValueChanged(object sender, EventArgs e)
        {
            //Store and display the numeric value from the minutes (A1) numericDomain
            object minutesA2Value = (minutesA1.Value + minutesA2.Value + minutesA3.Value + minutesA4.Value
                + minutesA5.Value + minutesA6.Value + minutesA7.Value).ToString();
            minutesValue.Text = minutesA2Value.ToString();
            
        }
        //END: Class A, Activity 2

        //START: Class A, Activity 3
        private void ActivityA3_SelectedItemChanged(object sender, EventArgs e)
        {
            //Store and display the selected option value from the activities (A1) UpDownDomain
            int activityA3Index = this.activityA3.SelectedIndex;
            string activityA3Selection = this.activityA3.Items[activityA3Index].ToString();
        }

        private void HoursA3_ValueChanged(object sender, EventArgs e)
        {
            //Store and display the selected option value from the hours (A1) UpDownDomain
            object hoursA3Value = (hoursA1.Value + hoursA2.Value + hoursA3.Value + hoursA4.Value + hoursA5.Value +
                hoursA6.Value + hoursA7.Value).ToString();
            hoursValue.Text = hoursA3Value.ToString();
        }

        private void MinutesA3_ValueChanged(object sender, EventArgs e)
        {
            //Store and display the numeric value from the minutes (A1) numericDomain
            object minutesA3Value = (minutesA1.Value + minutesA2.Value + minutesA3.Value + minutesA4.Value
                + minutesA5.Value + minutesA6.Value + minutesA7.Value).ToString();
            minutesValue.Text = minutesA3Value.ToString();
            
        }
        //END: Class A, Activity 3

        //START: Class A, Activity 4
        private void ActivityA4_SelectedItemChanged(object sender, EventArgs e)
        {
            //Store and display the selected option value from the activities (A1) UpDownDomain
            int activityA4Index = this.activityA4.SelectedIndex;
            string activityA4Selection = this.activityA4.Items[activityA4Index].ToString();
        }

        private void HoursA4_ValueChanged(object sender, EventArgs e)
        {
            //Store and display the selected option value from the hours (A1) UpDownDomain
            object hoursA4Value = (hoursA1.Value + hoursA2.Value + hoursA3.Value + hoursA4.Value + hoursA5.Value +
                hoursA6.Value + hoursA7.Value).ToString();
            hoursValue.Text = hoursA4Value.ToString();
        }

        private void MinutesA4_ValueChanged(object sender, EventArgs e)
        {
            //Store and display the numeric value from the minutes (A1) numericDomain
            object minutesA4Value = (minutesA1.Value + minutesA2.Value + minutesA3.Value + minutesA4.Value
                + minutesA5.Value + minutesA6.Value + minutesA7.Value).ToString();
            minutesValue.Text = minutesA4Value.ToString();
            
        }
        //END: Class A, Activity 4

        //START: Class A, Activity 5
        private void ActivityA5_SelectedItemChanged(object sender, EventArgs e)
        {
            //Store and display the selected option value from the activities (A1) UpDownDomain
            int activityA5Index = this.activityA5.SelectedIndex;
            string activityA5Selection = this.activityA5.Items[activityA5Index].ToString();
        }
        
        private void HoursA5_ValueChanged(object sender, EventArgs e)
        {
            //Store and display the selected option value from the hours (A1) UpDownDomain
            object hoursA5Value = (hoursA1.Value + hoursA2.Value + hoursA3.Value + hoursA4.Value + hoursA5.Value +
                hoursA6.Value + hoursA7.Value).ToString();
            hoursValue.Text = hoursA5Value.ToString();
        }

        private void MinutesA5_ValueChanged(object sender, EventArgs e)
        {
            //Store and display the numeric value from the minutes (A1) numericDomain
            object minutesA5Value = (minutesA1.Value + minutesA2.Value + minutesA3.Value + minutesA4.Value
                + minutesA5.Value + minutesA6.Value + minutesA7.Value).ToString();
            minutesValue.Text = minutesA5Value.ToString();
            
        }
        //END: Class A, Activity 5

        //START: Class A, Activity 6
        private void ActivityA6_SelectedItemChanged(object sender, EventArgs e)
        {
            //Store and display the selected option value from the activities (A1) UpDownDomain
            int activityA6Index = this.activityA6.SelectedIndex;
            string activityA6Selection = this.activityA6.Items[activityA6Index].ToString();
        }
        private void HoursA6_ValueChanged(object sender, EventArgs e)
        {
            //Store and display the selected option value from the hours (A1) UpDownDomain
            object hoursA6Value = (hoursA1.Value + hoursA2.Value + hoursA3.Value + hoursA4.Value + hoursA5.Value +
                hoursA6.Value + hoursA7.Value).ToString();
            hoursValue.Text = hoursA6Value.ToString();
        }

        private void MinutesA6_ValueChanged(object sender, EventArgs e)
        {
            //Store and display the numeric value from the minutes (A1) numericDomain
            object minutesA6Value = (minutesA1.Value + minutesA2.Value + minutesA3.Value + minutesA4.Value
                + minutesA5.Value + minutesA6.Value + minutesA7.Value).ToString();
            minutesValue.Text = minutesA6Value.ToString();
            
        }
        //END: Class A, Activity 6

        //START: Class A, Activity 7
        private void ActivityA7_SelectedItemChanged(object sender, EventArgs e)
        {
            //Store and display the selected option value from the activities (A1) UpDownDomain
            int activityA7Index = this.activityA7.SelectedIndex;
            string activityA7Selection = this.activityA7.Items[activityA7Index].ToString();
        }
        private void HoursA7_ValueChanged(object sender, EventArgs e)
        {
            //Store and display the selected option value from the hours (A1) UpDownDomain
            object hoursA7Value = (hoursA1.Value + hoursA2.Value + hoursA3.Value + hoursA4.Value + hoursA5.Value +
                hoursA6.Value + hoursA7.Value).ToString();
            hoursValue.Text = hoursA7Value.ToString();
        }

        private void MinutesA7_ValueChanged(object sender, EventArgs e)
        {
            //Store and display the numeric value from the minutes (A1) numericDomain
            object minutesA7Value = (minutesA1.Value + minutesA2.Value + minutesA3.Value + minutesA4.Value
                + minutesA5.Value + minutesA6.Value + minutesA7.Value).ToString();
          
            minutesValue.Text = minutesA7Value.ToString();
            //minutesValue.Text = AddingTime.ToString();
        }
        //END: Class A, Activity 7


        private void hoursValue_TextChanged(object sender, EventArgs e)
        {
            double ClassAhours = double.Parse(hoursValue.Text);
            double ClassAminutes = Math.Round(double.Parse(minutesValue.Text) / 60);
            double ClassACalculation = ClassAhours + ClassAminutes;
            //  MessageBox.Show(ClassCCalculation.ToString());
            if (ClassACalculation >= 6 & ClassACalculation <= 9)

            {
                nextButton.Visible = true;
            }
            else
            {
                nextButton.Visible = false;
            }
            /*
            if (ClassAhours <= 9 & ClassAhours >= 6)
                
            {
                nextButton.Visible = true;
            }
            else
            {
                nextButton.Visible = false;
            }
            */
        }

        private void nextButton_VisibleChanged(object sender, EventArgs e)
        {
            double ClassAhours = double.Parse(hoursValue.Text);
            if (ClassAhours > 9)

            {
                MessageBox.Show("You should only spend between 6 - 9 hours on class A activities in a day");

            }
        }

        private void minutesValue_TextChanged(object sender, EventArgs e)
        {
            double ClassAhours = double.Parse(hoursValue.Text);
            double ClassAminutes = Math.Round(double.Parse(minutesValue.Text) / 60);
            double ClassACalculation = ClassAhours + ClassAminutes;
            //  MessageBox.Show(ClassCCalculation.ToString());
            if (ClassACalculation >= 6 & ClassACalculation <= 9)

            {
                nextButton.Visible = true;
            }
            else
            {
                nextButton.Visible = false;
            }

        }

        private void ActivityAForm_Load(object sender, EventArgs e)
        {

        }
    }
}
