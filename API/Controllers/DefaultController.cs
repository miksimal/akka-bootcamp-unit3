using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using API.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {

        private IRepository repository;

        public DefaultController(IRepository repository)
        {
            this.repository = repository;
        }
        // GET: /fast (change all to post as need to re-verify the auth token each time, so need the payload
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("/fast")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // POST: /Default
        [Microsoft.AspNetCore.Mvc.HttpPost]
        public void Post([System.Web.Http.FromBody] string value)
        {
        }

        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("/auth")]
        public async Task<IHttpActionResult> authCheck(string githubtoken)
        {
            try
            {
                if (githubtoken == string.Empty)
                {
                    return BadRequest() as IHttpActionResult;
                }

                await this.repository.FastRequest();
                return this.Ok() as IHttpActionResult;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

                return BadRequest() as IHttpActionResult;
            }
        }



    }
}
