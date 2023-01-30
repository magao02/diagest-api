
using Api.Models;
namespace Api.Services;
public interface IUserService
{
    void Add(User user);

    User? GetById(int id);

    void Update(User user);
    void Delete(int id);

    List<User> GetAll();
    User? Login(string email, string senha);
}