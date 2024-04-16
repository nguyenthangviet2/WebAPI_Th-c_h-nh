using System.ComponentModel.DataAnnotations;

namespace WebApiThucHanh.Models
{
    public class BookAuthor
    {
        [Key]
        public int ID { get; set; } // Khóa chính
        public int BookID { get; set; } // Khóa ngoại đến Books
        public int AuthorID { get; set; } // Khóa ngoại đến Authors

        // Liên kết đến bảng Books
        public Book Book { get; set; }
        // Liên kết đến bảng Authors
        public Author Author { get; set; }
    }
}
