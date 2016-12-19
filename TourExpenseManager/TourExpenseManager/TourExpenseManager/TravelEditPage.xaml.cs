using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace TourExpenseManager
{
    public partial class TravelEditPage : ContentPage
    {
        public TravelEditPage()
        {
            InitializeComponent();
        }


        private async void HandleSubmit(object sender,EventArgs e)
        {

            await Navigation.PopAsync();

        }

    }
}
