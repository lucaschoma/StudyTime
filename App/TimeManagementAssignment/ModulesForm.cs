using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeManagementAssignment
{
    public partial class ModulesForm : Form
    {
        // Declaring public variable to pass this Form information to another
        public static string passingM1Code, passingM2Code, passingM3Code, passingM4Code, passingM5Code, passingM6Code, passingM7Code;
        public static int passingM1Not, passingM2Not, passingM3Not, passingM4Not, passingM5Not, passingM6Not, passingM7Not;
        public static int passingSemester1, passingSemester2, passingSemester3, passingSemester4, passingSemester5, passingSemester6, passingSemester7;

        private void module1TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetterOrDigit  (e.KeyChar) || e.KeyChar == (char)Keys.Back);

            string module1 = module1TextBox.Text.ToUpper();
            
        }

        private void module7TextBox_Leave(object sender, EventArgs e)
        {
            string module1 = module1TextBox.Text.ToUpper(), module2 = module2TextBox.Text.ToUpper(), module3 = module3TextBox.Text.ToUpper(),
                  module4 = module4TextBox.Text.ToUpper(), module5 = module5TextBox.Text.ToUpper(), module6 = module6TextBox.Text.ToUpper(),
                  module7 = module7TextBox.Text.ToUpper();
            if (module7TextBox.Text == "")
            {
                module6TextBox.Select();
            }

            else
            {
                if (module7.Length != 8)
                {
                    MessageBox.Show("Please enter 8-Character Module Code", "WRONG MODULE CODE");
                    module7TextBox.Text = "";
                    module7TextBox.Select();
                }
            }

        }

        private void module6TextBox_Leave(object sender, EventArgs e)
        {
            string module1 = module1TextBox.Text.ToUpper(), module2 = module2TextBox.Text.ToUpper(), module3 = module3TextBox.Text.ToUpper(),
                  module4 = module4TextBox.Text.ToUpper(), module5 = module5TextBox.Text.ToUpper(), module6 = module6TextBox.Text.ToUpper(),
                  module7 = module7TextBox.Text.ToUpper();
            if (module6TextBox.Text == "")
            {
                module5TextBox.Select();
            }

            else
            {
                if (module6.Length != 8)
                {
                    MessageBox.Show("Please enter 8-Character Module Code", "WRONG MODULE CODE");
                    module6TextBox.Text = "";
                    module6TextBox.Select();
                }
                else
                {
                    module7TextBox.Select();
                }
            }


        }

        private void module5TextBox_Leave(object sender, EventArgs e)
        {
            string module1 = module1TextBox.Text.ToUpper(), module2 = module2TextBox.Text.ToUpper(), module3 = module3TextBox.Text.ToUpper(),
                  module4 = module4TextBox.Text.ToUpper(), module5 = module5TextBox.Text.ToUpper(), module6 = module6TextBox.Text.ToUpper(),
                  module7 = module7TextBox.Text.ToUpper();
            if (module5TextBox.Text == "")
            {
                module4TextBox.Select();
            }

            else
            {
                if (module5.Length != 8)
                {
                    MessageBox.Show("Please enter 8-Character Module Code", "WRONG MODULE CODE");
                    module5TextBox.Text = "";
                    module5TextBox.Select();
                }
                else
                {
                    module6TextBox.Select();
                }

            }


        }

        private void module4TextBox_Leave(object sender, EventArgs e)
        {
            string module1 = module1TextBox.Text.ToUpper(), module2 = module2TextBox.Text.ToUpper(), module3 = module3TextBox.Text.ToUpper(),
                  module4 = module4TextBox.Text.ToUpper(), module5 = module5TextBox.Text.ToUpper(), module6 = module6TextBox.Text.ToUpper(),
                  module7 = module7TextBox.Text.ToUpper();
            if (module4TextBox.Text == "")
            {
                module3TextBox.Select();
            }

            else
            {
                if (module4.Length != 8)
                {
                    MessageBox.Show("Please enter 8-Character Module Code", "WRONG MODULE CODE");
                    module4TextBox.Text = "";
                    module4TextBox.Select();
                }
                else
                {
                    module5TextBox.Select();
                }
            }

        }

        private void module3TextBox_Leave(object sender, EventArgs e)
        {
            string module1 = module1TextBox.Text.ToUpper(), module2 = module2TextBox.Text.ToUpper(), module3 = module3TextBox.Text.ToUpper(),
                  module4 = module4TextBox.Text.ToUpper(), module5 = module5TextBox.Text.ToUpper(), module6 = module6TextBox.Text.ToUpper(),
                  module7 = module7TextBox.Text.ToUpper();
            if (module3TextBox.Text == "")
            {
                module2TextBox.Select();
            }

            else
            {
                if (module3.Length != 8)
                {
                    MessageBox.Show("Please enter 8-Character Module Code", "WRONG MODULE CODE");
                    module3TextBox.Text = "";
                    module3TextBox.Select();
                }
                else
                {
                    module4TextBox.Select();
                }
            }

        }

        private void module2TextBox_Leave(object sender, EventArgs e)
        {
            string module1 = module1TextBox.Text.ToUpper(), module2 = module2TextBox.Text.ToUpper(), module3 = module3TextBox.Text.ToUpper(),
                   module4 = module4TextBox.Text.ToUpper(), module5 = module5TextBox.Text.ToUpper(), module6 = module6TextBox.Text.ToUpper(),
                   module7 = module7TextBox.Text.ToUpper();
            if (module2TextBox.Text == "")
            {
                module1TextBox.Select();
            }

            else
            {
                if (module2.Length != 8)
                {
                    MessageBox.Show("Please enter 8-Character Module Code", "WRONG MODULE CODE");
                    module2TextBox.Text = "";
                    module2TextBox.Select();
                }
                else
                {
                    module3TextBox.Select();
                }
            }

        }

        private void module1TextBox_Leave(object sender, EventArgs e)
        {
            string module1 = module1TextBox.Text.ToUpper(), module2 = module2TextBox.Text.ToUpper(), module3 = module3TextBox.Text.ToUpper(),
                   module4 = module4TextBox.Text.ToUpper(), module5 = module5TextBox.Text.ToUpper(), module6 = module6TextBox.Text.ToUpper(),
                   module7 = module7TextBox.Text.ToUpper();
            if (module1TextBox.Text == "")
            {
                module1TextBox.Select();
            }

            else
            {
                if (module1.Length != 8)
                {
                    MessageBox.Show("Please enter 8-Character Module Code", "WRONG MODULE CODE");
                    module1TextBox.Text = "";
                    module1TextBox.Select();
                }
                else
                {
                    module2TextBox.Select();
                }
            }

        }

        public static int passingM1Cred, passingM2Cred, passingM3Cred, passingM4Cred, passingM5Cred, passingM6Cred, passingM7Cred;
        //New variable: for passing individual module weekly study hours
        public static int passingM1WklyHrs, passingM2WklyHrs, passingM3WklyHrs, passingM4WklyHrs, passingM5WklyHrs, passingM6WklyHrs, passingM7WklyHrs;
        public static int totalWeeklyHours;

        public ModulesForm()
        {
            InitializeComponent();
        }

        private void BeginAssignmentForm_Load(object sender, EventArgs e)
        {

        }

        //BUTTON: Notional Learning Hours
        //Submit the entered Modules' learning hours
        private void LearnHoursButton_Click(object sender, EventArgs e)
        {
            //Array to hold all modules
            //Declare and instantiate module codes -- from input text boxes
            string module1 = module1TextBox.Text.ToUpper(), module2 = module2TextBox.Text.ToUpper(), module3 = module3TextBox.Text.ToUpper(), 
                module4 = module4TextBox.Text.ToUpper(), module5 = module5TextBox.Text.ToUpper(), module6 = module6TextBox.Text.ToUpper(), 
                module7 = module7TextBox.Text.ToUpper();

            int weeksPerSemester = 15;    //Number of Weeeks for the Semester
           // passingSemesterWeeks = weeksPerSemester;   //Public variable: passing Number of Semester Weeeks

            //VALIDATION: Check if all module textboxes are empty or not
            if(String.IsNullOrEmpty(module1) == true & String.IsNullOrEmpty(module2) == true & String.IsNullOrEmpty(module3) == true 
                & String.IsNullOrEmpty(module4) == true & String.IsNullOrEmpty(module5) == true & String.IsNullOrEmpty(module6) == true 
                & String.IsNullOrEmpty(module7) == true)
            {
                MessageBox.Show("Please fill in at least one module code!", "EMPTY MODULE CODES");
                //TO DO: Reload the form
            }
            else   //Check individual Modules input
            {
                //Validating MODULE_1
                if (String.IsNullOrEmpty(module1) == false)
                {
                    
                        //calculating first module's Credits
                        string str_module1Credits = module1[7].ToString();
                        bool module1Credits_convert = int.TryParse(str_module1Credits, out int module1Credits);
                        module1Credits *= 4;

                        //storing first module's Semester
                        string str_module1Semester = module1[6].ToString();
                        bool module1Semester_convert = Int32.TryParse(str_module1Semester, out int module1Semester);
                        //MessageBox.Show(module1Semester.ToString());
                        
                        int semester = module1Semester % 2;
                   // MessageBox.Show(semester.ToString());
                        //calculating first module's Notional Learning Hours
                        int module1NotLrnHrs = module1Credits * 10;

                        int module1WeeklyStudyHrs = 0;
                        // if module1Semester 
                        if (module1Semester == 0)
                        {
                            module1WeeklyStudyHrs = (module1NotLrnHrs / weeksPerSemester) / 2;
                        }
                        else
                        {
                            module1WeeklyStudyHrs = module1NotLrnHrs / weeksPerSemester;
                        }
                    passingSemester1 = module1Semester;

                    passingM1Code = module1;   //Public variable: passing Module1 Code
                        passingM1Cred = module1Credits;   //Public variable: passing Module1 Credits
                        passingM1Not = module1NotLrnHrs;   //Public variable: passing Module1 Not_Lrn_Hrs
                        passingM1WklyHrs = module1WeeklyStudyHrs;      //Public variable: passing Module1 Wkly_Study_Hrs
                    
                    //END: Module_1 Code Validation

                }
                else
                {
                    passingM1Code = "00000000";
                }
                //END: Module_1 Validation

                //MODULE_2 Calculations
                if (String.IsNullOrEmpty(module2) == false)
                {
                    //calculating first module's Credits
                    string str_module2Credits = module2[7].ToString();
                    bool module2Credits_convert = int.TryParse(str_module2Credits, out int module2Credits);
                    module2Credits *= 4;



                    //storing first module's Semester
                    string str_module2Semester = module2[6].ToString();
                    bool module2Semester_convert = Int32.TryParse(str_module2Semester, out int module2Semester);
                    //MessageBox.Show(module1Semester.ToString());
                    int semester = module2Semester % 2;

                    //calculating first module's Notional Learning Hours
                    int module2NotLrnHrs = module2Credits * 10;
                    int module2WeeklyStudyHrs = 0;
                    if (module2Semester  == 0)
                    {
                        module2WeeklyStudyHrs = (module2NotLrnHrs / weeksPerSemester) / 2;
                    }
                    else
                    {
                        module2WeeklyStudyHrs = module2NotLrnHrs / weeksPerSemester;
                    }
                    passingSemester2 = module2Semester;
                    passingM2Code = module2;   //Public variable: passing Module2 Code
                    passingM2Cred = module2Credits;   //Public variable: passing Module2 Credits
                    passingM2Not = module2NotLrnHrs;   //Public variable: passing Module2 Not_Lrn_Hrs
                    passingM2WklyHrs = module2WeeklyStudyHrs;      //Public variable: passing Module2 Wkly_Study_Hrs

                }
                else
                {

                }
                if (String.IsNullOrEmpty(module3) == false)
                {
                    //calculating first module's Credits
                    string str_module3Credits = module3[7].ToString();
                    bool module3Credits_convert = int.TryParse(str_module3Credits, out int module3Credits);
                    module3Credits *= 4;

                    //storing first module's Semester
                    string str_module3Semester = module3[6].ToString();
                    bool module3Semester_convert = Int32.TryParse(str_module3Semester, out int module3Semester);
                    //MessageBox.Show(module1Semester.ToString());
                    int semester = module3Semester % 2;

                    //calculating first module's Notional Learning Hours
                    int module3NotLrnHrs = module3Credits * 10;
                    int module3WeeklyStudyHrs = 0;
                    if (module3Semester == 0)
                    {
                        module3WeeklyStudyHrs = (module3NotLrnHrs / weeksPerSemester) / 2;
                    }
                    else
                    {
                        module3WeeklyStudyHrs = module3NotLrnHrs / weeksPerSemester;
                    }
                    passingSemester3 = module3Semester;
                    passingM3Code = module3;   //Public variable: passing Module3 Code
                    passingM3Cred = module3Credits;   //Public variable: passing Module3 Credits
                    passingM3Not = module3NotLrnHrs;   //Public variable: passing Module3 Not_Lrn_Hrs
                    passingM3WklyHrs = module3WeeklyStudyHrs;      //Public variable: passing Module3 Wkly_Study_Hrs

                }
                if (String.IsNullOrEmpty(module4) == false)
                {
                    //calculating first module's Credits
                    string str_module4Credits = module4[7].ToString();
                    bool module42Credits_convert = int.TryParse(str_module4Credits, out int module4Credits);
                    module4Credits *= 4;

                    //storing first module's Semester
                    string str_module4Semester = module4[6].ToString();
                    bool module4Semester_convert = Int32.TryParse(str_module4Semester, out int module4Semester);
                    //MessageBox.Show(module1Semester.ToString());
                    int semester = module4Semester % 2;

                    //calculating first module's Notional Learning Hours
                    int module4NotLrnHrs = module4Credits * 10;
                    int module4WeeklyStudyHrs = 0;
                    if (module4Semester == 0)
                    {
                        module4WeeklyStudyHrs = (module4NotLrnHrs / weeksPerSemester) / 2;
                    }
                    else
                    {
                        module4WeeklyStudyHrs = module4NotLrnHrs / weeksPerSemester;
                    }
                    passingSemester4 = module4Semester;
                    passingM4Code = module4;   //Public variable: passing Module4 Code
                    passingM4Cred = module4Credits;   //Public variable: passing Module4 Credits
                    passingM4Not = module4NotLrnHrs;   //Public variable: passing Module4 Not_Lrn_Hrs
                    passingM4WklyHrs = module4WeeklyStudyHrs;      //Public variable: passing Module4 Wkly_Study_Hrs

                }
                if (String.IsNullOrEmpty(module5) == false)
                {
                    //calculating first module's Credits
                    string str_module5Credits = module5[7].ToString();
                    bool module5Credits_convert = int.TryParse(str_module5Credits, out int module5Credits);
                    module5Credits *= 4;

                    //storing first module's Semester
                    string str_module5Semester = module5[6].ToString();
                    bool module5Semester_convert = Int32.TryParse(str_module5Semester, out int module5Semester);
                    //MessageBox.Show(module1Semester.ToString());
                    int semester = module5Semester % 2;

                    //calculating first module's Notional Learning Hours
                    int module5NotLrnHrs = module5Credits * 10;
                    int module5WeeklyStudyHrs = 0;
                    if (module5Semester == 0)
                    {
                        module5WeeklyStudyHrs = (module5NotLrnHrs / weeksPerSemester) / 2;
                        
                    }
                    else
                    {
                        module5WeeklyStudyHrs = module5NotLrnHrs / weeksPerSemester;
                    }
                    passingSemester5 = module5Semester;
                    passingM5Code = module5;   //Public variable: passing Module5 Code
                    passingM5Cred = module5Credits;   //Public variable: passing Module5 Credits
                    passingM5Not = module5NotLrnHrs;   //Public variable: passing Module5 Not_Lrn_Hrs
                    passingM5WklyHrs = module5WeeklyStudyHrs;      //Public variable: passing Module5 Wkly_Study_Hrs

                }
                if (String.IsNullOrEmpty(module6) == false)
                {
                    //calculating first module's Credits
                    string str_module6Credits = module6[7].ToString();
                    bool module6Credits_convert = int.TryParse(str_module6Credits, out int module6Credits);
                    module6Credits *= 4;

                    //storing first module's Semester
                    string str_module6Semester = module6[6].ToString();
                    bool module6Semester_convert = Int32.TryParse(str_module6Semester, out int module6Semester);
                    //MessageBox.Show(module1Semester.ToString());
                    int semester = module6Semester % 2;

                    //calculating first module's Notional Learning Hours
                    int module6NotLrnHrs = module6Credits * 10;
                    int module6WeeklyStudyHrs = 0;
                    if (module6Semester == 0)
                    {
                        module6WeeklyStudyHrs = (module6NotLrnHrs / weeksPerSemester) / 2;
                    }
                    else
                    {
                        module6WeeklyStudyHrs = module6NotLrnHrs / weeksPerSemester;
                    }
                    passingSemester6 = module6Semester;
                    passingM6Code = module6;   //Public variable: passing Module6 Code
                    passingM6Cred = module6Credits;   //Public variable: passing Module6 Credits
                    passingM6Not = module6NotLrnHrs;   //Public variable: passing Module6 Not_Lrn_Hrs
                    passingM6WklyHrs = module6WeeklyStudyHrs;      //Public variable: passing Module6 Wkly_Study_Hrs

                }
                if (String.IsNullOrEmpty(module7) == false)
                {
                    //calculating first module's Credits
                    string str_module7Credits = module7[7].ToString();
                    bool module7Credits_convert = int.TryParse(str_module7Credits, out int module7Credits);
                    module7Credits *= 4;

                    //storing first module's Semester
                    string str_module7Semester = module7[6].ToString();
                    bool module7Semester_convert = Int32.TryParse(str_module7Semester, out int module7Semester);
                    //MessageBox.Show(module1Semester.ToString());
                    int semester = module7Semester % 2;

                    //calculating first module's Notional Learning Hours
                    int module7NotLrnHrs = module7Credits * 10;
                    int module7WeeklyStudyHrs = 0;
                    if (module7Semester == 0)
                    {
                        module7WeeklyStudyHrs = (module7NotLrnHrs / weeksPerSemester) / 2;
                    }
                    else
                    {
                        module7WeeklyStudyHrs = module7NotLrnHrs / weeksPerSemester;
                    }
                    passingSemester7 = module7Semester;
                    passingM7Code = module7;   //Public variable: passing Module7 Code
                    passingM7Cred = module7Credits;   //Public variable: passing Module7 Credits
                    passingM7Not = module7NotLrnHrs;   //Public variable: passing Module7 Not_Lrn_Hrs
                    passingM7WklyHrs = module7WeeklyStudyHrs;      //Public variable: passing Module7 Wkly_Study_Hrs

                }

                totalWeeklyHours = passingM1WklyHrs + passingM2WklyHrs + passingM3WklyHrs + passingM4WklyHrs
                    + passingM5WklyHrs + passingM6WklyHrs + passingM7WklyHrs;

                /*
                if (String.IsNullOrEmpty(passingM1Code) == true)
                {
                    passingM1Code = "00000000";
                }
                *//*
                if (hrsPerWeek1.Text == "0")
                {
                    MessageBox.Show("The First module code " + BeginAssignmentForm.passingM1Code + " is typed incorrectly, please click Redo");
                }
                if (hrsPerWeek2.Text == "0")
                {
                    if (hrsPerWeek2.Visible == true)
                    {
                        MessageBox.Show("The Second module code " + BeginAssignmentForm.passingM2Code + " is typed incorrectly, please click Redo");
                    }
                }
                if (hrsPerWeek3.Text == "0")
                {
                    if (hrsPerWeek3.Visible == true)
                    {
                        MessageBox.Show("The Third module code " + BeginAssignmentForm.passingM3Code + " is typed incorrectly, please click Redo");
                    }
                }
                if (hrsPerWeek4.Text == "0")
                {
                    if (hrsPerWeek4.Visible == true)
                    {
                        MessageBox.Show("The Fourth module code " + BeginAssignmentForm.passingM4Code + " is typed incorrectly, please click Redo");
                    }
                }
                if (hrsPerWeek5.Text == "0")
                {
                    if (hrsPerWeek5.Visible == true)
                    {
                        MessageBox.Show("The Fifth module code " + BeginAssignmentForm.passingM5Code + " is typed incorrectly, please click Redo");
                    }
                }
                if (hrsPerWeek6.Text == "0")
                {
                    if (hrsPerWeek6.Visible == true)
                    {
                        MessageBox.Show("The Sixth module code " + BeginAssignmentForm.passingM6Code + " is typed incorrectly, please click Redo");
                    }
                }
                if (hrsPerWeek7.Text == "0")
                {
                    if (hrsPerWeek7.Visible == true)
                    {
                        MessageBox.Show("The Seventh module code " + BeginAssignmentForm.passingM7Code + " is typed incorrectly, please click Redo");
                    }
                }*/
                if (String.IsNullOrEmpty(passingM2Code) == true)
                {
                    passingM2Code = "00000000";
                }

                if (String.IsNullOrEmpty(passingM3Code) == true)
                {
                    passingM3Code = "00000000";
                }

                if (String.IsNullOrEmpty(passingM4Code) == true)
                {
                    passingM4Code = "00000000";
                }

                if (String.IsNullOrEmpty(passingM5Code) == true)
                {
                    passingM5Code = "00000000";
                }

                if (String.IsNullOrEmpty(passingM6Code) == true)
                {
                    passingM6Code = "00000000";
                }

                if (String.IsNullOrEmpty(passingM7Code) == true)
                {
                    passingM7Code = "00000000";
                }               

                //Open Study Hours form
                this.Visible = false;
                StudyHoursForm openStudyHours = new StudyHoursForm();
                openStudyHours.ShowDialog();

            }   //END: Module TextBoxes Validation

        }   //END: Button Click


    }
}
