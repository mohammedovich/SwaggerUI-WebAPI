using System.Collections.Generic;
using System.Web.Http;

namespace SwaggerUI.Owin.Controllers
{
    public class HomeController : ApiController
    {
        // GET: api/Home
        /// <summary>
        /// Gets data from service
        /// </summary>
        /// <returns>list of values</returns>
        public IEnumerable<string> Get()
        {
            return new string[] {"value1", "value2"};
        }

        // GET: api/Home/5
        /// <summary>
        /// Get a specific value by Id
        /// </summary>
        /// <param name="id">value integer id</param>
        /// <returns>a single value by Id</returns>
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Home
        /// <summary>
        /// Accept an incoming request
        /// </summary>
        /// <param name="value">string <paramref name="value"/></param>
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Home/5
        /// <summary>
        /// Persist incoming request
        /// </summary>
        /// <param name="id"><paramref name="value"/> integer id</param>
        /// <param name="value">string value</param>
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Home/5
        /// <summary>
        /// Delete value
        /// </summary>
        /// <param name="id">value integer id</param>
        public void Delete(int id)
        {
        }
    }
}