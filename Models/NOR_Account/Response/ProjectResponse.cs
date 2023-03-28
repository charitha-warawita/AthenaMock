using System.ComponentModel.DataAnnotations;

namespace AthenaMock.Models.NOR_Account.Response
{
    public class ProjectResponse
    {
        public int project_id { get; set; }
        [Required]
        public List<Market> markets { get; set; }
    }
}
