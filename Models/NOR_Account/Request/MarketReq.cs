namespace AthenaMock.Models.NOR_Account.Request
{
    public class MarketReq
    {
        public string locale { get; set; }
        public string market { get; set; }
        public List<TargetedAudienceReq> targeted_audiences { get; set; }
    }
}
