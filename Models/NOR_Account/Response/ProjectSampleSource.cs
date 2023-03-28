using System.ComponentModel.DataAnnotations;

namespace AthenaMock.Models.NOR_Account.Response
{
    public class ProjectSampleSource
    {
        public int project_sample_source_id { get; set; }
        public int completes { get; set; }
        public int sample_source_id { get; set; }
        public string sample_platform { get; set; }
        public double sample_source_cost { get; set; }
        [Required]
        public string sample_source_currency { get; set; }
        public double price { get; set; }
        [Required]
        public string preferred_currency { get; set; }
    }
}
