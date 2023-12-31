﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Popa_Ioana_LAb2.Models
{
    public class Authors
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public ICollection<Book> Books { get; set; } 
    }
}
