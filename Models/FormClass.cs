using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DaMovies.Models
{
    public class FormClass
    {

        [Key]
        [Required]
        public int MovieID { get; set; }
        [Required(ErrorMessage = "You must enter a movie name, and it must be a string.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "You must enter a Year, and it must be an int.")]
        public int Year { get; set; }
        [Required(ErrorMessage = "You must enter a Director, and it must be a string.")]
        public string Director { get; set; }
        [Required(ErrorMessage = "You must enter a Rating, and it must be an int.")]
        public string Rating { get; set; }
        [Required(ErrorMessage = "You must enter if it has been Edited, and it must be yes or no.")]
        public bool Edited { get; set; }
        public string Lent_To { get; set; }
        public string Notes { get; set; }

        //FK PK Relationship
        [Required]
        public int CategoryID { get; set; }
        public MovieCategories Category { get; set; }
    }
}