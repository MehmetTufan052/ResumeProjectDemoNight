using System.ComponentModel.DataAnnotations;

namespace ResumeProjectDemoNight.Entities
{
   
        public class Statistic
        {
            [Key]
            public int StatisticID { get; set; }
            public string Title { get; set; }
            public int CountValue { get; set; }
            public string Icon { get; set; }
        }
    
}
