using System.ComponentModel.DataAnnotations;

namespace AthenaMock.Models.NOR_Account.Response
{
    public class Market
    {
        [Required]
        public string locale { get; set; }
        [Required]
        public string market { get; set; }
        public int price_total { get; set; }
        [Required]
        public string preferred_currency { get; set; }
        [Required]
        public List<TargetedAudience> targeted_audiences { get; set; }
    }
}
    