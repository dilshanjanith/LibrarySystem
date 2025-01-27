using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibrarySystem.Model
{
    public class BookDto
    {
        [Required]
        public int BookId { get; set; }

        [Required]
        public string BookName { get; set; }

        [Required]
        public string Author { get; set; }

        public string Catagory { get; set; }

        public int RowNumber { get; set; }

        public DateOnly IssuedDate { get; set; }

        public DateOnly ReturnDate { get; set; }
    }

    public class Brrower
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public int BookId { get; set; }
    }
}
