using System.ComponentModel.DataAnnotations;

public class TipoPersonalModel{
    [Key]
    public  int Bloq_IdTipoPersonal {get; set;}

    public string? Bloq_NombreTipoPersonal {get; set;}
}