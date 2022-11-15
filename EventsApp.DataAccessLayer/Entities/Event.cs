using System.ComponentModel.DataAnnotations;

namespace EventsApp.DataAccessLayer.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public int CityId { get; set; }
        public string Type { get; set; }
        public List<Review> Reviews { get; set; }
        public List<Rating> Ratings { get; set; }
    }
}
