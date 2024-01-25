using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalApp.Shared.Domain
{
    public class Make : BaseDomainModel
    {
        public string? Name { get; set; }
        public string? CreatedBy { get; set; }

        public string? UpdatedBy { get; set; }
    }
}
