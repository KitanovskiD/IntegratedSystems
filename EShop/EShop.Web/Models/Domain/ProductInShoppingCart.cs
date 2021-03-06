﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Web.Models.Domain
{
    public class ProductInShoppingCart
    {
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        public Guid ShoppingCartId { get; set; }
        public ShoppingCart Cart { get; set; }
    }
}
