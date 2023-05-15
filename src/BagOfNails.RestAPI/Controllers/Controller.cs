using BagOfNailsApp.Core.Service;
using Microsoft.AspNetCore.Mvc;

namespace BagOfNails.RestAPI.Controllers
{
    [ApiController]
    [Route("bag-of-nails/")]
    public class Controller : ControllerBase
    {
        public Service _service = new ();
        
        [HttpGet]
        [Route("{bag-weight}")]
        public void GetTotalWeight(float totalWeight)
        {
            _service.GetTotalWeight(totalWeight);
        }

        [HttpGet]
        [Route("nail-weight")]
        public void GetWeights(bool isRandom, float? weight, float totalWeight)
        {
            _service.GetWeights(isRandom, weight, totalWeight);
        }

        [HttpPost]
        [Route("total-weight")]
        public int CreateTotal(float totalWeight, bool isRandom, float weight)
        {
            return _service.GetTotalNailsNumber(totalWeight, isRandom, weight);
        }





    }
}
