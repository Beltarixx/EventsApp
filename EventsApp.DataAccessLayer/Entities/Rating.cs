using System.ComponentModel.DataAnnotations;

namespace EventsApp.DataAccessLayer.Entities
{
    public class Rating
    {
        [Key]
        public int Id { get; set; }
        public int Points { get; set; }
        public string RatedBy { get; set; }
    }
}
