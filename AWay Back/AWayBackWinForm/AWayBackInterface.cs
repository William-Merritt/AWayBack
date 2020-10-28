using System;
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
        private Player _player;
        public AWayBackInterface()
        {
            InitializeComponent();
            Builder.Build();
            Movement.MoveToStart();

        }


        private void moveNorthButton_Click(object sender, EventArgs e)
        {
            Movement.PlayerMovement("north");
            roomDescRichTextBox.Text = Player.CurrentRoom.Description;
            if (Player.CurrentRoom.ExitNorth != -1)
            {
                Movement.MovePlayer(IDA.Room[Player.CurrentRoom.ExitNorth]);
                DisplayCurrentRoom.CurrentRoom();
                Console.ReadLine();
            }
            else
            {
                Movement.moveHere = false;
            }

        }

        private void moveWestButton_Click(object sender, EventArgs e)
        {
            Movement.PlayerMovement("west");
            roomDescRichTextBox.Text = Player.CurrentRoom.Description;
            if (Player.CurrentRoom.ExitWest != -1)
            {
                Movement.MovePlayer(IDA.Room[Player.CurrentRoom.ExitWest]);
                DisplayCurrentRoom.CurrentRoom();
                Console.ReadLine();
            }
            else
            {
                Movement.moveHere = false;
            }

        }

        private void moveEastButton_Click(object sender, EventArgs e) 
        {
            Movement.PlayerMovement("east");
            roomDescRichTextBox.Text = Player.CurrentRoom.Description;

            if (Player.CurrentRoom.ExitEast != -1)
            {
                Movement.MovePlayer(IDA.Room[Player.CurrentRoom.ExitEast]);
                DisplayCurrentRoom.CurrentRoom();
                Console.ReadLine();
            }
            else
            {
                Movement.moveHere = false;
            }
        }

        private void moveSouthButton_Click(object sender, EventArgs e)
        {
            Movement.PlayerMovement("south");
            roomDescRichTextBox.Text = Player.CurrentRoom.Description;
            if (Player.CurrentRoom.ExitSouth != -1)
            {
                Movement.MovePlayer(IDA.Room[Player.CurrentRoom.ExitSouth]);
                DisplayCurrentRoom.CurrentRoom();
                Console.ReadLine();
            }
            else
            {
                Movement.moveHere = false;
            }
        }

        private void combatButton_Click(object sender, EventArgs e)
        {
            Battle.CommenceCombat("attack", _player);

        }
    }
}
