namespace AthenaMock.Models.NOR_Account.Response
{
    public class Market
    {
        public string locale { get; set; }
        public string market { get; set; }
        public int price_total { get; set; }
        public string preferred_currency { get; set; }
        public List<TargetedAudience> targeted_audiences { get; set; }
    }
}
