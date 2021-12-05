using System.ComponentModel.DataAnnotations;

namespace ProyectoBlockera.Models;
public class PersonalModel{
    [Key]
    public int Bloq_NumeroPersonal {get; set;}

    public string? Bloq_NombrePersonal {get; set;}

    public string? Bloq_ApellidoPaterno {get; set;}
    
    public string? Bloq_ApellidoMaterno {get; set;}

    public int Bloq_Edad {get; set;}

    public string? Bloq_Sobrenombre {get; set;}

    public int Bloq_TipoPersonal {get; set;}
}