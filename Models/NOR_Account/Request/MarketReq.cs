using System.ComponentModel.DataAnnotations;

namespace AthenaMock.Models.NOR_Account.Request
{
    public class MarketReq
    {
        [Required]
        public string locale { get; set; }
        [Required]
        public string market { get; set; }
        [Required]
        public List<TargetedAudienceReq> targeted_audiences { get; set; }
    }
}
