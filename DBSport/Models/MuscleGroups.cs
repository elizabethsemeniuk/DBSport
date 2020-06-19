using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace DBSport.Models
{
    public class MuscleGroups
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Type")]
        [Required(ErrorMessage = "This field must not be empty")]
        [MaxLength(50)]
        public string Name { get; set; }

        public ICollection<Level> Levels { get; set; }
    }
}
