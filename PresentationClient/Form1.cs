using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PresentationClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RegistrationLabel.Text = "R\nE\nG\nI\nS\nT\nR\nA\nT\nI\nO\nN";
            AddComponentsToHeadPanel addHead = new AddComponentsToHeadPanel(HeadPanel, this);
            addHead.addButtons();
        }

        private void RegistrationMovePanel_Click(object sender, EventArgs e)
        {
            
        }
    }
}
