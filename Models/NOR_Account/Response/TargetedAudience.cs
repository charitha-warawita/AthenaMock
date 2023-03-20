namespace AthenaMock.Models.NOR_Account.Response
{
    public class TargetedAudience
    {
        public int targeted_audience_id { get; set; }
        public int adjusted_incidence_rate { get; set; }
        public int adjusted_length_of_interview { get; set; }
        public int price_targeted_audience { get; set; }
        public string preferred_currency { get; set; }
        public List<ProjectSampleSource> project_sample_sources { get; set; }
    }
}
