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

namespace Client
{
    /// <summary>
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        ClientCallback clback = null;
        bool canLoginRegistrate = false;

        public LoginWindow(ClientCallback cl)
        {
            InitializeComponent();
            clback = cl;
            clback.Message = (string msg) => { MessageBox.Show(msg); };
            clback.LoginSuccessed = () =>  { this.gbRoomMenu.IsEnabled = true; this.gbLoginMenu.IsEnabled = false; };
            clback.UpdateCount = (int count) => { this.lbActive.Text = "Active users: " + count.ToString(); };
            clback.UpdateClientRoom = (string[] r) => { this.lbRooms.ItemsSource = r; };
        }



        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            clback.Login(this.tbLogin.Text, this.tbPassword.Text);
        }

        private void btnRegistrate_Click(object sender, RoutedEventArgs e)
        {
            clback.Registration(this.tbLogin.Text, this.tbPassword.Text);
        }

        private void btnEnterToRoom_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCreateRoom_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void tbRoomName_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.btnCreateRoom.IsEnabled = this.tbRoomName.Text.Length > 3;
        }

        private void tbLogin_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.btnLogin.IsEnabled = this.tbLogin.Text.Length > 3 && this.tbPassword.Text.Length > 3;
            this.btnRegistrate.IsEnabled = this.tbLogin.Text.Length > 3 && this.tbPassword.Text.Length > 3;
        }

        private void tbPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.btnLogin.IsEnabled = this.tbLogin.Text.Length > 3 && this.tbPassword.Text.Length > 3;
            this.btnRegistrate.IsEnabled = this.tbLogin.Text.Length > 3 && this.tbPassword.Text.Length > 3;
        }
    }
}
