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
    public class LogProduct
    {
        public int Id { get; set; }

        public String Message { get; set; }

        public DateTime Date { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }
        
    }
        public class LogProductFluent : EntityTypeConfiguration<LogProduct>
    {
        public LogProductFluent()
        {
            ToTable("T_LogProduct");
            HasKey(c => c.Id);

            Property(c => c.Id).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Message).IsRequired().HasMaxLength(50);
            Property(c => c.Date).IsRequired();

            Property(c => c.ProductId);
            HasRequired(c => c.Product).WithMany().HasForeignKey(c => c.ProductId);
        }
    }
}
