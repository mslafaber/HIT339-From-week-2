using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorldMVCwebApp._00Data
{
    public class Movie
    {
        public int MovieId { get; set; }
        
        [StringLength(50)]
        [Required]

        public string Name { get; set; }
        
        [Required]
        public string Director { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name="Release Date")]
        public DateTime ReleaseDate { get; set; }
        
        [EmailAddress]
        public string Email { get; set; }
        public string Language { get; set; }
    }

    public class Category
    {
        public int CategoryId { get; set; }
        [StringLength(50)]
        [Required]

        public string CategoryName { get; set; }

        public string CategoryCode { get; set; }

    }
}
