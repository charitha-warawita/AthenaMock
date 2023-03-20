namespace AthenaMock.Models.NOR_Account.Response
{
    public class ProjectSampleSource
    {
        public int project_sample_source_id { get; set; }
        public int completes { get; set; }
        public int sample_source_id { get; set; }
        public string sample_platform { get; set; }
        public int sample_source_cost { get; set; }
        public string sample_source_currency { get; set; }
        public double price { get; set; }
        public string preferred_currency { get; set; }
    }
}
