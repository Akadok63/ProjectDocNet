using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    [Table("T_Command")]
    class Command
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("CommandId")]
        private int Id { get; set; }

        [Column("DateCommande")]
        private DateTime Date_Commande { get; set; }

        [Column("Observation")]
        [StringLength(200)]
        private String Observation { get; set; }

        [ForeignKey("StatutId")]
        private Statut StatutId { get; set; }

        [ForeignKey("ClientId")]
        private Client ClientId { get; set; }

        public Command()
        {

        }
    }
}
