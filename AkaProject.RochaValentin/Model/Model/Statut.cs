using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    [Table("T_Statut")]
    class Statut
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("StatutId")]
        private int Id { get; set; }

        [Column("Libelle")]
        [StringLength(50)]
        [Required]
        private String Libelle { get; set; }

        public Statut()
        {

        }
    }
}
