﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalApp.Shared.Domain
{
    public class Make : BaseDomainModel
    {
        public string? Name { get; set; }
        public new string? CreatedBy { get; set; }
        public new string? UpdatedBy { get; set; }
    }
}
