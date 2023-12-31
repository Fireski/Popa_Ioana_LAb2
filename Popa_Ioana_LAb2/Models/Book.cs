﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Popa_Ioana_LAb2.Models
{
    public class Book
    {
        public int ID { get; set; }

        [Display(Name = "Titluri carti")]
        public string Title { get; set; }

        public string Author { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }

        public int? PublisherID { get; set; }
        public Publisher Publisher { get; set; }
    }
}
