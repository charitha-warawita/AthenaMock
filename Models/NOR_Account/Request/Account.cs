using System.ComponentModel.DataAnnotations;

namespace AthenaMock.Models.NOR_Account.Request
{
    public class Account
    {
        public string sugar_account_uuid { get; set; }
        [Required]
        public string client_maconomy_number { get; set; }
        [Required]
        public string country_code { get; set; }
        [Required]
        public string mac_company_number { get; set; }
        [Required]
        public string preferred_currency { get; set; }
        [Required]
        public string client_segment { get; set; }
        [Required]
        public string brand { get; set; }
    }
}
