using System.ComponentModel.DataAnnotations;

namespace ResumeProjectDemoNight.Entities
{
    public class Education
    {
        [Key]
        public int EducationID { get; set; }

        [StringLength(100)]
        public string SchoolName { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [StringLength(50)]
        public string EducationPeriodDate { get; set; }




    }
}
