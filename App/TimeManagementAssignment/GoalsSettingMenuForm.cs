using Microsoft.Office.Interop.Word;
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
    public partial class GoalsSettingMenuForm : Form
    {
        public GoalsSettingMenuForm()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            /*
            //Hide the buttons and capture the window screen
            submitButton.Visible = false;
            backButton.Visible = false;
            Bitmap goalSettingPicture = new Bitmap(this.Width, this.Height);
            DrawToBitmap(goalSettingPicture, new System.Drawing.Rectangle(0, 0, goalSettingPicture.Width, goalSettingPicture.Height));
            goalSettingPicture.Save("C:\\Users\\Public\\Downloads\\goalSettingPicture.bmp", ImageFormat.Bmp);
            MessageBox.Show("Captured!");
            */
            //All Word documents on the PC need to close
            submitButton.Visible = false; 
            backButton.Visible = false;
            MessageBox.Show("Please scroll to the end of the Word document where there are questions that you need to complete for the purpose of Goal Setting. ");
            Bitmap timetablePicture = new Bitmap(this.Width, this.Height);
            DrawToBitmap(timetablePicture, new System.Drawing.Rectangle(0, 0, timetablePicture.Width, timetablePicture.Height));
            timetablePicture.Save("C:\\Users\\Public\\Downloads\\SummaryPicture.bmp", ImageFormat.Bmp);

            //Create and Open WordDoc
            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
            Document wordDoc = wordApp.Documents.Add();
            Range docRange = wordDoc.Range();


            //Create Document
            wordDoc.SaveAs2(@"C:\\Users\\Public\\Downloads\\tempWordDoc.docx");
            Document document = wordApp.Documents.Open(@"C:\\Users\\Public\\Downloads\\tempWordDoc.docx");

            Microsoft.Office.Interop.Word.Paragraph Q2;
            Q2 = wordDoc.Paragraphs.Add();
            Q2.Range.Text = "\r\n 1. List the subjects you had in High School. \r\n \r\n 2. Why did you choose these specific subjects? \r\n\r\n 3. Why did you come to University? \r\n\r\n 4. Why is it important to set academic goals for yourself? \r\n\r" +
                "\n 5. List at least one implication of not reaching your academic goals.  \r\n\r\n 6. Describe how you intend on planning for the semester. \r\n\r\n 7. Describe how you intend on sticking to your plan for the semester. \r\n";
            wordDoc.Application.Selection.InlineShapes.AddPicture(@"C:\\Users\\Public\\Downloads\\studyHoursPicture.bmp");
            wordDoc.Application.Selection.InlineShapes.AddPicture(@"C:\\Users\\Public\\Downloads\\activityA-Picture.bmp");
            wordDoc.Application.Selection.InlineShapes.AddPicture(@"C:\\Users\\Public\\Downloads\\activityB-Picture.bmp");
            wordDoc.Application.Selection.InlineShapes.AddPicture(@"C:\\Users\\Public\\Downloads\\activityC-Picture.bmp");
            wordDoc.Application.Selection.InlineShapes.AddPicture(@"C:\\Users\\Public\\Downloads\\timetablePicture.bmp");
            wordDoc.Application.Selection.InlineShapes.AddPicture(@"C:\\Users\\Public\\Downloads\\SummaryPicture.bmp");
            wordDoc.Application.Selection.InlineShapes.AddPicture(@"C:\\Users\\Public\\Downloads\\InstructionsPicture.bmp");
            //InstructionsPicture
            MessageBox.Show("Document created successfully!");



            // MessageBox.Show("Document created successfully! \nClick ok to open it...");

            //Re-open the MainMenu Form

            //MainMenuForm openMainMenu = new MainMenuForm();
            //openMainMenu.ShowDialog();
            //Visible = false;

            Close();
            /*
            //variables to hold saved images paths
            string studyHoursImagePath = @"C:\\Users\\Public\\Downloads\\studyHoursPicture.bmp";
            string actAImagePath = @"C:\\Users\\Public\\Downloads\\activityA-Picture.bmp";
            string actBImagePath = @"C:\\Users\\Public\\Downloads\\activityB-Picture.bmp";
            string actCImagePath = @"C:\\Users\\Public\\Downloads\\activityC-Picture.bmp";
            string weeklyTtableImagePath = @"C:\\Users\\Public\\Downloads\\timetablePicture.bmp";
            string goalSettImagePath = @"C:\\Users\\Public\\Downloads\\goalSettingPicture.bmp";

            // Create an InlineShape in the InlineShapes collection where the picture should be added later
            // It is used to get automatically scaled sizes.
            InlineShape autoScaledInlineShape = docRange.InlineShapes.AddPicture(actAImagePath);
            float scaledWidth = autoScaledInlineShape.Width;
            float scaledHeight = autoScaledInlineShape.Height;
            autoScaledInlineShape.Delete();

            // Create a new Shape and fill it with the picture
            Shape newShape = wordDoc.Shapes.AddShape(1, 0, 0, scaledWidth, scaledHeight);
            newShape.Fill.UserPicture(actAImagePath);

            // Convert the Shape to an InlineShape and optional disable Border
            InlineShape finalInlineShape = newShape.ConvertToInlineShape();
            //The following line of code was commented due to an error that it had, but the code works without it
            //==> finalInlineShape.Line.Visible = Microsoft.Office.Core.MsoTriState.msoFalse;

            // Cut the range of the InlineShape to clipboard
            finalInlineShape.Range.Cut();

            // And paste it to the target Range
            docRange.Paste();
            */
            //wordApp.Quit();

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            //Back to Weekly timetable Form
            this.Hide();
            WeeklyTimetableForm openTimeTable = new WeeklyTimetableForm();
            openTimeTable.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GoalsSettingMenuForm_Load(object sender, EventArgs e)
        {
            //Notional Learning hours
            notionalsummarylabel.Text = StudyHoursForm.PassingWeeklyhours.ToString() + " Hours";
            //Class A activities
            ClassAvalue.Text = ActivityAForm.PassingMinutesandHours.ToString() + " Hours";
            //Class B activites
            ClassBValue.Text = ActivityBForm.PassingMinutesandHours.ToString() + " Hours";
            // Class C activities
            ClassCValue.Text = ActivityCForm.PassingMinutesandHours.ToString() + " Hours";
            radio7dayweek.Select();
        }

        private void radio7dayweek_Enter(object sender, EventArgs e)
        {
            //Notional Learning hours
            notionalsummarylabel.Text = StudyHoursForm.PassingWeeklyhours.ToString() + " Hours";
            //Class A activities
            ClassAvalue.Text = ActivityAForm.PassingMinutesandHours.ToString() + " Hours";
            //Class B activites
            ClassBValue.Text = ActivityBForm.PassingMinutesandHours.ToString() + " Hours";
            // Class C activities
            ClassCValue.Text = ActivityCForm.PassingMinutesandHours.ToString() + " Hours";
        }

        private void radio6dayweek_Enter(object sender, EventArgs e)
        {
            //Notional Learning hours calculation

            //StudyHoursForm.PassingWeeklyhours * 0.858;
            double Notioal6Conversion = double.Parse(StudyHoursForm.PassingWeeklyhours) * 1.143;
            notionalsummarylabel.Text = Math.Round((Notioal6Conversion),0) + " Hours";
           
            //Class A activities
            double ClassA6Conversion = ActivityAForm.PassingMinutesandHours * 1.143;
            ClassAvalue.Text = Math.Round(ClassA6Conversion, 0) + " Hours";
            //Class B activites
            double ClassB6Conversion = ActivityBForm.PassingMinutesandHours * 1.143;
            ClassBValue.Text = Math.Round(ClassB6Conversion,0) + " Hours";
            // Class C activities
            double ClassC6Conversion = ActivityCForm.PassingMinutesandHours * 1.143;
            ClassCValue.Text = Math.Round(ClassC6Conversion,0) + " Hours";

            
        }

        private void radio5dayweek_Enter(object sender, EventArgs e)
        {
            //StudyHoursForm.PassingWeeklyhours * 0.858;
            double Notioal6Conversion = double.Parse(StudyHoursForm.PassingWeeklyhours) * 1.286;
            notionalsummarylabel.Text = Math.Round((Notioal6Conversion), 0) + " Hours";

            //Class A activities
            double ClassA6Conversion = ActivityAForm.PassingMinutesandHours * 1.286;
            ClassAvalue.Text = Math.Round(ClassA6Conversion, 0) + " Hours";
            //Class B activites
            double ClassB6Conversion = ActivityBForm.PassingMinutesandHours * 1.286;
            ClassBValue.Text = Math.Round(ClassB6Conversion, 0) + " Hours";
            // Class C activities
            double ClassC6Conversion = ActivityCForm.PassingMinutesandHours * 1.286;
            ClassCValue.Text = Math.Round(ClassC6Conversion, 0) + " Hours";
        }
    }
}
