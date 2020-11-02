using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using GameWorld;

namespace AWayBackWPFUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Player player = new Player("Thor", "Trapper", "Monster1.", 100, "Elf");
        public Mobs mob = new Mobs(4, "Slasher", "Agile mob. Dangerous to get close", "poison", "blast", 150, "Demon");

        public MainWindow()
        {
            InitializeComponent();
            Builder.Build();
            Movement.MoveToStart();
        }

        private void attackButton_Click(object sender, RoutedEventArgs e)
        {
            Battle.CommenceCombat("attack", player);
            CombatTextBlock.Text = $"Player health after combat is --> {player.Health}";
        }

        private void scanButton_Click(object sender, RoutedEventArgs e)
        {
            //To be determined
        }

        private void lookButton_Click(object sender, RoutedEventArgs e)
        {
            Look.lookForVerb("look");
            EnviromentTextBlock.Text = Look.MobFound(mob);
        }

        private void northButton_Click(object sender, RoutedEventArgs e)
        {
            NextArea.MoveTo("north");
            CurrentRoomTextBlock.Text = Player.CurrentRoom.RoomName + Environment.NewLine;
            CurrentRoomTextBlock.Text += Player.CurrentRoom.Description;
        }

        private void eastButton_Click(object sender, RoutedEventArgs e)
        {
            NextArea.MoveTo("east");
            CurrentRoomTextBlock.Text = Player.CurrentRoom.RoomName + Environment.NewLine;
            CurrentRoomTextBlock.Text += Player.CurrentRoom.Description;
        }

        private void westButton_Click(object sender, RoutedEventArgs e)
        {
            NextArea.MoveTo("west");
            CurrentRoomTextBlock.Text = Player.CurrentRoom.RoomName + Environment.NewLine;
            CurrentRoomTextBlock.Text += Player.CurrentRoom.Description;
        }

        private void southButton_Click(object sender, RoutedEventArgs e)
        {
            NextArea.MoveTo("south");
            CurrentRoomTextBlock.Text = Player.CurrentRoom.RoomName + Environment.NewLine;
            CurrentRoomTextBlock.Text += Player.CurrentRoom.Description;
        }
    }
}
