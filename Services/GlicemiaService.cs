using System.Linq;
using Api.Contextos;
using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Services;

public class GlicemiaService : IGlicemiaService
{
    private readonly Contexto _contexto = new Contexto();

    public void Add(Glicemia glicemia)
    {
        _contexto.Glicemia.Add(glicemia);
        _contexto.SaveChanges();
    }

    public void Delete(int id)
    {
        var glicemia = _contexto.Glicemia.Find(id);
        if (glicemia != null)
        {
            _contexto.Glicemia.Remove(glicemia);
            _contexto.SaveChanges();
        }
    }

    public List<Glicemia> GetAll(int id)
    {
        System.FormattableString teste = $"SELECT * FROM glicemia WHERE idusuario = {id}";
          var listaGlicemias = _contexto.Glicemia.FromSqlInterpolated( teste )
                        .ToList< Glicemia >();
        return listaGlicemias;
    }

    public Glicemia? GetById(int id)
    {
        
        return _contexto.Glicemia.Find(id);
    }

    public void Update(Glicemia glicemia)
    {
        throw new NotImplementedException();
    }
}