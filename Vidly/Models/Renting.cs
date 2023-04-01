using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vidly.Models
{
    public class Renting
    {
        [Key]
        public int Id { get; set; }
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public string MovieDescription { get; set;}
    }
}
