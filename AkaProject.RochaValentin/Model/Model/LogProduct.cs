using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    [Table("T_LogProduct")]
    class LogProduct
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("LogProductId")]
        private int Id { get; set; }

        [Column("Message")]
        [StringLength(100)]
        private String Message { get; set; }

        [Column("Date")]
        private DateTime Date { get; set; }

        [ForeignKey("ProductId")]
        private Product ProductId { get; set; }

        public LogProduct()
        {

        }
    }
}
