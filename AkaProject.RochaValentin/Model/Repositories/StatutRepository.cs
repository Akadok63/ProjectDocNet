using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Repository
{
    public class StatutRepository : BaseRepository
    {
        public Statut Add(Statut statut)
        {
            this.Context.Statuts.Add(statut);
            this.Context.SaveChanges();

            return statut;
        } 
    }
}
