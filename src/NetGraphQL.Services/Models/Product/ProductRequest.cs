﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetGraphQL.Services.Models.Product
{
    public class ProductRequest
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
