using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    [Table("T_CommProd")]
    class CommandProduct
    {
        [Key]
        [ForeignKey("ProductId")]
        private Product Product_Id { get; set; }

        [Key]
        [ForeignKey("CommandId")]
        private Command Commande_Id { get; set; }

        [Column("Quantite")]
        private int Quantite { get; set; }

        public CommandProduct()
        {

        }
    }
}
