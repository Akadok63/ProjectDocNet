using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Repository
{
    public class CategoryRepository : BaseRepository
    {
        public Category Add(Category category)
        {
            this.Context.Categories.Add(category);
            this.Context.SaveChanges();

            return category;
        }
    }
}
