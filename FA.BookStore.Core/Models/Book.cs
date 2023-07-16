using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.BookStore.Core.Models
{
    internal class Book
    {
        [Key]
        public int BookId { get; set; }
        public string? Title { get; set; }

        public string? Summary { get; set; }
        public string? imgUrl { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool IsActive { get; set; }
        public int AuthorId { get; set; }
        [ForeignKey("AuthorId")]
        public virtual Author Author { get; set; }
        public int? PubId { get; set; }
        [ForeignKey("PubId")]
        public virtual Publisher Publisher { get; set; }
        public int? CateId { get; set; }
        [ForeignKey("CateId")]
        public virtual Category Category { get; set; }
        public virtual ICollection<Comment>? Comments { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }

    }
}
