using Microsoft.AspNetCore.Mvc;
using MODELSTATE.Models;

namespace MODELSTATE.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class EmployeeController : ControllerBase
    {
        [HttpPost]
        public ActionResult PostEmployee([FromBody]Customer obj)
        {
                
            return Ok(obj);

        }
        
    }
}