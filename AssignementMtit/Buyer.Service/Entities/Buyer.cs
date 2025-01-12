﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Buyer.Service.Entities
{
    public class Buyer: BuyerBaseEntity
    {
        public string Name { get; set; }
        public string Contact { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
