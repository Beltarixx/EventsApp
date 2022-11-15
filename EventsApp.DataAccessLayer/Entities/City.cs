using System.ComponentModel.DataAnnotations;

namespace EventsApp.DataAccessLayer.Entities
{
    public class City
    {
        [Key]
        public int Ìd { get; set; }
        public string Name { get; set; }

        public List<User> Events { get; set; }
    }
}
