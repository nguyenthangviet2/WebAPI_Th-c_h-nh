using System.ComponentModel.DataAnnotations;
using WebApiThucHanh.Models;

namespace WebApiThucHanh.Models
{
    public class Book
    {
        [Key]
        public int ID { get; set; } // Khóa chính
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsRead { get; set; }
        public DateTime? DateRead { get; set; }
        public int Rate { get; set; }
        public int Genre { get; set; }
        public string CoverUrl { get; set; }
        public DateTime DateAdded { get; set; }
        public int PublisherID { get; set; } // Khóa ngoại đến Publishers

        // Liên kết đến bảng Publishers
        public Publishers Publisher { get; set; }
        public List<BookAuthor> bookAuthors { get; set; }
    }
}