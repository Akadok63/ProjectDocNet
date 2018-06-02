using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Repository
{
    class CommandProductRepository : BaseRepository
    {
        public CommandProduct Add(CommandProduct command)
        {
            this.Context.CommandProducts.Add(command);
            this.Context.SaveChanges();

            return command;
        }
    }
}
