using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalApp.Shared.Domain
{
    public abstract class BaseDomainModel
    {
        public int Id { get; set; } // Assuming 'Id' should be of type int. Use 'Guid' if you prefer.

        public DateTime DateCreated { get; set; }

        public DateTime DateUpdated { get; set; }

        public string? CreatedBy { get; set; }

        public string? UpdatedBy { get; set; }
    }
}
