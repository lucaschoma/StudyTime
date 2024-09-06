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
    public partial class WeeklyTimetableForm : Form
    {
        public WeeklyTimetableForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //Hide the the controls and capture the window screen
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;   //Hide the border
            saveButton.Visible = false;
            backButton.Visible = false;
            Bitmap timetablePicture = new Bitmap(this.Width, this.Height);
            DrawToBitmap(timetablePicture, new System.Drawing.Rectangle(0, 0, timetablePicture.Width, timetablePicture.Height));
            timetablePicture.Save("C:\\Users\\Public\\Downloads\\timetablePicture.bmp", ImageFormat.Bmp);
           // MessageBox.Show("Captured!");

            //Go to Goals Setting Form
            this.Hide();
            //put in here the code
            InstructionsForm openinstructionsForm = new InstructionsForm();
            openinstructionsForm.ShowDialog();
           //GoalsSettingMenuForm openGoalSetting = new GoalsSettingMenuForm();
           // openGoalSetting.ShowDialog();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            //Go back to Activity-C Form
            this.Hide();
            ActivityCForm openActivityC = new ActivityCForm();
            openActivityC.ShowDialog();
        }

        private void WeeklyTimetableForm_Load(object sender, EventArgs e)
        {
            nameLabel.Text = MainMenuForm.passingName;
            surnameLabel.Text = MainMenuForm.passingSurname;
            stdNmbrLabel.Text = MainMenuForm.passingStdNmbr;
            comboMonday7am.Items.Add( "Class A Activity");
            comboMonday7am.Items.Add("Class B Activity");
            comboMonday7am.Items.Add("Class C Activity");
            if (ModulesForm.passingM1Code == "00000000")
            {
                ModulesForm.passingM1Code = "";
            }
            else
            {
                comboMonday7am.Items.Add(ModulesForm.passingM1Code + " Class");
                comboMonday7am.Items.Add(ModulesForm.passingM1Code + " Tutorial");
                comboMonday7am.Items.Add(ModulesForm.passingM1Code + " Practical");
            }
            if (ModulesForm.passingM2Code == "00000000")
            {
                ModulesForm.passingM2Code = "";
            }
            else
            {
                comboMonday7am.Items.Add(ModulesForm.passingM2Code + " Class");
                comboMonday7am.Items.Add(ModulesForm.passingM2Code + " Tutorial");
                comboMonday7am.Items.Add(ModulesForm.passingM2Code + " Practical");
            }
            if (ModulesForm.passingM3Code == "00000000")
            {
                ModulesForm.passingM3Code = "";
            }
            else
            {
                comboMonday7am.Items.Add(ModulesForm.passingM3Code + " Class");
                comboMonday7am.Items.Add(ModulesForm.passingM3Code + " Tutorial");
                comboMonday7am.Items.Add(ModulesForm.passingM3Code + " Practical");
            }
            if (ModulesForm.passingM4Code == "00000000")
            {
                ModulesForm.passingM4Code = "";
            }
            else
            {
                comboMonday7am.Items.Add(ModulesForm.passingM4Code + " Class");
                comboMonday7am.Items.Add(ModulesForm.passingM4Code + " Tutorial");
                comboMonday7am.Items.Add(ModulesForm.passingM4Code + " Practical");
            }
            if (ModulesForm.passingM5Code == "00000000")
            {
                ModulesForm.passingM5Code = "";
            }
            else
            {
                comboMonday7am.Items.Add(ModulesForm.passingM5Code + " Class");
                comboMonday7am.Items.Add(ModulesForm.passingM5Code + " Tutorial");
                comboMonday7am.Items.Add(ModulesForm.passingM5Code + " Practical");
            }
            if (ModulesForm.passingM6Code == "00000000")
            {
                ModulesForm.passingM6Code = "";
            }
            else
            {
                comboMonday7am.Items.Add(ModulesForm.passingM6Code + " Class");
                comboMonday7am.Items.Add(ModulesForm.passingM6Code + " Tutorial");
                comboMonday7am.Items.Add(ModulesForm.passingM6Code + " Practical");
            }
            if (ModulesForm.passingM7Code == "00000000")
            {
                ModulesForm.passingM7Code = "";
            }
            else
            {
                comboMonday7am.Items.Add(ModulesForm.passingM7Code + " Class");
                comboMonday7am.Items.Add(ModulesForm.passingM7Code + " Tutorial");
                comboMonday7am.Items.Add(ModulesForm.passingM7Code + " Practical");
            }
            //comboMonday7am.Items.Add(BeginAssignmentForm.passingM1Code);
           // comboMonday7am.Items.Add(BeginAssignmentForm.passingM2Code);
            //comboMonday7am.Items.Add(BeginAssignmentForm.passingM3Code);
            //comboMonday7am.Items.Add(BeginAssignmentForm.passingM4Code);
            //comboMonday7am.Items.Add(BeginAssignmentForm.passingM5Code);
            //comboMonday7am.Items.Add(BeginAssignmentForm.passingM6Code);
           // comboMonday7am.Items.Add(BeginAssignmentForm.passingM7Code);
            //Copy for rest of Monday
            comboMonday8am.Items.AddRange(comboMonday7am.Items.Cast<Object>().ToArray());
            comboMonday9am.Items.AddRange(comboMonday7am.Items.Cast<Object>().ToArray());
            comboMonday10am.Items.AddRange(comboMonday7am.Items.Cast<Object>().ToArray());
            comboMonday11am.Items.AddRange(comboMonday7am.Items.Cast<Object>().ToArray());
            comboMonday12am.Items.AddRange(comboMonday7am.Items.Cast<Object>().ToArray());
            comboMonday1pm.Items.AddRange(comboMonday7am.Items.Cast<Object>().ToArray());
            comboMonday2pm.Items.AddRange(comboMonday7am.Items.Cast<Object>().ToArray());
            comboMonday3pm.Items.AddRange(comboMonday7am.Items.Cast<Object>().ToArray());
            comboMonday4pm.Items.AddRange(comboMonday7am.Items.Cast<Object>().ToArray());
            comboMonday5pm.Items.AddRange(comboMonday7am.Items.Cast<Object>().ToArray());
            comboMonday6pm.Items.AddRange(comboMonday7am.Items.Cast<Object>().ToArray());

            //Copy for rest of Tuesday
            comboTuesday7am.Items.AddRange(comboMonday7am.Items.Cast<Object>().ToArray());
            comboTuesday8am.Items.AddRange(comboMonday7am.Items.Cast<Object>().ToArray());
            comboTuesday9am.Items.AddRange(comboMonday7am.Items.Cast<Object>().ToArray());
            comboTuesday10am.Items.AddRange(comboMonday7am.Items.Cast<Object>().ToArray());
            comboTuesday11am.Items.AddRange(comboMonday7am.Items.Cast<Object>().ToArray());
            comboTuesday12am.Items.AddRange(comboMonday7am.Items.Cast<Object>().ToArray());
            comboTuesday1pm.Items.AddRange(comboMonday7am.Items.Cast<Object>().ToArray());
            comboTuesday2pm.Items.AddRange(comboMonday7am.Items.Cast<Object>().ToArray());
            comboTuesday3pm.Items.AddRange(comboMonday7am.Items.Cast<Object>().ToArray());
            comboTuesday4pm.Items.AddRange(comboMonday7am.Items.Cast<Object>().ToArray());
            comboTuesday5pm.Items.AddRange(comboMonday7am.Items.Cast<Object>().ToArray());
            comboTuesday6pm.Items.AddRange(comboMonday7am.Items.Cast<Object>().ToArray());
            //Copy for rest of Wednesday
            comboWednesday7am.Items.AddRange(comboMonday7am.Items.Cast<Object>().ToArray());
            comboWednesday8am.Items.AddRange(comboMonday7am.Items.Cast<Object>().ToArray());
            comboWednesday9am.Items.AddRange(comboMonday7am.Items.Cast<Object>().ToArray());
            comboWednesday10am.Items.AddRange(comboMonday7am.Items.Cast<Object>().ToArray());
            comboWednesday11am.Items.AddRange(comboMonday7am.Items.Cast<Object>().ToArray());
            comboWednesday12am.Items.AddRange(comboMonday7am.Items.Cast<Object>().ToArray());
            comboWednesday1pm.Items.AddRange(comboMonday7am.Items.Cast<Object>().ToArray());
            comboWednesday2pm.Items.AddRange(comboMonday7am.Items.Cast<Object>().ToArray());
            comboWednesday3pm.Items.AddRange(comboMonday7am.Items.Cast<Object>().ToArray());
            comboWednesday4pm.Items.AddRange(comboMonday7am.Items.Cast<Object>().ToArray());
            comboWednesday5pm.Items.AddRange(comboMonday7am.Items.Cast<Object>().ToArray());
            comboWednesday6pm.Items.AddRange(comboMonday7am.Items.Cast<Object>().ToArray());
            //Copy for rest of Thursday
            comboThursday7am.Items.AddRange(comboMonday7am.Items.Cast<Object>().ToArray());
            comboThursday8am.Items.AddRange(comboMonday7am.Items.Cast<Object>().ToArray());
            comboThursday9am.Items.AddRange(comboMonday7am.Items.Cast<Object>().ToArray());
            comboThursday10am.Items.AddRange(comboMonday7am.Items.Cast<Object>().ToArray());
            comboThursday11am.Items.AddRange(comboMonday7am.Items.Cast<Object>().ToArray());
            comboThursday12am.Items.AddRange(comboMonday7am.Items.Cast<Object>().ToArray());
            comboThursday1pm.Items.AddRange(comboMonday7am.Items.Cast<Object>().ToArray());
            comboThursday2pm.Items.AddRange(comboMonday7am.Items.Cast<Object>().ToArray());
            comboThursday3pm.Items.AddRange(comboMonday7am.Items.Cast<Object>().ToArray());
            comboThursday4pm.Items.AddRange(comboMonday7am.Items.Cast<Object>().ToArray());
            comboThursday5pm.Items.AddRange(comboMonday7am.Items.Cast<Object>().ToArray());
            comboThursday6pm.Items.AddRange(comboMonday7am.Items.Cast<Object>().ToArray());
            //Copy for rest of Friday
            comboFriday7am.Items.AddRange(comboMonday7am.Items.Cast<Object>().ToArray());
            comboFriday8am.Items.AddRange(comboMonday7am.Items.Cast<Object>().ToArray());
            comboFriday9am.Items.AddRange(comboMonday7am.Items.Cast<Object>().ToArray());
            comboFriday10am.Items.AddRange(comboMonday7am.Items.Cast<Object>().ToArray());
            comboFriday11am.Items.AddRange(comboMonday7am.Items.Cast<Object>().ToArray());
            comboFriday12am.Items.AddRange(comboMonday7am.Items.Cast<Object>().ToArray());
            comboFriday1pm.Items.AddRange(comboMonday7am.Items.Cast<Object>().ToArray());
            comboFriday2pm.Items.AddRange(comboMonday7am.Items.Cast<Object>().ToArray());
            comboFriday3pm.Items.AddRange(comboMonday7am.Items.Cast<Object>().ToArray());
            comboFriday4pm.Items.AddRange(comboMonday7am.Items.Cast<Object>().ToArray());
            comboFriday5pm.Items.AddRange(comboMonday7am.Items.Cast<Object>().ToArray());
            comboFriday6pm.Items.AddRange(comboMonday7am.Items.Cast<Object>().ToArray());
        }

    }
}
