using System.Collections.Generic;
using System.Threading.Tasks;
using API.Domain;

namespace API.Interfaces
{
    public interface IJogoRepository
    {
        public Task CreateJogo(Jogo jogo);
        public Task UpdateJogo(Jogo jogo);
        public Task DeleteJogo(Jogo jogo);
        public Task<Jogo> GetJogoById(string id);
        public Task<IList<Jogo>> GetJogosByName(string name);
    }
}