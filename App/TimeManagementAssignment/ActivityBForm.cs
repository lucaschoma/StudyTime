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
    public partial class ActivityBForm : Form
    {
        public static double PassingClassB;
        public static double PassingMinutesB;
        public static double PassingMinutesAndHours;
        public ActivityBForm()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            //Hide the controls and capture the window screen
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;   //Hide the border
            nextButton.Visible = false;
            backButton.Visible = false;
            Bitmap activityBPicture = new Bitmap(this.Width, this.Height);
            DrawToBitmap(activityBPicture, new Rectangle(0, 0, activityBPicture.Width, activityBPicture.Height));
            activityBPicture.Save("C:\\Users\\Public\\Downloads\\activityB-Picture.bmp", ImageFormat.Bmp);
            // MessageBox.Show("Captured");

            //Go to Activity-C Form
            
            PassingClassB = double.Parse(hoursValue.Text);
            PassingMinutesB = double.Parse(minutesValue.Text);
            PassingMinutesAndHours = Math.Round(7*(PassingClassB + (PassingMinutesB / 60)), 0);
            this.Hide();
            ActivityCForm openActivityC = new ActivityCForm();
            openActivityC.Show();
            Visible = false;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            //Go back to Activity-A Form
            this.Hide();
            ActivityAForm openActivityA = new ActivityAForm();
            openActivityA.ShowDialog();
        }
        //START: Class A, Activity 1
        private void ActivityB1_SelectedItemChanged(object sender, EventArgs e)
        {
            //Store and display the selected option value from the activities (B1) UpDownDomain
            int activityB1Index = this.activityB1.SelectedIndex;
            string activityB1Selection = this.activityB1.Items[activityB1Index].ToString();
        }

        private void HoursB1_ValueChanged(object sender, EventArgs e)
        {
            //Store and display the selected option value from the hours (B1) UpDownDomain
            object hoursB1Value = (hoursB1.Value + hoursB2.Value + hoursB3.Value + hoursB4.Value + hoursB5.Value +
                hoursB6.Value + hoursB7.Value).ToString();
            hoursValue.Text = hoursB1Value.ToString();
        }

        private void MinutesB1_ValueChanged(object sender, EventArgs e)
        {
            //Store and display the numeric value from the minutes (B1) numericDomain
            object minutesB1Value = (minutesB1.Value + minutesB2.Value + minutesB3.Value + minutesB4.Value
                + minutesB5.Value + minutesB6.Value + minutesB7.Value).ToString();
            //minutesValue.Text = minutesB1Value.ToString();
            //Convert minutes to hour if minutersvalue ismore than 59 minutes
            Int32.TryParse(minutesB1Value.ToString(), out int minutesToHours);
            minutesToHours /= 60;
            //minutesValue.Text = (minutesToHours % 60).ToString();

            if (minutesToHours >= 60)
            {
                //
                //minutesB1.Value = minutesToHours % 60;
                minutesValue.Text = (minutesToHours % 60).ToString();
                hoursValue.Text = (hoursB1.Value + minutesToHours).ToString();
            }
            else
            {
                minutesValue.Text = minutesB1Value.ToString();
            }

        }
        //END: Class A, Activity 1

        //START: Class A, Activity 2
        private void ActivityB2_SelectedItemChanged(object sender, EventArgs e)
        {
            //Store and display the selected option value from the activities (B1) UpDownDomain
            int activityB2Index = this.activityB2.SelectedIndex;
            string activityB2Selection = this.activityB2.Items[activityB2Index].ToString();
        }
        private void HoursB2_ValueChanged(object sender, EventArgs e)
        {
            //Store and display the selected option value from the hours (B1) UpDownDomain
            object hoursB2Value = (hoursB1.Value + hoursB2.Value + hoursB3.Value + hoursB4.Value + hoursB5.Value +
                hoursB6.Value + hoursB7.Value).ToString();
            hoursValue.Text = hoursB2Value.ToString();
        }

        private void MinutesB2_ValueChanged(object sender, EventArgs e)
        {
            //Store and display the numeric value from the minutes (B1) numericDomain
            object minutesB2Value = (minutesB1.Value + minutesB2.Value + minutesB3.Value + minutesB4.Value
                + minutesB5.Value + minutesB6.Value + minutesB7.Value).ToString();
            minutesValue.Text = minutesB2Value.ToString();

        }
        //END: Class A, Activity 2

        //START: Class A, Activity 3
        private void ActivityB3_SelectedItemChanged(object sender, EventArgs e)
        {
            //Store and display the selected option value from the activities (B1) UpDownDomain
            int activityB3Index = this.activityB3.SelectedIndex;
            string activityB3Selection = this.activityB3.Items[activityB3Index].ToString();
        }

        private void HoursB3_ValueChanged(object sender, EventArgs e)
        {
            //Store and display the selected option value from the hours (B1) UpDownDomain
            object hoursB3Value = (hoursB1.Value + hoursB2.Value + hoursB3.Value + hoursB4.Value + hoursB5.Value +
                hoursB6.Value + hoursB7.Value).ToString();
            hoursValue.Text = hoursB3Value.ToString();
        }

        private void MinutesB3_ValueChanged(object sender, EventArgs e)
        {
            //Store and display the numeric value from the minutes (B1) numericDomain
            object minutesB3Value = (minutesB1.Value + minutesB2.Value + minutesB3.Value + minutesB4.Value
                + minutesB5.Value + minutesB6.Value + minutesB7.Value).ToString();
            minutesValue.Text = minutesB3Value.ToString();

        }
        //END: Class A, Activity 3

        //START: Class A, Activity 4
        private void ActivityB4_SelectedItemChanged(object sender, EventArgs e)
        {
            //Store and display the selected option value from the activities (B1) UpDownDomain
            int activityB4Index = this.activityB4.SelectedIndex;
            string activityB4Selection = this.activityB4.Items[activityB4Index].ToString();
        }

        private void HoursB4_ValueChanged(object sender, EventArgs e)
        {
            //Store and display the selected option value from the hours (B1) UpDownDomain
            object hoursB4Value = (hoursB1.Value + hoursB2.Value + hoursB3.Value + hoursB4.Value + hoursB5.Value +
                hoursB6.Value + hoursB7.Value).ToString();
            hoursValue.Text = hoursB4Value.ToString();
        }

        private void MinutesB4_ValueChanged(object sender, EventArgs e)
        {
            //Store and display the numeric value from the minutes (B1) numericDomain
            object minutesB4Value = (minutesB1.Value + minutesB2.Value + minutesB3.Value + minutesB4.Value
                + minutesB5.Value + minutesB6.Value + minutesB7.Value).ToString();
            minutesValue.Text = minutesB4Value.ToString();

        }
        //END: Class A, Activity 4

        //START: Class A, Activity 5
        private void ActivityB5_SelectedItemChanged(object sender, EventArgs e)
        {
            //Store and display the selected option value from the activities (B1) UpDownDomain
            int activityB5Index = this.activityB5.SelectedIndex;
            string activityB5Selection = this.activityB5.Items[activityB5Index].ToString();
        }

        private void HoursB5_ValueChanged(object sender, EventArgs e)
        {
            //Store and display the selected option value from the hours (B1) UpDownDomain
            object hoursB5Value = (hoursB1.Value + hoursB2.Value + hoursB3.Value + hoursB4.Value + hoursB5.Value +
                hoursB6.Value + hoursB7.Value).ToString();
            hoursValue.Text = hoursB5Value.ToString();
        }

        private void MinutesB5_ValueChanged(object sender, EventArgs e)
        {
            //Store and display the numeric value from the minutes (B1) numericDomain
            object minutesB5Value = (minutesB1.Value + minutesB2.Value + minutesB3.Value + minutesB4.Value
                + minutesB5.Value + minutesB6.Value + minutesB7.Value).ToString();
            minutesValue.Text = minutesB5Value.ToString();

        }
        //END: Class A, Activity 5

        //START: Class A, Activity 6
        private void ActivityB6_SelectedItemChanged(object sender, EventArgs e)
        {
            //Store and display the selected option value from the activities (B1) UpDownDomain
            int activityB6Index = this.activityB6.SelectedIndex;
            string activityB6Selection = this.activityB6.Items[activityB6Index].ToString();
        }
        private void HoursB6_ValueChanged(object sender, EventArgs e)
        {
            //Store and display the selected option value from the hours (B1) UpDownDomain
            object hoursB6Value = (hoursB1.Value + hoursB2.Value + hoursB3.Value + hoursB4.Value + hoursB5.Value +
                hoursB6.Value + hoursB7.Value).ToString();
            hoursValue.Text = hoursB6Value.ToString();
        }

        private void MinutesB6_ValueChanged(object sender, EventArgs e)
        {
            //Store and display the numeric value from the minutes (B1) numericDomain
            object minutesB6Value = (minutesB1.Value + minutesB2.Value + minutesB3.Value + minutesB4.Value
                + minutesB5.Value + minutesB6.Value + minutesB7.Value).ToString();
            minutesValue.Text = minutesB6Value.ToString();

        }
        //END: Class A, Activity 6

        //START: Class A, Activity 7
        private void ActivityB7_SelectedItemChanged(object sender, EventArgs e)
        {
            //Store and display the selected option value from the activities (B1) UpDownDomain
            int activityB7Index = this.activityB7.SelectedIndex;
            string activityB7Selection = this.activityB7.Items[activityB7Index].ToString();
        }
        private void HoursB7_ValueChanged(object sender, EventArgs e)
        {
            //Store and display the selected option value from the hours (B1) UpDownDomain
            object hoursB7Value = (hoursB1.Value + hoursB2.Value + hoursB3.Value + hoursB4.Value + hoursB5.Value +
                hoursB6.Value + hoursB7.Value).ToString();
            hoursValue.Text = hoursB7Value.ToString();
        }

        private void MinutesB7_ValueChanged(object sender, EventArgs e)
        {
            //Store and display the numeric value from the minutes (B1) numericDomain
            object minutesB7Value = (minutesB1.Value + minutesB2.Value + minutesB3.Value + minutesB4.Value
                + minutesB5.Value + minutesB6.Value + minutesB7.Value).ToString();
            minutesValue.Text = minutesB7Value.ToString();

        }

        private void hoursValue_TextChanged(object sender, EventArgs e)
        {
            double ClassBhours = double.Parse(hoursValue.Text);
            double ClassBminutes = Math.Round(double.Parse(minutesValue.Text) / 60);
            double ClassBCalculation = ClassBhours + ClassBminutes;
            //  MessageBox.Show(ClassCCalculation.ToString());
            if (ClassBCalculation >= 10 & ClassBCalculation <= 12)

            {
                nextButton.Visible = true;
            }
            else
            {
                nextButton.Visible = false;
            }
            /*double ClassBhours = double.Parse(hoursValue.Text);


            if (ClassBhours >= 10 & ClassBhours <= 12)

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
            if (ClassAhours > 12)

            {
                MessageBox.Show("You should only spend between 10 - 12 hours on class B activities in a day");

            }
        }

        private void minutesValue_TextChanged(object sender, EventArgs e)
        {
            double ClassBhours = double.Parse(hoursValue.Text);
            double ClassBminutes = Math.Round(double.Parse(minutesValue.Text) / 60);
            double ClassBCalculation = ClassBhours + ClassBminutes;
            //  MessageBox.Show(ClassCCalculation.ToString());
            if (ClassBCalculation >= 10 & ClassBCalculation <= 12)

            {
                nextButton.Visible = true;
            }
            else
            {
                nextButton.Visible = false;
            }
        }
        //END: Class A, Activity 7
    }
}
