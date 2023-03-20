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
        public AthenaNORAccountResponse GetPrice(AthenaNORAccountRequest req) // (AthenaNORAccountRequest request)
        {
            var res = new AthenaNORAccountResponse();
            res.project_id = req.project_id;
            res.markets = new List<Models.NOR_Account.Response.Market>();

            Models.NOR_Account.Response.Market mkt = new Models.NOR_Account.Response.Market
            {
                locale = "en-US",
                market = "USA",
                preferred_currency = "EUR",
                price_total = 2173
            };
            mkt.targeted_audiences = new List<Models.NOR_Account.Response.TargetedAudience>();
            res.markets.Add(mkt);

            return res;
        }
    }
}
