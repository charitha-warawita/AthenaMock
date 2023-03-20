namespace AthenaMock.Models
{
    public class TargetedAudience
    {
        public int targeted_audience_id { get; set; }
        public string targeted_audience_name { get; set; }
        public string panelist_type { get; set; }
        public string sampling_complexity { get; set; }
        public int targeted_complete { get; set; }
        public int estimated_incidence_rate { get; set; }
        public int estimated_length_of_interview { get; set; }
        public string estimated_fieldwork_start_date { get; set; }
        public string estimated_fieldwork_end_date { get; set; }
        public int waves { get; set; }
        public List<ProjectSampleSource> project_sample_sources { get; set; }
    }
}
