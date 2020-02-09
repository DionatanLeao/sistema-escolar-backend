using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaEscolar.Models
{
    [NotMapped]
    public class UsuarioSenha : Usuario
    {
        [Required(ErrorMessage = " O Campo {0} é Obrigatório!")]
        [StringLength(15, ErrorMessage = " O Campo {0} pode ter no máximo {1} e minimo {2} caracteres ", MinimumLength = 2)]
        public string Senha { get; set; }
    }
}