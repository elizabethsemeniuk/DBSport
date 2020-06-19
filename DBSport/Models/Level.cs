using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DBSport.Models
{
    public class Level
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Level name")]
        [Required(ErrorMessage = "This field must not be empty")]
        [MaxLength(50)]
        public string Name { get; set; }

        [Display(Name = "Kcals per hour")]
        [Required(ErrorMessage = "This field must not be empty")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]
        public int KcalsPerHour { get; set; }

       // [Display(Name = "Type")]
        public int? MusclesGroupId { get; set; }

        //public ICollection<Component> Components { get; set; }
    }
}
