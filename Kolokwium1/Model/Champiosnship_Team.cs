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

        [ForeignKey("Team")]
        public int IdTeam { get; set; }
        public Team Team { get; set; }

        [ForeignKey("Champoionship")]
        public int IdChampiosnship { get; set; }
        public Champoionship Champoionship { get; set; }
        

        public float? Score { get; set; }
    }
}
