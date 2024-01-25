using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalApp.Shared.Domain
{
    public class Movie : BaseDomainModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public virtual Category Category { get; set; }
        public int Duration { get; set; }
        public string Rating { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal RentalPrice { get; set; }
        public virtual List<Rental> Rentals { get; set; } // Assuming 'Rental' is another entity, similar to 'Bookings'
        public virtual Make? Make { get; set; }
    }
}
