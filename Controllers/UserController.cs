
using Api.Models;
using Api.Services;
using Api.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Api.controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserService _UserService;

    public UserController(IUserService UserService)
    {
        _UserService = UserService ?? throw new ArgumentNullException(nameof(UserService));
    }

    [HttpGet]
    public ActionResult<IEnumerable<User>> GetAll() {

        var users = _UserService.GetAll();
        return(users);
    } 

    [HttpGet("{id}")]
    public ActionResult GetById(int id)
    {
        var user = _UserService.GetById(id);
        if (user == null) return NotFound();
        return Ok(user);
    }
    [HttpPost]
    [Route("login")]
    public ActionResult Teste(string email, string senha)
    {
        var user = _UserService.Login(email, senha);
        if (user == null) return NotFound();
        return Ok(user);
    }
    


    [HttpPost]
    public ActionResult<User> Create(UserViewModel userModel)
    {
        var user = new User(userModel.name, userModel.email, userModel.password);
        _UserService.Add(user);
        return Ok(user);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, User user)
    {
        if (id != user.id) return BadRequest();
        var existingUser = _UserService.GetById(id);
        if (existingUser == null) return NotFound();
        _UserService.Update(user);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var user = _UserService.GetById(id);
        if (user == null) return NotFound();
        _UserService.Delete(id);
        return NoContent();
    }
}