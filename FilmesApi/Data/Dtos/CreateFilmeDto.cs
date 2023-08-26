using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos;

public class CreateFilmeDto
{
    [Required(ErrorMessage = "O titulo do filme é obrigatório")]
    [MaxLength(70, ErrorMessage = " O titulo do filme nao pode ultrapassar 70 caracteres")]
    public string Titulo { get; set; }

    [Required(ErrorMessage = "O genero do filme é obrigatório")]
    [MaxLength(40, ErrorMessage = "O tamanho do genero nao pode exceder 40 caracteres")]
    public string Genero { get; set; }


    [Required(ErrorMessage = "O genero do filme é obrigatório")]
    [Range(70, 600, ErrorMessage = "O tamanho do filme tem de estar entre 70 e 600 minutos para ser válido")]
    public int Duracao { get; set; }
}
