using System.ComponentModel.DataAnnotations;
using Theatre.Data.Enums;

namespace Theatre.Models
{
    public class Scene
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public double Price { get; set; }
        public String ImageURL { get; set; }

        public DateTime StartDate { get; set; }
        public TheatreCategory TheatreCategory { get; set; }

        public DateTime EndDate { get; set; }

    }
}
