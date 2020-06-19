using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DBSport.Models
{
    public class Exercises
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Training")]
        [Required(ErrorMessage = "This field must not be empty")]
        public int TrainingId { get; set; }

        [Display(Name = "Level")]
        [Required(ErrorMessage = "This field must not be empty")]
        public int LevelId { get; set; }

        [Display(Name = "Kilograms")]
        [Required(ErrorMessage = "This field must not be empty")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]
        public int Kilograms { get; set; }
    }
}
