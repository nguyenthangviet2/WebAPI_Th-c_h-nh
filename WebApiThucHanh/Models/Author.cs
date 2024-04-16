using System.ComponentModel.DataAnnotations;
using WebApiThucHanh.Models;

namespace WebApiThucHanh.Models
{
    public class Author
    {
        [Key]
        public int ID { get; set; } // Khóa chính
        public string FullName { get; set; }
        public List<BookAuthor> BookAuthors { get; set; }
    }
}