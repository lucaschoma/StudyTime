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
using Microsoft.Office.Interop.Word;

namespace TimeManagementAssignment
{
    public partial class ActivityCForm : Form
    {
        public static double PassingclassC;
        public static double PassingMinutesC;
        public static double PassingMinutesAndHours;
        public ActivityCForm()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            //Hide the controls and capture the window screen
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;   //Hide the border
            submitButton.Visible = false;
            backButton.Visible = false;
            Bitmap activityCPicture = new Bitmap(this.Width, this.Height);
            DrawToBitmap(activityCPicture, new System.Drawing.Rectangle(0, 0, activityCPicture.Width, activityCPicture.Height));
            activityCPicture.Save("C:\\Users\\Public\\Downloads\\activityC-Picture.bmp", ImageFormat.Bmp);
            // MessageBox.Show("Captured!");

            //Go to Timetable Form
            PassingclassC = double.Parse(hoursValue.Text);
            PassingMinutesC = double.Parse(minutesValue.Text);
            PassingMinutesAndHours = Math.Round(7*(PassingclassC + (PassingMinutesC / 60)), 0);
            WeeklyTimetableForm openWklyTmTbl = new WeeklyTimetableForm();
            openWklyTmTbl.Show();
            Visible = false;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            //Go back to Activity-B Form
            ActivityBForm openActivityB = new ActivityBForm();
            openActivityB.Show();
            Visible = false;
        }

        //START: Class A, Activity 1
        private void ActivityC1_SelectedItemChanged(object sender, EventArgs e)
        {
            //Store and display the selected option value from the activities (C1) UpDownDomain
            int activityC1Index = this.activityC1.SelectedIndex;
            string activityC1Selection = this.activityC1.Items[activityC1Index].ToString();
        }

        private void HoursC1_ValueChanged(object sender, EventArgs e)
        {
            //Store and display the selected option value from the hours (C1) UpDownDomain
            object hoursC1Value = (hoursC1.Value + hoursC2.Value + hoursC3.Value + hoursC4.Value + hoursC5.Value +
                hoursC6.Value + hoursC7.Value).ToString();
            hoursValue.Text = hoursC1Value.ToString();
        }

        private void MinutesC1_ValueChanged(object sender, EventArgs e)
        {
            //Store and display the numeric value from the minutes (C1) numericDomain
            object minutesC1Value = (minutesC1.Value + minutesC2.Value + minutesC3.Value + minutesC4.Value
                + minutesC5.Value + minutesC6.Value + minutesC7.Value).ToString();
            //minutesValue.Text = minutesC1Value.ToString();
            //Convert minutes to hour if minutersvalue ismore than 59 minutes
            Int32.TryParse(minutesC1Value.ToString(), out int minutesToHours);
            minutesToHours /= 60;
            //minutesValue.Text = (minutesToHours % 60).ToString();

            if (minutesToHours >= 60)
            {
                //
                //minutesC1.Value = minutesToHours % 60;
                minutesValue.Text = (minutesToHours % 60).ToString();
                hoursValue.Text = (hoursC1.Value + minutesToHours).ToString();
            }
            else
            {
                minutesValue.Text = minutesC1Value.ToString();
            }

        }
        //END: Class A, Activity 1

        //START: Class A, Activity 2
        private void ActivityC2_SelectedItemChanged(object sender, EventArgs e)
        {
            //Store and display the selected option value from the activities (C1) UpDownDomain
            int activityC2Index = this.activityC2.SelectedIndex;
            string activityC2Selection = this.activityC2.Items[activityC2Index].ToString();
        }
        private void HoursC2_ValueChanged(object sender, EventArgs e)
        {
            //Store and display the selected option value from the hours (C1) UpDownDomain
            object hoursC2Value = (hoursC1.Value + hoursC2.Value + hoursC3.Value + hoursC4.Value + hoursC5.Value +
                hoursC6.Value + hoursC7.Value).ToString();
            hoursValue.Text = hoursC2Value.ToString();
        }
        private void MinutesC2_ValueChanged(object sender, EventArgs e)
        {
            //Store and display the numeric value from the minutes (C1) numericDomain
            object minutesC2Value = (minutesC1.Value + minutesC2.Value + minutesC3.Value + minutesC4.Value
                + minutesC5.Value + minutesC6.Value + minutesC7.Value).ToString();
            minutesValue.Text = minutesC2Value.ToString();

        }
        //END: Class A, Activity 2

        //START: Class A, Activity 3
        private void ActivityC3_SelectedItemChanged(object sender, EventArgs e)
        {
            //Store and display the selected option value from the activities (C1) UpDownDomain
            int activityC3Index = this.activityC3.SelectedIndex;
            string activityC3Selection = this.activityC3.Items[activityC3Index].ToString();
        }
        private void HoursC3_ValueChanged(object sender, EventArgs e)
        {
            //Store and display the selected option value from the hours (C1) UpDownDomain
            object hoursC3Value = (hoursC1.Value + hoursC2.Value + hoursC3.Value + hoursC4.Value + hoursC5.Value +
                hoursC6.Value + hoursC7.Value).ToString();
            hoursValue.Text = hoursC3Value.ToString();
        }
        private void MinutesC3_ValueChanged(object sender, EventArgs e)
        {
            //Store and display the numeric value from the minutes (C1) numericDomain
            object minutesC3Value = (minutesC1.Value + minutesC2.Value + minutesC3.Value + minutesC4.Value
                + minutesC5.Value + minutesC6.Value + minutesC7.Value).ToString();
            minutesValue.Text = minutesC3Value.ToString();

        }
        //END: Class A, Activity 3

        //START: Class A, Activity 4
        private void ActivityC4_SelectedItemChanged(object sender, EventArgs e)
        {
            //Store and display the selected option value from the activities (C1) UpDownDomain
            int activityC4Index = this.activityC4.SelectedIndex;
            string activityC4Selection = this.activityC4.Items[activityC4Index].ToString();
        }
        private void HoursC4_ValueChanged(object sender, EventArgs e)
        {
            //Store and display the selected option value from the hours (C1) UpDownDomain
            object hoursC4Value = (hoursC1.Value + hoursC2.Value + hoursC3.Value + hoursC4.Value + hoursC5.Value +
                hoursC6.Value + hoursC7.Value).ToString();
            hoursValue.Text = hoursC4Value.ToString();
        }
        private void MinutesC4_ValueChanged(object sender, EventArgs e)
        {
            //Store and display the numeric value from the minutes (C1) numericDomain
            object minutesC4Value = (minutesC1.Value + minutesC2.Value + minutesC3.Value + minutesC4.Value
                + minutesC5.Value + minutesC6.Value + minutesC7.Value).ToString();
            minutesValue.Text = minutesC4Value.ToString();

        }
        //END: Class A, Activity 4

        //START: Class A, Activity 5
        private void ActivityC5_SelectedItemChanged(object sender, EventArgs e)
        {
            //Store and display the selected option value from the activities (C1) UpDownDomain
            int activityC5Index = this.activityC5.SelectedIndex;
            string activityC5Selection = this.activityC5.Items[activityC5Index].ToString();
        }
        private void HoursC5_ValueChanged(object sender, EventArgs e)
        {
            //Store and display the selected option value from the hours (C1) UpDownDomain
            object hoursC5Value = (hoursC1.Value + hoursC2.Value + hoursC3.Value + hoursC4.Value + hoursC5.Value +
                hoursC6.Value + hoursC7.Value).ToString();
            hoursValue.Text = hoursC5Value.ToString();
        }
        private void MinutesC5_ValueChanged(object sender, EventArgs e)
        {
            //Store and display the numeric value from the minutes (C1) numericDomain
            object minutesC5Value = (minutesC1.Value + minutesC2.Value + minutesC3.Value + minutesC4.Value
                + minutesC5.Value + minutesC6.Value + minutesC7.Value).ToString();
            minutesValue.Text = minutesC5Value.ToString();

        }
        //END: Class A, Activity 5

        //START: Class A, Activity 6
        private void ActivityC6_SelectedItemChanged(object sender, EventArgs e)
        {
            //Store and display the selected option value from the activities (C1) UpDownDomain
            int activityC6Index = this.activityC6.SelectedIndex;
            string activityC6Selection = this.activityC6.Items[activityC6Index].ToString();
        }
        private void HoursC6_ValueChanged(object sender, EventArgs e)
        {
            //Store and display the selected option value from the hours (C1) UpDownDomain
            object hoursC6Value = (hoursC1.Value + hoursC2.Value + hoursC3.Value + hoursC4.Value + hoursC5.Value +
                hoursC6.Value + hoursC7.Value).ToString();
            hoursValue.Text = hoursC6Value.ToString();
        }
        private void MinutesC6_ValueChanged(object sender, EventArgs e)
        {
            //Store and display the numeric value from the minutes (C1) numericDomain
            object minutesC6Value = (minutesC1.Value + minutesC2.Value + minutesC3.Value + minutesC4.Value
                + minutesC5.Value + minutesC6.Value + minutesC7.Value).ToString();
            minutesValue.Text = minutesC6Value.ToString();

        }
        //END: Class A, Activity 6

        //START: Class A, Activity 7
        private void ActivityC7_SelectedItemChanged(object sender, EventArgs e)
        {
            //Store and display the selected option value from the activities (C1) UpDownDomain
            int activityC7Index = this.activityC7.SelectedIndex;
            string activityC7Selection = this.activityC7.Items[activityC7Index].ToString();
        }
        private void HoursC7_ValueChanged(object sender, EventArgs e)
        {
            //Store and display the selected option value from the hours (C1) UpDownDomain
            object hoursC7Value = (hoursC1.Value + hoursC2.Value + hoursC3.Value + hoursC4.Value + hoursC5.Value +
                hoursC6.Value + hoursC7.Value).ToString();
            hoursValue.Text = hoursC7Value.ToString();
        }
        private void MinutesC7_ValueChanged(object sender, EventArgs e)
        {
            //Store and display the numeric value from the minutes (C1) numericDomain
            object minutesC7Value = (minutesC1.Value + minutesC2.Value + minutesC3.Value + minutesC4.Value
                + minutesC5.Value + minutesC6.Value + minutesC7.Value).ToString();
            minutesValue.Text = minutesC7Value.ToString();

        }

        private void hoursValue_TextChanged(object sender, EventArgs e)
        {
            double ClassChours = double.Parse(hoursValue.Text);
            double ClassCminutes = Math.Round(double.Parse(minutesValue.Text)/60);
            double ClassCCalculation = ClassChours + ClassCminutes;
          //  MessageBox.Show(ClassCCalculation.ToString());
            if (ClassCCalculation >= 2 & ClassCCalculation <= 4)

            {
                submitButton.Visible = true;
            }
            else
            {
                submitButton.Visible = false;
            }

        }

        private void submitButton_VisibleChanged(object sender, EventArgs e)
        {
            double ClassAhours = double.Parse(hoursValue.Text);
            if (ClassAhours > 4)

            {
                MessageBox.Show("You should only spend between 2 - 4 hours on class C activities in a day");

            }
        }

        private void minutesValue_TextChanged(object sender, EventArgs e)
        {
            double ClassChours = double.Parse(hoursValue.Text);
            double ClassCminutes = Math.Round(double.Parse(minutesValue.Text) / 60);
            double ClassCCalculation = ClassChours + ClassCminutes;
            //  MessageBox.Show(ClassCCalculation.ToString());
            if (ClassCCalculation >= 2 & ClassCCalculation <= 4)

            {
                submitButton.Visible = true;
            }
            else
            {
                submitButton.Visible = false;
            }
        }
        //END: Class A, Activity 7
    }
}
