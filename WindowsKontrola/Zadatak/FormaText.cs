using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak
{
    public partial class FormaText : Form
    {
        private Form1 mainForm;

        public FormaText(Form1 form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            mainForm.SetProgramDetails(programNameTextBox.Text, programDescriptionTextBox.Text);
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
