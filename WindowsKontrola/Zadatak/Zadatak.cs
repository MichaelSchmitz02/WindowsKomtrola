using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Zadatak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void runProgramButton_Click(object sender, EventArgs e)
        {
            string selectedProgram = comboBox1.SelectedItem.ToString();
            switch (selectedProgram)
            {
                case "Notepad":
                    Process.Start("notepad.exe");
                    break;
                case "Paint":
                    Process.Start("mspaint.exe");
                    break;
                default:
                    MessageBox.Show("Please select a valid program.");
                    break;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            programNameTextBox.Text = "";
            programDescriptionTextBox.Text = "";
        }

        private void showActionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = showActionCheckBox.Checked;
        }

        private void messageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("This is a message", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaText formaText = new FormaText(this);
            formaText.Show();
        }

        public void SetProgramDetails(string name, string description)
        {
            programNameTextBox.Text = name;
            programDescriptionTextBox.Text = description;
        }
    }
}
