﻿using System;
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

        public string Publisher { get; set; }

        public string Date { get; set; }
    }
}
