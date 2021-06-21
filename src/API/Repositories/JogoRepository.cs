using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Domain;
using API.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories
{
    public class JogoRepository: IJogoRepository
    {
        private readonly ApplicationDbContext context;
        public JogoRepository(ApplicationDbContext context)
        {
            this.context = context;

        }

        public async Task CreateJogo(Jogo jogo)
        {
            this.context.Jogos.Add(jogo);
            await this.context.SaveChangesAsync();
        }

        public async Task DeleteJogo(Jogo jogo)
        {
            this.context.Jogos.Remove(jogo);
            await this.context.SaveChangesAsync();
        }

        public async Task UpdateJogo(Jogo jogo)
        {
            this.context.Jogos.Update(jogo);
            await this.context.SaveChangesAsync();
        }

        public async Task<Jogo> GetJogoById(string id)
        {
            IQueryable<Jogo> query = this.context.Jogos;
            return await query.FirstOrDefaultAsync(n => n.Id == id);
        }

        public async Task<IList<Jogo>> GetJogosByName(string name)
        {
            IQueryable<Jogo> query = this.context.Jogos;
            return await query.Where(n => n.Name == name).ToListAsync();
        }
    }
}