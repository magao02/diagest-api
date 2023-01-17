
using Api.Models;
namespace Api.Services;
public interface IGlicemiaService
{
    void Add(Glicemia glicemia);

    Glicemia? GetById(int id);

    void Update(Glicemia glicemia);
    void Delete(int id);

    List<Glicemia> GetAll(int id);
}

