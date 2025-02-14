﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LetsLearn.Models
{
    public class ContactModel
    {
        [Required]
        [StringLength(60, MinimumLength = 5)]
        public string FromEmailAddress { get; set; }

        [StringLength(60, MinimumLength = 5)]
        public string ToEmailAddress { get; set; }


        [Required]
        [StringLength(60, MinimumLength = 5)]
        public string Subject { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 5)]
        public string Continut { get; set; }


    }
}
