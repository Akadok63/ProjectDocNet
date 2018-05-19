using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    [Table("T_Client")]
    class Client
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("ClientId")]
        private int Id { get; set; }

        [Column("Nom")]
        [StringLength(30)]
        private String Nom { get; set; }

        [Column("Prenom")]
        [StringLength(20)]
        private String Prenom { get; set; }

        [Column("Actif")]
        [Required]
        private int Actif { get; set; }

        public Client()
        {

        }
    }
}
