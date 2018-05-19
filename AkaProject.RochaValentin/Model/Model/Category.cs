using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    [Table("T_Category")]
    class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("CategoryID")]
        private int CategoryId { get; set; }

        [StringLength(50)]
        [Column("Libelle")]
        private String Libelle { get; set; }

        [Column("Actif")]
        [Required]
        private int Actif { get; set; }


        public Category()
        {

        }
    }
}
