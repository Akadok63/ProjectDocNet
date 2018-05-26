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
    public class Command
    {
        public int Id { get; set; }

        public DateTime DateCommande { get; set; }
        
        public String Observation { get; set; }

        public int StatutId { get; set; }

        public Statut Statut { get; set; }
        
        public int ClientId { get; set; }

        public Client Client { get; set; }

    }

    public class CommandFluent : EntityTypeConfiguration<Command>
    {
        public CommandFluent()
        {
            ToTable("T_Command");
            HasKey(c => c.Id);

            Property(c => c.Id).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Observation).IsRequired().HasMaxLength(50);
            Property(c => c.DateCommande).IsRequired();

            Property(c => c.StatutId);
            HasRequired(c => c.Statut).WithMany().HasForeignKey(c => c.StatutId);
            Property(c => c.ClientId);
            HasRequired(c => c.Client).WithMany().HasForeignKey(c => c.ClientId);
        }
    }
}
