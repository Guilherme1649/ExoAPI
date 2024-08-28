using ExoAPI.Contexts;
using ExoAPI.Domains;
using Microsoft.IdentityModel.Tokens;

namespace ExoAPI.Repositories
{
    public class ProjetoRepository
    {
        private readonly ExoApiContext _ctx;

        public ProjetoRepository(ExoApiContext ctx)
        {
            _ctx = ctx;
        }

        public List<Projeto> Listar()
        {
            return _ctx.Projetos.ToList();
        }
    }
}
