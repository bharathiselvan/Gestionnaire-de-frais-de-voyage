using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourExpenseManager.Models
{
    public class Travel
    {

        public int Id { get; set; }

        public string Location { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Period
        {
            get
            {
                return string.Format("{0} - {1}", StartDate.ToString("MMM d,yyyy"), EndDate.ToString("MMM d, yyyy"));
            }
        }

    }
}
