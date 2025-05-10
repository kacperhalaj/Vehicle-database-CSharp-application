using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projekt.Models
{
    public class Motor
    {
        [Key]
        [ForeignKey("Pojazd")]
        public int IdPojazdu { get; set; } // PK i FK

        public int PojemnoscSilnika { get; set; }

        public Pojazd Pojazd { get; set; }
    }
}