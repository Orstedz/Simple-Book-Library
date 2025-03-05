using System.ComponentModel.DataAnnotations;

namespace SimpleBookLibraryApi.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
    }
}
