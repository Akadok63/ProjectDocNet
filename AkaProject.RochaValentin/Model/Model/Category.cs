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
    public class Category
    {
        public int Id { get; set; }

        public String Libelle { get; set; }

        public int Actif { get; set; }

    }

    public class CategoryFluent : EntityTypeConfiguration<Category>
    {
        public CategoryFluent()
        {
            ToTable("T_Category");
            HasKey(c => c.Id);

            Property(c => c.Id).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Libelle).IsRequired().HasMaxLength(50);
            Property(c => c.Actif).IsRequired();
        }
    }
}
