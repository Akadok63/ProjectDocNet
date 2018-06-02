using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Repository
{
    public class ClientRepository : BaseRepository
    {
        public Client Add(Client client)
        {
            this.Context.Clients.Add(client);
            this.Context.SaveChanges();

            return client;
        }
    }
}
