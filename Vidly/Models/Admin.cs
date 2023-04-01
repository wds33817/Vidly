using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public int age { get; set; }
    }
}
