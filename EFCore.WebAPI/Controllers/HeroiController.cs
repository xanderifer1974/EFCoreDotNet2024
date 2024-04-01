using EFCore.Model.Models;
using EFCore.Repository;
using Microsoft.AspNetCore.Mvc;



namespace EFCore.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroiController : ControllerBase
    {
        public readonly HeroiContext _context;

        public HeroiController(HeroiContext context )
        {
            _context = context;
        }


        // GET: api/<HeroiController>
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest($"Erro: {ex}");
            }
        }

        // GET api/<HeroiController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(new { id });
        }

        // POST api/<HeroiController>
        [HttpPost]
        public ActionResult Post()
        {
            try
            {
                var heroi = new Heroi
                {
                    Nome = "Super Homem",
                    Armas = new List<Arma>
                    {
                        new Arma {Nome = "Visão Raio X"},
                        new Arma{Nome = "Sopro"}
                    }

                };

                _context.Add(heroi);
                _context.SaveChanges();

                return Ok("Heroi Adicionado");
            }
            catch (Exception ex)
            {

                return BadRequest($"Erro: {ex}");
            }
        }

        // PUT api/<HeroiController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<HeroiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
