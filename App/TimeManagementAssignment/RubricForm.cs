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
    public partial class RubricForm : Form
    {
        public RubricForm()
        {
            InitializeComponent();
        }

        //Back to Main Menu Form
        private void closeRubricButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenuForm openMainForm = new MainMenuForm();
            openMainForm.ShowDialog();
        }
    }
}
