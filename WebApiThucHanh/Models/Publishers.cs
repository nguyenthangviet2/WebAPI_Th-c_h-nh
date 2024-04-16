using System.ComponentModel.DataAnnotations;

namespace WebApiThucHanh.Models
{
    public class Publishers
    {
        [Key]
        public int ID { get; set; } // Khóa chính
        public string Name { get; set; }
        public List<Book> Books{ get; set; }
    }

}
