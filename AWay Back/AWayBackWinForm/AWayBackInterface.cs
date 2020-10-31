﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameWorld;

namespace AWayBackWinForm
{
    public partial class AWayBackInterface : Form
    {
        public AWayBackInterface()
        {
            InitializeComponent();
            Builder.Build();
            Movement.MoveToStart();
        }


        private void moveNorthButton_Click(object sender, EventArgs e)
        {
            NextArea.MoveTo("north");
            roomDescRichTextBox.Text = Player.CurrentRoom.RoomName + Environment.NewLine;
            roomDescRichTextBox.Text += Player.CurrentRoom.Description;
        }

        private void moveWestButton_Click(object sender, EventArgs e)
        {
            NextArea.MoveTo("west");
            roomDescRichTextBox.Text = Player.CurrentRoom.RoomName + Environment.NewLine;
            roomDescRichTextBox.Text += Player.CurrentRoom.Description;

        }

        private void moveEastButton_Click(object sender, EventArgs e) 
        {
            NextArea.MoveTo("east");
            roomDescRichTextBox.Text = Player.CurrentRoom.RoomName + Environment.NewLine;
            roomDescRichTextBox.Text += Player.CurrentRoom.Description;
        }

        private void moveSouthButton_Click(object sender, EventArgs e)
        {
            NextArea.MoveTo("south");
            roomDescRichTextBox.Text = Player.CurrentRoom.RoomName + Environment.NewLine;
            roomDescRichTextBox.Text += Player.CurrentRoom.Description;
        }

        private void combatButton_Click(object sender, EventArgs e)
        {
            
        }

        private void lookButton_Click(object sender, EventArgs e)
        {

        }
    }
}
