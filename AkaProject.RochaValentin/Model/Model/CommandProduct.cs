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
    public class CommandProduct
    {
        public int ProductId { get; set; }

        public Product Product { get; set; }

        public int CommandId { get; set; }

        public Command Command { get; set; }

        public int Quantite { get; set; }
        
    }

    public class CommandProducttFluent : EntityTypeConfiguration<CommandProduct>
    {
        public CommandProducttFluent()
        {
            ToTable("T_CommandProduct");
            HasKey(c => new { c.ProductId, c.CommandId });

            Property(c => c.ProductId);
            HasRequired(c => c.Product).WithMany().HasForeignKey(c => c.ProductId);

            Property(c => c.CommandId);
            HasRequired(c => c.Command).WithMany().HasForeignKey(c => c.CommandId);

            Property(c => c.Quantite).IsRequired();
        }
    }
}
