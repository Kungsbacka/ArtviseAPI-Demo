using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ServiceReference;
using Microsoft.AspNetCore.Authorization;

namespace Artvise_API.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class ArtviseController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public async Task<InboxDto[]> Get()
        {
            ServiceReference.ServiceClient svc = new ServiceReference.ServiceClient();
            return await svc.GetInboxesAsync("4f5c03f7-5311-4d02-aa3e-3cccabf16eab");
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
