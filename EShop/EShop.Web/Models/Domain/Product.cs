using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Web.Models.Domain
{
    public class Product
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDescripton { get; set; }
        public string ProductImage { get; set; }
        public  double ProductRating { get; set; }

        public virtual ICollection<ProductInShoppingCart> ShoppingCarts { get; set; }

        public Product() { }
    }
}
