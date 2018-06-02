using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Repository
{
    public class LogProductRepository : BaseRepository
    {
        public Model.LogProduct Add(LogProduct log)
        {
            this.Context.LogProducts.Add(log);
            this.Context.SaveChanges();

            return log;
        }
    }
}
