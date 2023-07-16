using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.BookStore.Core.Models
{
    internal class Category
    {
        [Key]
        public int CateId { get; set; }
        [Required]
        [MaxLength(100)]
        public string CateName { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<Book>? Books { get; set; }
    }
}
