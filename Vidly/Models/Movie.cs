

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vidly.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey(nameof(GenreId))]
        public Genre Genre { get; set; }

        public byte GenreId { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime DateAdded { get; set; }
        public int NumberInStock { get; set; }
    }
}
