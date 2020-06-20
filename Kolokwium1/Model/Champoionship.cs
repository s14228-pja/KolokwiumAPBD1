using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium1.Model
{
    public class Champoionship
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdChampoionship { get; set; }

        [MaxLength(100)]
        public string OfficialName { get; set; }

        public int? Year { get; set; }

        public ICollection<Champiosnship_Team> Champiosnship_Team { get; set; }
    }
}
