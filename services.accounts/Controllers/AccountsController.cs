using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using services.accounts.Models;

namespace services.accounts.Controllers
{
   [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Account>> Get()
        {
            return new List<Account>() 
            {
               new Account() { Name = "Current", AccountNumber = "1001000" },
               new Account() { Name = "Saving", AccountNumber = "1002000" },
            };
        }
    }
}
