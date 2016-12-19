using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourExpenseManager.Models;

namespace TourExpenseManager.Services
{
    public class TravelService
    {

        private List<Travel> _travels;

        public TravelService()
        {
            _travels = new List<Travel>();
        }

        public void Add(Travel travel)
        {
            _travels.Add(travel);
        }

        public void Delete(int id)
        {
            _travels.RemoveAll(t => t.Id == id);
        }

        public void Update(Travel travel)
        {

        }

        public List<Travel> GetTravels()
        {
            return _travels;
        }

        public List<Travel> GetMockedTravelLists()
        {
            return new List<Travel>()
            {
                new Travel() { Id =1, Location = "Ladhak", StartDate = new DateTime(2016,9,1), EndDate = new DateTime(2016,9,10) },
                new Travel() { Id =2, Location = "Thailand", StartDate = new DateTime(2016,8,1), EndDate = new DateTime(2016,8,10) },
                new Travel() { Id =3, Location = "Paris", StartDate = new DateTime(2016,6,1), EndDate = new DateTime(2016,6,10) },
                new Travel() { Id =4, Location = "Darjeeling", StartDate = new DateTime(2016,10,1), EndDate = new DateTime(2016,10,10) },
                new Travel() { Id =5, Location = "Chandigarh", StartDate = new DateTime(2016,11,1), EndDate = new DateTime(2016,11,10) },

                new Travel() { Id =1, Location = "Ladhak", StartDate = new DateTime(2016,9,1), EndDate = new DateTime(2016,9,10) },
            };
        }




    }
}
