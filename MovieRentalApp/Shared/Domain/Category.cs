using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalApp.Shared.Domain
{
    public class Category : BaseDomainModel
    {
        public int CategoryID { get; set; }
        public string? Name { get; set; } // Make nullable if it can be null
        public DateTime LastUpdated { get; set; }
    }
}
