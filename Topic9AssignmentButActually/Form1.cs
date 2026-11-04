using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic9AssignmentButActually
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            if (btnGreen.Enabled == false)
            {
                imgCharacter.Visible = true;
                lblStatus.ForeColor = Color.LimeGreen;
                lblStatus.Text = "Status: Ominous Big Green Button Clicked";
                btnSubmit.Text = "Fool.";
                btnSubmit.Enabled = false;
            }
            else
            {
                imgCharacter.Visible = true;
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "Status: Ominous Big Red Button Clicked";
                btnSubmit.Text = "Fool.";
                btnSubmit.Enabled = false;
            }

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            if (imgCharacter.Visible = true)
            {
                Close();
            }
            else
            {

            }

        }

        private void imgCharacter_Click(object sender, EventArgs e)
        {
            imgCharacter.Visible = false;

        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            BackColor = Color.Green;
            btnSubmit.BackColor = Color.Green;
            btnSubmit.ForeColor = Color.MediumSpringGreen;
            lblStatus.ForeColor = Color.MediumSpringGreen;
            lblStatus.Text = "Status: Green";
            imgCharacter.BackColor = Color.MediumSpringGreen;
            btnQuit.BackColor = Color.Green;
            btnQuit.ForeColor = Color.MediumSpringGreen;
            btnGreen.Enabled = false;
            btnGreen.Visible = false;
            imgCharacter.Width = 400;
            lblInstruction.ForeColor = Color.MediumSpringGreen;
        }

        private void imgCharacter_Resize(object sender, EventArgs e)
        {
            lblThwomp.Visible = true;
        }
    }
}
