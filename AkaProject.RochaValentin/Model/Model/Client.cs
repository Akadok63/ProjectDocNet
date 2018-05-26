using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    public class Client
    {
        public int Id { get; set; }

        public String Nom { get; set; }

        public String Prenom { get; set; }

        public int Actif { get; set; }
        
    }

    public class ClientFluent : EntityTypeConfiguration<Client>
    {
        public ClientFluent()
        {
            ToTable("T_Client");
            HasKey(c => c.Id);
            Property(c => c.Id).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Nom).IsRequired().HasMaxLength(50);
            Property(c => c.Prenom).IsRequired().HasMaxLength(50);
            Property(c => c.Actif).IsRequired();
        }
    }
}
