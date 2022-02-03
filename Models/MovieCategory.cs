using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DaMovies.Models
{
    public class MovieCategories
    {
        [Key]
        [Required]
        public int CategoryID { get; set; }
        [Required]
        public string Category { get; set; }
    }
}
