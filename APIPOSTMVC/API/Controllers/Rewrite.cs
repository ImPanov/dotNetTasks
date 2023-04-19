using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RewriteController : ControllerBase
    {
        [HttpPost]
        public string Action([FromBody]Message message)
        {

            return message.name.ToUpper();
        }


    }
    
    public class Message
    {
        public string name { get; set; }
    }
}