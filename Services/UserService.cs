using Api.Contextos;
using Api.Models;

namespace Api.Services;

public class UserService : IUserService
{
    private readonly Contexto _contexto = new Contexto();

    

    public void Add(User user)
    {
        _contexto.User.Add(user);
        _contexto.SaveChanges();
    }

    public void Delete(int id)
    {
        var user = _contexto.User.Find(id);
        if (user != null)
        {
            _contexto.User.Remove(user);
            _contexto.SaveChanges();
        }
    }

    public List<User> GetAll()
    {
        return _contexto.User.ToList();
    }

    public User? GetById(int id)
    {
        return _contexto.User.Find(id);
    }

    public void Update(User user)
    {
       throw new NotImplementedException();
    }
}


