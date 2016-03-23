using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using LearnWebApi.DataLayer.Repositories;
using LearnWebApi.Models.View;

namespace LearnWebApi.Api.Controllers
{
    public class AuthorsController : ApiController
    {
        // GET: api/Authors
        public async Task<IEnumerable<BookView>> GetBooks()
        {
            var repo = new BookRepository();
            return await repo.GetAuthorBook();
        }

        // GET: api/Authors/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Authors
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Authors/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Authors/5
        public void Delete(int id)
        {
        }
    }
}
