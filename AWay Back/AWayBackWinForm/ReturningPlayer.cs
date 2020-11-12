﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AWayBackWinForm
{
    public partial class ReturningPlayer : Form
    {
        public ReturningPlayer()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {

        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            //Creating a new instance of the awaybackinterface form
            AWayBackInterface awayBack = new AWayBackInterface();
            
            //Calling the new instance and showing the form
            awayBack.ShowDialog();
            
            //Closing the returning player form
            this.Close();
        }
    }
}
