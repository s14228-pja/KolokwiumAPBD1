using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium1.Model
{
    public class Champiosnship_Team
    {
        [Key]
        [ForeignKey("Team")]
        public int? IdTeam { get; set; }

        [Key]
        [ForeignKey("Champiosnship")]
        public int? IdChampiosnship { get; set; }

        public float Score { get; set; }
    }
}
