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

        //[HttpPost]
        //public AthenaNORAccountResponse GetPrice(AthenaNORAccountRequest request) 
        //{
        //    return new AthenaNORAccountResponse();
        //}

        [HttpPost]
        public string GetPriceTest(int val)
        {
            if (val < 100)
            {
                return $"{val} is smaller than 100";
            }
            return $"{val} is equal or bigger than 100";
        }

        [HttpPost]
        public AthenaNORAccountResponse GetPrice(int valueInt)
        {
            var res = new AthenaNORAccountResponse();
            res.project_id = 1233;
            res.markets = new List<Models.NOR_Account.Response.Market>();

            Models.NOR_Account.Response.Market mkt = new Models.NOR_Account.Response.Market {
                locale = "en-US",
                market = "USA",
                preferred_currency = "EUR",
                price_total= 2173
            };
            mkt.targeted_audiences = new List<Models.NOR_Account.Response.TargetedAudience>();  

            return res;
        }
    }
}
