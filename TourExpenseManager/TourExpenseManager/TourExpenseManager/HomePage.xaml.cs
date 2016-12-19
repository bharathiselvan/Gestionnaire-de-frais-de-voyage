using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace TourExpenseManager
{
    public partial class HomePage : ContentPage
    {
        private const string USERNAME = "admin";
        private const string PASSWORD = "abc@123";

        public HomePage()
        {
            InitializeComponent();
        }

        private async void HandleLogin(object sender,EventArgs e)
        {
            if(!string.Equals(userName.Text,USERNAME))
            {
                await DisplayAlert("Login Failed", string.Format("Invalid User {0}",userName), "OK");
                return;
            }

            if (!string.Equals(password.Text, PASSWORD))
            {
                await DisplayAlert("Login Failed", "Password mismatch", "OK");
                return;
            }
            
            await Navigation.PushAsync(new NavigationPage( new TravelListsPage()));
        }
    }
}
