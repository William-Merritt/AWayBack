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

        public Player player = new Player("Thor", "Trapper", "Monster1.", 100, "Elf");
        public Mobs mob = new Mobs(4, "Slasher", "Agile mob. Dangerous to get close", "poison", "blast", 150, "Demon");
        public Items item = new Items(405, "Radio", "Device can be used for communitcation", "2", 25);

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
            Battle.CommenceCombat("attack", player);
            combatRichTextBox.Text = $"Player health after combat is --> {player.Health}";
        }

        private void lookButton_Click(object sender, EventArgs e)
        {
            Look.lookForVerb("look");
            enviromentRichTextBox.Text = Look.MobFound(mob);
        }

        private void btnCheckInventory_Click(object sender, EventArgs e)
        {
            inventoryRichTextBox.Text = item.ItemName + Environment.NewLine;
            inventoryRichTextBox.Text += item.ItemDescription + Environment.NewLine;
        }
    }
}
