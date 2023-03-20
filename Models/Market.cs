namespace AthenaMock.Models
{
    public class Market
    {
        public string locale { get; set; }
        public string market { get; set; }
        public List<TargetedAudience> targeted_audiences { get; set; }
    }
}
