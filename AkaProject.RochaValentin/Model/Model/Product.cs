using Model.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    [Table("T_Product")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("ProductID")]
        private int ProductId { get; set; }

        [Column("Code")]
        [Required]
        private int Code { get; set; }

        [StringLength(50)]
        [Column("Description")]
        private String Description { get; set; }

        [Column("Actif")]
        [Required]
        private int Actif { get; set; }

        [Column("Stock")]
        [Required]
        private int Stock { get; set; }

        [ForeignKey("CategoryId")]
        private Category CategoryId { get; set; }

        public Product()
        {

        }
    }
}
