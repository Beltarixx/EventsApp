using System.ComponentModel.DataAnnotations;

namespace EventsApp.DataAccessLayer.Entities
{
    public class Review
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public int UserId { get; set; }
        public List<Rating> Ratings { get; set; }
    }
}
