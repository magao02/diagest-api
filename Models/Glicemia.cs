using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Models;

[Table("glicemia")]
public class Glicemia
{
    [Key]
    public int id { get; set; }
    public int valor { get; set; }
    public DateTime datahora { get; set; }
    public int idusuario { get; set; }

    public Glicemia(int valor, DateTime datahora, int idusuario)
    {
        this.valor = valor;
        this.datahora = datahora;
        this.idusuario = idusuario;
    }

}