﻿using EShop.Web.Models.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Web.Models.Domain
{
    public class ShoppingCart
    {
        public Guid Id { get; set; }
        public string OwnerId { get; set; }
        public virtual EShopApplicationUser Owner { get; set; }
        public virtual ICollection<ProductInShoppingCart> Products { get; set; }

        public ShoppingCart() { }
    }
}
