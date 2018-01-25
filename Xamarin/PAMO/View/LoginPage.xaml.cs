using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace PAMO
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void Button_OnClickedAsync(object sender, EventArgs e)
        {
            string login = usernameEntry.Text;
            string paswword = passwordEntry.Text;
            string token = await App.UserManager.isLogin(login, paswword);

            if (!token.Equals(""))
            {
                try
                {
                    User newUser = new User(login, token);
                    HomePage home = new HomePage();
                    await this.Navigation.PushAsync(home);
                }
                catch (Exception NPA)
                {
                    Debug.WriteLine(@"ERROR {0}", NPA.Message);
                }
            }
            else
            {
                messageLabel.Text = "Wrong login or passord";
            }
        }
    }
}
