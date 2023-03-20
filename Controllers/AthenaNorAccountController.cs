using AthenaMock.Models.NOR_Account.Request;
using AthenaMock.Models.NOR_Account.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AthenaMock.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AthenaNorAccountController : ControllerBase
    {
        private readonly ILogger<AthenaNorAccountController> _logger;
        public AthenaNorAccountController(ILogger<AthenaNorAccountController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public AthenaNORAccountResponse GetPrice(AthenaNORAccountRequest request) 
        {
            return new AthenaNORAccountResponse();
        }
    }
}
