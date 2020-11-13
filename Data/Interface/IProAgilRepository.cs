using System.Threading.Tasks;
using ProAgil.WebApi.Model;

namespace ProAgil.WebApi.Interface.Data
{
    public interface IProAgilRepository
    {
        void Add<T> (T entity) where T : class;
        void Update<T> (T entity) where T : class;
        void Delete<T> (T entity) where T : class;

        Task<bool> SaveChangesAsync();

        //EVENTO
        Task<Evento[]> GetAllEventoAsyncByTema(string tema, bool includePalestrantes);
        Task<Evento[]> GetAllEventoAsync(bool includePalestrantes);
        Task<Evento> GetEventoAsyncByID(int EventoId, bool includePalestrantes);

        //PALESTRANTE
        
        Task<Palestrante[]> GetAllPalestrantesAsyncByName(string nome, bool includeEventos);
        Task<Palestrante> GetPalestranteAsync(int PalestranteId, bool includeEventos);

    }
}