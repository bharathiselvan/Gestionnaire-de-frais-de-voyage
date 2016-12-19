using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourExpenseManager.Services;
using Xamarin.Forms;

namespace TourExpenseManager
{
    public partial class TravelListsPage : ContentPage
    {

        private TravelService _travelService;

        public TravelListsPage()
        {
            InitializeComponent();
            
            _travelService = new TravelService();

            travelList.ItemsSource = _travelService.GetMockedTravelLists();            
        }

        private async void HandleActivated(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TravelEditPage());
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}
