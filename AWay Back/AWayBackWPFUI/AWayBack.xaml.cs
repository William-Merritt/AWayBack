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
    /// Interaction logic for AWayBack.xaml
    /// </summary>
    public partial class AWayBack : Window
    {
        public AWayBack()
        {
            InitializeComponent();
            Builder.Build();
            Movement.MoveToStart();
        }

        private void westButton_Click(object sender, RoutedEventArgs e)
        {
            Movement.PlayerMovement("west");
            CurrentRoomTextBlock.Text = Player.CurrentRoom.RoomName;
        }

        private void eastButton_Click(object sender, RoutedEventArgs e)
        {
            Movement.PlayerMovement("east");
            CurrentRoomTextBlock.Text = Player.CurrentRoom.RoomName;
        }

        private void southButton_Click(object sender, RoutedEventArgs e)
        {
            Movement.PlayerMovement("south");
            CurrentRoomTextBlock.Text = Player.CurrentRoom.RoomName;
        }

        private void northButton_Click(object sender, RoutedEventArgs e)
        {
           
            Movement.PlayerMovement("north");
            CurrentRoomTextBlock.Text = Player.CurrentRoom.RoomName;
        }

        private void scanButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void lookButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void attackButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
