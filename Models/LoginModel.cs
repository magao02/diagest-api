using System.ComponentModel.DataAnnotations;

namespace Api.Models;

public class LoginModel
{
    [Required(ErrorMessage = "User Name é obrigatório!")]
    public string? email { get; set; }

    [Required(ErrorMessage = "Password é obrigatório!")]
    public string? password { get; set; }
}