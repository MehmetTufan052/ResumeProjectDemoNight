using System.ComponentModel.DataAnnotations;

namespace ResumeProjectDemoNight.Entities
{
    public class About2
    {
        [Key]
        public int About2Id { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
