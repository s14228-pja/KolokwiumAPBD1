using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium1.Model
{
    public class Team
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTeam { get; set; }

        [MaxLength(30)]
        public string TeamName { get; set; }

        public int MaxAge { get; set; }
    }
}
