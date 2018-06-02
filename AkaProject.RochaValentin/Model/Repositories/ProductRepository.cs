using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Repository
{
    public class ProductRepository : BaseRepository
    {
      public Product Add(Product prod)
        {
            this.Context.Products.Add(prod);
            this.Context.SaveChanges();

            return prod;
        }
        public List<Product> List()
        {
            return this.Context.Products.ToList();
        }

    }
}
