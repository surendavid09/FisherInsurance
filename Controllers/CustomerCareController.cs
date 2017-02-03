using Microsoft.AspNetCore.Mvc;

namespace CustomerCareApplication.Controllers
{
    [Route("customer")]
    public class CustomerCareController : Controller
    {
        [Route("")] [Route("Index")]
        public IActionResult Index()
        {
            return Ok("This is the index of the CustomerController");
        }
        
        [Route("fileclaim")]
        public string NewClaim()
        {
            return "File claims here";
        }

        [Route("claimstatus")]
        public string ClaimHistory()
        {
            return "Claim status shown here";
        }
    }
   
}