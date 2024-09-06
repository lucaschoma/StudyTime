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
    public partial class InstructionsForm : Form
    {
        public InstructionsForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;   //Hide the border
            //Capture the screen
            Bitmap timetablePicture = new Bitmap(this.Width, this.Height);
            DrawToBitmap(timetablePicture, new System.Drawing.Rectangle(0, 0, timetablePicture.Width, timetablePicture.Height));
            timetablePicture.Save("C:\\Users\\Public\\Downloads\\InstructionsPicture.bmp", ImageFormat.Bmp);

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;   //Show the border
            this.Close();

            //Open the Summary Form
            this.Hide();
            SummaryForm openSummary = new SummaryForm();
            openSummary.ShowDialog();
        }
    }
}
