namespace AthenaMock.Models
{
    public class AthenaRequest
    {
        public string source_system { get; set; }
        public int project_id { get; set; }
        public string project_name { get; set; }
        public string pricing_source { get; set; }
        public string pricing_formula { get; set; }
        public string service_type { get; set; }
        public string kmp_product_classification { get; set; }
        public string kmp_product_type { get; set; }
        public string kmp_media_type { get; set; }
        public string project_type { get; set; }
        public Account account { get; set; }
        public ExchangeRate exchange_rate { get; set; }
        public List<Market> markets { get; set; }
    }
}
