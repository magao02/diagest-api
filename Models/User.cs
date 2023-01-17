using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Models;

[Table("user")]
public class User
{
    [Key]
    public int id { get; set; }
    public string name { get; set; }
    public string email { get; set; }
    public string password { get; set; }

    public User(string name, string email, string password)
    {
        this.name = name;
        this.email = email;
        this.password = password;
    }

}