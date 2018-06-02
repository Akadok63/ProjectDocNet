using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Repository
{
    public class CommandRepository : BaseRepository
    {
        public Command Add(Command command)
        {
            this.Context.Commands.Add(command);
            this.Context.SaveChanges();

            return command;
        }
    }
}
