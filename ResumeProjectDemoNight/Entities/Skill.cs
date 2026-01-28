using System.ComponentModel.DataAnnotations;

namespace ResumeProjectDemoNight.Entities
{
    public class Skill
    {
        [Key]
        public int SkillId { get; set; }
        public string SkillName { get; set; }
        public int SkillValue { get; set; }
        public string? SkillColor { get; set; }
        public string? SkillSpanClass { get; set; }
    }
}
