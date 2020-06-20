using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium1.Model
{
    public class Player_Team
    {
        [ForeignKey("Team")]
        public int IdTeam { get; set; }
        public Team Team { get; set; }


        [ForeignKey("Player")]
        public int IdPlayer { get; set; }
        public Player Player { get; set; }

        [MaxLength(300)]
        [Required]
        public string Comment { get; set; }

        public int NumOnShirt { get; set; }
    }
}
