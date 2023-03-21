using AthenaMock.Models.NOR_Account.Request;
using AthenaMock.Models.NOR_Account.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AthenaMock.Controllers
{
    //[Route("api/[controller]/[action]")]
    [ApiController]
    public class AthenaNorAccountController : ControllerBase
    {
        private readonly ILogger<AthenaNorAccountController> _logger;
        public AthenaNorAccountController(ILogger<AthenaNorAccountController> logger)
        {
            _logger = logger;
        }

        [Route("api/GetPrice")]
        [HttpPost]
        public AthenaNORAccountResponse GetPrice(AthenaNORAccountRequest req) // (AthenaNORAccountRequest request)
        {
            // Binding , Inner Process ==> mock sample ==>
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

        [Route("api/GetPriceSpecial")]
        [HttpPost]
        public AthenaNORAccountResponse GetPriceSpecial(AthenaNORAccountRequest req) // (AthenaNORAccountRequest request)
        {
            // Binding , Inner Process ==> mock sample ==>
            var res = new AthenaNORAccountResponse();
            res.project_id = req.project_id;

            Models.NOR_Account.Response.Market mkt = new Models.NOR_Account.Response.Market
            {
                locale = "en-US",
                market = "USA",
                preferred_currency = "EUR",
                price_total = 2173
            };

            ProjectSampleSource sampleSrc = new ProjectSampleSource {
                project_sample_source_id = 100001,
                completes = 60,
                sample_source_id = 1111,
                sample_platform = "Cint",
                sample_source_cost = 0,
                sample_source_currency = "EUR",
                price = 300,
                preferred_currency = "EUR"
            };
            TargetedAudience targetedAudience = new TargetedAudience {
            targeted_audience_id = 12345678,
            adjusted_incidence_rate = 86,
            adjusted_length_of_interview = 15,
            price_targeted_audience = 2173,
            preferred_currency = "EUR"
            };
            targetedAudience.project_sample_sources = new List<ProjectSampleSource>();
            targetedAudience.project_sample_sources.Add(sampleSrc);
            mkt.targeted_audiences = new List<Models.NOR_Account.Response.TargetedAudience>();
            mkt.targeted_audiences.Add(targetedAudience);

            res.markets = new List<Models.NOR_Account.Response.Market>();
            res.markets.Add(mkt);

            return res;
        }
    }
}
