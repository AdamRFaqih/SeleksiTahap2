using Microsoft.AspNetCore.Mvc;
using System.Collections;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        public static List<Mahasiswa> listMhs = new List<Mahasiswa>();
        // GET: api/<MahasiswaController>
        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return listMhs;
        }

        // GET api/<MahasiswaController>/5
        [HttpGet("{id}")]
        public Mahasiswa Get(string id)
        {
            for (int i = 0; i < listMhs.Count; i++)
            {
                if (listMhs[i].nim.Equals(id))
                {
                    return listMhs[i];
                }
            }
            return null;
        }

        // POST api/<MahasiswaController>
        [HttpPost]
        public void Post([FromBody] Mahasiswa value)
        {
            listMhs.Add(value);
        }

        // PUT api/<MahasiswaController>/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] Mahasiswa value)
        {
            for (int i = 0; i < listMhs.Count; i++)
            {
                if (listMhs[i].nim.Equals(id))
                {
                    listMhs[i] = value;
                }
            }
        }

        // DELETE api/<MahasiswaController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            for (int i = 0; i < listMhs.Count; i++)
            {
                if (listMhs[i].nim.Equals(id))
                {
                    listMhs.RemoveAt(i);
                }
            }
        }
    }
}
