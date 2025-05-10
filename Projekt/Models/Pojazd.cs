using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projekt.Models
{
    public class Pojazd
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPojazdu { get; set; }

        [MaxLength(50)]
        public string Marka { get; set; }

        [MaxLength(50)]
        public string Model { get; set; }

        public int RokProdukcji { get; set; }

        [MaxLength(20)]
        public string Typ { get; set; }

        // Relacje 1:1 do Osobowe/Motory (opcjonalnie)
        public Osobowy Osobowy { get; set; }
        public Motor Motor { get; set; }
    }
}