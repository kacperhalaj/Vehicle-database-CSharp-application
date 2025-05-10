using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projekt.Models
{
    public class Osobowy
    {
        [Key]
        [ForeignKey("Pojazd")]
        public int IdPojazdu { get; set; } // PK i FK

        public int LiczbaDrzwi { get; set; }

        public Pojazd Pojazd { get; set; }
    }
}