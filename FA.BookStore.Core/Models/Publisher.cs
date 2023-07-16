﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.BookStore.Core.Models
{
    internal class Publisher
    {
        [Key]
        public int PubId { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }
        public virtual ICollection<Book>? Books { get; set; }
    }
}
