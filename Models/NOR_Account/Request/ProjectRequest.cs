using System.ComponentModel.DataAnnotations;

namespace AthenaMock.Models.NOR_Account.Request
{
    public class ProjectRequest
    {
        [Required]
        public string source_system { get; set; }
        public int project_id { get; set; }
        public string project_name { get; set; }
        [Required]
        public string pricing_source { get; set; }
        [Required]
        public string pricing_formula { get; set; }
        [Required]
        public string service_type { get; set; }
        public string kmp_product_classification { get; set; }
        [Required]
        public string kmp_product_type { get; set; }
        public string kmp_media_type { get; set; }
        [Required]
        public string project_type { get; set; }
        public Account account { get; set; }
        [Required]
        public ExchangeRate exchange_rate { get; set; }
        [Required]
        public List<MarketReq> markets { get; set; }
    }
}
