using At_Home_API.Properties;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace At_Home_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class APIController : ControllerBase
    {
        Api1Model model = new Api1Model()
        {
            ContactAddress = "20 Roosevelt Street, Mill Valley",
            DestinationAddress = "4297 Stratford Court,Goldsboro",
            dimension=45

        };

        

        [HttpGet]
        public ActionResult<Api1Model> Get()
        {
            int total = 53;
            return model;
        }
        
    }
}
