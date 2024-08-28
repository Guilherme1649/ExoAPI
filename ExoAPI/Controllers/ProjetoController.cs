using ExoAPI.Domains;
using ExoAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ProjetoController : ControllerBase
    {
        private readonly ProjetoRepository _projetoRepository;
        public ProjetoController(ProjetoRepository projetoRepository)
        {
            _projetoRepository = projetoRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_projetoRepository.Listar());
        }

        public void Criar(Projeto projeto)
        {
            _ctx.Projetos.Add(projeto);
            _ctx.SaveChanges();
        }

        public void Atualizar(int id, Projeto projeto)
        {
            Projeto projetobuscado = _ctx.Projetos.Find(id);

            if (projeto.NomeDoProjeto != null)
            {
                projetobuscado.NomeDoProjeto = projeto.NomeDoProjeto;
            }
            if (projeto.Area != null)
            {
            projetobuscado.Area = projeto.Area;
            }
            if (projeto.Status != null)
            {
            projetobuscado.Status = projeto.Status;
            }

            _ctx.Projetos.Update(projetoBuscado);
            _ctx.SaveChanges();
        }
    }
}