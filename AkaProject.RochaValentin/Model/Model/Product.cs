using Model.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    
    public class Product
    {
        public int Id { get; set; }

        public int Code { get; set; }

        public String Description { get; set; }

        public int Actif { get; set; }

        public int Stock { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
        
    }

    public class ProductFluent : EntityTypeConfiguration<Product>
    {
        public ProductFluent()
        {
            ToTable("T_Product");
            HasKey(c => c.Id);

            Property(c => c.Id).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Code).IsRequired();
            Property(c => c.Description).IsRequired().HasMaxLength(100);
            Property(c => c.Actif).IsRequired();
            Property(c => c.Stock).IsRequired();

            Property(c => c.CategoryId);
            HasRequired(c => c.Category).WithMany().HasForeignKey(c => c.CategoryId);
        }
    }
}
