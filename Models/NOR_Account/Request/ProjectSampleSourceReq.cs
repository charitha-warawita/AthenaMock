namespace AthenaMock.Models.NOR_Account.Request
{
    public class ProjectSampleSourceReq
    {
        public int project_sample_source_id { get; set; }
        public int completes { get; set; }
        public int sample_source_id { get; set; }
        public string sample_platform { get; set; }
        public int sample_source_cost { get; set; }
        public string sample_source_currency { get; set; }
    }
}
