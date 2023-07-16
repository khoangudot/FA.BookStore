using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.BookStore.Core.Models
{
    internal class BookStoreContext : DbContext
    {
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Publisher> Publishers { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Author> Authors { get; set; }

        public virtual DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=localhost;database=FABookStoreCore;uid=sa;pwd=vietkhoac1;TrustServerCertificate=True");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderDetail>()
                .HasKey(od => new { od.OrderId, od.BookId });

            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.Order)
                .WithMany(o => o.OrderDetails)
                .HasForeignKey(od => od.OrderId);

            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.Book)
                .WithMany(o => o.OrderDetails)
                .HasForeignKey(od => od.BookId);

            modelBuilder.Entity<Book>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Books)
                .HasForeignKey(p => p.CateId);

            modelBuilder.Entity<Book>()
                .HasOne(p => p.Publisher)
                .WithMany(c => c.Books)
                .HasForeignKey(p => p.PubId);

            modelBuilder.Entity<Book>()
                .HasOne(p => p.Author)
                .WithMany(c => c.Books)
                .HasForeignKey(p => p.AuthorId);

            modelBuilder.Entity<Comment>()
                .HasOne(p => p.Book)
                .WithMany(c => c.Comments)
                .HasForeignKey(p => p.BookId);

            modelBuilder.Entity<Category>()
                .HasData(new List<Category>
                {
                    new Category
                    {
                        CateId = 1,
                        CateName = "Sách Khoa học công nghệ"
                    },
                     new Category
                    {
                        CateId = 2,
                        CateName = "Sách Văn học nghệ thuật"
                    },
                      new Category
                    {
                        CateId = 3,
                        CateName = "Truyện ngôn tình"
                    },
                    new Category
                    {
                        CateId = 4,
                        CateName = "Truyện Kiếm Hiệp"
                    },
                       new Category
                    {
                        CateId = 5,
                        CateName = "Sách lịch sử"
                    }
                });

            modelBuilder.Entity<Publisher>()
               .HasData(new List<Publisher>
               {
                    new Publisher
                    {
                        PubId = 1,
                        Name = "Nhà xuất bản Kim Đồng"
                    },
                     new Publisher
                    {
                        PubId = 2,
                        Name = "Nhà xuất bản giáo dục"
                    },
                      new Publisher
                    {
                        PubId = 3,
                        Name = "Nhà xuất bản Hội Nhà văn"
                    },
                       new Publisher
                    {
                        PubId = 4,
                        Name = "Pan Macmillan UK"
                    },
                       new Publisher
                    {
                        PubId = 5,
                        Name = "Nhà xuất bản Trẻ"
                    }
               });
            modelBuilder.Entity<Author>()
              .HasData(new List<Author>
              {
                    new Author
                    {
                        AuthorId = 1,
                        AuthorName = "Cố Mạn"
                    },
                      new Author
                    {
                        AuthorId = 2,
                        AuthorName = "Kim Dung"
                    },
                       new Author
                    {
                        AuthorId = 3,
                        AuthorName = "Thiền sư Thích Nhất Hạnh"
                    },
                         new Author
                    {
                        AuthorId = 4,
                        AuthorName = "Twentine"
                    }
              });

            modelBuilder.Entity<Book>()
               .HasData(new List<Book>
               {
                    new Book
                    {
                        BookId = 1,
                        CateId = 3,
                        Title = "Yêu em từ cái nhìn đầu tiên",
                        AuthorId= 1,
                        Price= 100000,
                        Quantity = 10,
                        PubId= 5
                    },
                    new Book
                    {
                        BookId = 2,
                        CateId = 3,
                        Title = "Em Là Niềm Kiêu Hãnh Của Anh",
                        AuthorId= 1,
                        Price= 100000,
                        Quantity = 9,
                        PubId= 5
                    },
                     new Book
                    {
                        BookId = 3,
                        CateId = 3,
                        Title = "Chiếc bật lửa và váy công chúa",
                        AuthorId= 4,
                        Price= 120000,
                        Quantity = 20,
                        PubId= 5
                    },
                    new Book
                    {
                        BookId = 4,
                        CateId = 4,
                        Title = "Thiên long bát bộ",
                        AuthorId= 2,
                        Price= 89000,
                        Quantity = 10,
                        PubId= 5
                    },
                     new Book
                    {
                        BookId = 5,
                        CateId = 4,
                        Title = "Anh Hùng Xạ Điêu",
                        AuthorId= 2,
                        Price= 59000,
                        Quantity = 16,
                        PubId= 5
                    },
                      new Book
                    {
                        BookId = 6,
                        CateId = 4,
                        Title = "Tiếu Ngạo Giang Hồ",
                        AuthorId= 2,
                        Price= 20000,
                        Quantity = 30,
                        PubId= 5
                    },
                      new Book
                    {
                        BookId = 7,
                        CateId = 2,
                        Title = "An lạc từng bước chân",
                        AuthorId= 3,
                        Price= 20000,
                        Quantity = 30,
                        PubId= 3
                    },
                      new Book
                    {
                        BookId = 8,
                        CateId = 2,
                        Title = "Bụt là hình hài bụt là tâm thức",
                        AuthorId= 3,
                        Price= 20000,
                        Quantity = 30,
                        PubId= 3
                    },
                      new Book
                    {
                        BookId = 9,
                        CateId = 2,
                        Title = "Từng bước nở hoa sen",
                        AuthorId= 3,
                        Price= 20000,
                        Quantity = 30,
                        PubId= 3
                    }
               });
        }
    }
}
