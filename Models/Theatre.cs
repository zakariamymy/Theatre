using System.ComponentModel.DataAnnotations;

namespace Theatre.Models
{
    public class Theatre
    {
        [Key]
        public int Id { get; set; }

        public string Logo { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

    }
}
