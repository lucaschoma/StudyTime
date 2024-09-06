using Microsoft.Office.Interop.Word;
using Word = Microsoft.Office.Interop.Word;
using WordDocument = Microsoft.Office.Interop.Word.Document;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace TimeManagementAssignment
{
    public partial class SummaryForm : Form
    {
        
        public SummaryForm()
        {
            InitializeComponent();
        }
        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("HH-mm-ss");
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            //All Word documents on the PC need to close
            //Microsoft.Office.Interop.Word._Document document = this.Application.ActiveDocument;
            //oDoc.SaveAs("MyFile.doc", ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing);

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;   //Hide the border
            submitButton.Visible = false;
            backButton.Visible = false;
            MessageBox.Show("Please scroll to the end of the Word document where there are questions that you need to complete for the purpose of Goal Setting. ", "CREATING WORD DOCUMENT");
            Bitmap timetablePicture = new Bitmap(this.Width, this.Height);
            DrawToBitmap(timetablePicture, new System.Drawing.Rectangle(0, 0, timetablePicture.Width, timetablePicture.Height));
            timetablePicture.Save("C:\\Users\\Public\\Downloads\\SummaryPicture.bmp", ImageFormat.Bmp);

            //Create and Open WordDoc
            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
            Document wordDoc = wordApp.Documents.Add();
            Range docRange = wordDoc.Range();

            //set document paths
            // var random = new Random(999);
            //PUT this code above the button click

            //PUT this code inside the button click
            String timeStamp = GetTimestamp(DateTime.Now);

            string tempDocPath = @"C:\\Users\\Public\\Downloads\\" + MainMenuForm.passingStdNmbr + "_" + timeStamp.ToString() + "_" + "TimeManagement_Goalsetting.docx";
            /*
            //Check if the Word Doc file exist
            //complex method: check existence and open the file
            try
            { // Get the current directory.  
                String path = Directory.GetCurrentDirectory();
                String target = @ "D:\temp";
                Message.Show("The current directory is {0}", path);
                if (!Directory.Exists(target))
                {
                    Directory.CreateDirectory(target);
                } 
                // Change the current directory.Environment.Current Directory = (target);
                if (path.Equals(Directory.GetCurrentDirectory()))
                {
                    Message.Show("You are in the temp directory.");
                }
                Else {
                    Message.Show("You are not in the temp directory.");
                }
            }
            catch (Exception e)
            {
                Message.Show("The process failed: {0}", e.ToString());
            }

            OR
            //simple method
            if (File.Exists("MyFile.txt"))
            {
                Message.Show("File exists...");
            } 
            else
            {
                Message.Show("File does not exist in the current directory!");
            }
            */
            /*
            System.IO.FileStream file = null;
            //Check if the file is open
            try
            {
                //Try to open the file if it exists but not open
                file = System.IO.File.Open(tempDocPath, System.IO.FileMode.CreateNew, System.IO.FileAccess.ReadWrite, System.IO.FileShare.None);
                
            }
            catch (System.IO.IOException ex)
            {
                //ex.Message
            }

            finally
            {
                if (file != null)
                {
                    file.Close();
                    file.Dispose();
                }
            }

            //Close the Word document
            //wordDoc = _Application.Documents[tempDocPath] as Microsoft.Office.Interop.Word._Document;
            wordDoc.Close(WdSaveOptions.wdDoNotSaveChanges, WdOriginalFormat.wdWordDocument);   //Close the word document
            wordApp.Quit(WdSaveOptions.wdPromptToSaveChanges, WdOriginalFormat.wdWordDocument);    //Close the word application
            */

            //Save and open the document
            wordDoc.SaveAs2(tempDocPath);   //save document
            Document document = wordApp.Documents.Open(tempDocPath);    //open the created document

            Microsoft.Office.Interop.Word.Paragraph Q2;
            Q2 = wordDoc.Paragraphs.Add();
            Q2.Range.Text = "\r\n  \r\n \r\n  \r\n\r\n 1. Why did you come to University? \r\n\r\n 2. Why is it important to set academic goals for yourself? \r\n\r" +
                "\n 3. List at least one implication of not reaching your academic goals.  \r\n\r\n 4. Describe how you intend on planning for the semester. \r\n\r\n 5. Describe how you intend on sticking to your plan for the semester. \r\n";

            wordDoc.Application.Selection.InlineShapes.AddPicture(@"C:\\Users\\Public\\Downloads\\studyHoursPicture.bmp");
            wordDoc.Application.Selection.InlineShapes.AddPicture(@"C:\\Users\\Public\\Downloads\\activityA-Picture.bmp");
            wordDoc.Application.Selection.InlineShapes.AddPicture(@"C:\\Users\\Public\\Downloads\\activityB-Picture.bmp");
            wordDoc.Application.Selection.InlineShapes.AddPicture(@"C:\\Users\\Public\\Downloads\\activityC-Picture.bmp");
            wordDoc.Application.Selection.InlineShapes.AddPicture(@"C:\\Users\\Public\\Downloads\\timetablePicture.bmp");
            wordDoc.Application.Selection.InlineShapes.AddPicture(@"C:\\Users\\Public\\Downloads\\SummaryPicture.bmp");
            wordDoc.Application.Selection.InlineShapes.AddPicture(@"C:\\Users\\Public\\Downloads\\InstructionsPicture.bmp");



            //Close the Word document

            //wordDoc = _Application.Documents[tempDocPath] as Microsoft.Office.Interop.Word._Document;
            //Upon click only


            // wordDoc.Close(WdSaveOptions.wdSaveChanges, WdOriginalFormat.wdWordDocument);   //Close the word document
            // wordApp.Quit(WdSaveOptions.wdPromptToSaveChanges, WdOriginalFormat.wdWordDocument);    //Close the word application


            this.Close();
            System.Windows.Forms.Application.Exit();

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

        private void GoalsSettingMenuForm_Load(object sender, EventArgs e)
        {
            //Notional Learning hours
            notionalHoursSummary.Text = StudyHoursForm.PassingWeeklyhours.ToString() + " Hours";
            //Class A activities
            ClassAHrsSummary.Text = ActivityAForm.PassingMinutesAndHours.ToString() + " Hours";
            //Class B activites
            ClassBHrsSummary.Text = ActivityBForm.PassingMinutesAndHours.ToString() + " Hours";
            // Class C activities
            ClassCHrsSummary.Text = ActivityCForm.PassingMinutesAndHours.ToString() + " Hours";
            radio7dayWeek.Select();
            this.Hide();

        }

        private void radio7dayweek_Enter(object sender, EventArgs e)
        {
            //Notional Learning hours
            notionalHoursSummary.Text = StudyHoursForm.PassingWeeklyhours.ToString() + " Hours";
            //Class A activities
            ClassAHrsSummary.Text = ActivityAForm.PassingMinutesAndHours.ToString() + " Hours";
            //Class B activites
            ClassBHrsSummary.Text = ActivityBForm.PassingMinutesAndHours.ToString() + " Hours";
            // Class C activities
            ClassCHrsSummary.Text = ActivityCForm.PassingMinutesAndHours.ToString() + " Hours";
        }

        private void radio6dayweek_Enter(object sender, EventArgs e)
        {
            //Notional Learning hours calculation

            //StudyHoursForm.PassingWeeklyhours * 0.858;
            double Notioal6Conversion = double.Parse(StudyHoursForm.PassingWeeklyhours) * 1.143;
            notionalHoursSummary.Text = Math.Round((Notioal6Conversion),0) + " Hours";
           
            //Class A activities
            double ClassA6Conversion = ActivityAForm.PassingMinutesAndHours * 1.143;
            ClassAHrsSummary.Text = Math.Round(ClassA6Conversion, 0) + " Hours";
            //Class B activites
            double ClassB6Conversion = ActivityBForm.PassingMinutesAndHours * 0.858;
            ClassBHrsSummary.Text = Math.Round(ClassB6Conversion,0) + " Hours";
            // Class C activities
            double ClassC6Conversion = ActivityCForm.PassingMinutesAndHours * 0.858;
            ClassCHrsSummary.Text = Math.Round(ClassC6Conversion,0) + " Hours";

            
        }

        private void radio5dayweek_Enter(object sender, EventArgs e)
        {
            //StudyHoursForm.PassingWeeklyhours * 0.858;
            double Notioal6Conversion = double.Parse(StudyHoursForm.PassingWeeklyhours) * 1.286;
            notionalHoursSummary.Text = Math.Round((Notioal6Conversion), 0) + " Hours";

            //Class A activities
            double ClassA6Conversion = ActivityAForm.PassingMinutesAndHours * 1.286;
            ClassAHrsSummary.Text = Math.Round(ClassA6Conversion, 0) + " Hours";
            //Class B activites
            double ClassB6Conversion = ActivityBForm.PassingMinutesAndHours * 0.714;
            ClassBHrsSummary.Text = Math.Round(ClassB6Conversion, 0) + " Hours";
            // Class C activities
            double ClassC6Conversion = ActivityCForm.PassingMinutesAndHours * 0.714;
            ClassCHrsSummary.Text = Math.Round(ClassC6Conversion, 0) + " Hours";
        }
    }
}
