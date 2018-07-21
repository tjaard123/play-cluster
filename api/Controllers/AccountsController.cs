using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Account>> Get()
        {
            return List<Account>() 
            {
               new Account() { Name = "Current", AccountNumber: "1001000" },
               new Account() { Name = "Saving", AccountNumber: "1002000" },
            };
        }
    }
}
