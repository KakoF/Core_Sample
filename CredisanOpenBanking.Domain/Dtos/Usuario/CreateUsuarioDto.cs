using System.ComponentModel.DataAnnotations;

namespace CredisanOpenBanking.Domain.Dtos.Usuario
{
    public class CreateUsuarioDto
    {
        [Required(ErrorMessage = "Nome é campo obrigatório.")]
        [StringLength(60, ErrorMessage = "Nome deve ter no máximo {1} caracteres.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "E-mail é campo obrigatório.")]
        [EmailAddress(ErrorMessage = "E-mail inválido.")]
        public string Email { get; set; }
    }
}