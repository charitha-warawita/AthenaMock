using System.ComponentModel.DataAnnotations;

namespace AthenaMock.Models.NOR_Account.Request
{
    public class TargetedAudienceReq
    {
        public int targeted_audience_id { get; set; }
        public string targeted_audience_name { get; set; }
        [Required]
        public string panelist_type { get; set; }
        public string sampling_complexity { get; set; }
        [Required]
        public int targeted_complete { get; set; }
        [Required]
        public float estimated_incidence_rate { get; set; }
        [Required] 
        public int estimated_length_of_interview { get; set; }
        public string estimated_fieldwork_start_date { get; set; }
        public string estimated_fieldwork_end_date { get; set; }
        public int proposed_fieldwork_length { get; set; }
        [Required]
        public int waves { get; set; }
        public List<ProjectSampleSourceReq> project_sample_sources { get; set; }
    }
}
