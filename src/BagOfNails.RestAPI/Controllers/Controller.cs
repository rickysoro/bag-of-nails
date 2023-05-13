using BagOfNailsApp.Core.Service;
using Microsoft.AspNetCore.Mvc;

namespace BagOfNails.RestAPI.Controllers
{
    [ApiController]
    [Route("total/")]
    public class Controller : ControllerBase
    {
        Service Service = new Service();
        
        [HttpGet]
        [Route("{bag-weight}")]
        public void GetTotalWeight(float totalWeight)
        {
            Service.GetTotalWeight(totalWeight);
        }

        [HttpGet]
        [Route("nail-weight")]
        public void GetWeights(bool isRandom, float? weight, float totalWeight)
        {
            Service.GetWeights(isRandom, weight, totalWeight);
        }

        [HttpPost]
        [Route("dffdlgd")]
        public int CreateTotal(float totalWeight, bool isRandom, float weight)
        {
            return Service.GetTotalNailsNumber(totalWeight, isRandom, weight);
        }





    }
}
