using System.ComponentModel.DataAnnotations;

namespace CredisanOpenBanking.Domain.Dtos.Usuario
{
    public class UpdateUsuarioDto
    {
        [Required(ErrorMessage = "Nome é campo obrigatório.")]
        [StringLength(60, ErrorMessage = "Nome deve ter no máximo {1} caracteres.")]
        public string Nome { get; set; }
    }
}