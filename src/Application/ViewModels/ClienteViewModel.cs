using System.ComponentModel.DataAnnotations;

namespace Core.ViewModels;

public class CreateClienteViewModel
{
    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    [StringLength(100, MinimumLength = 2, ErrorMessage = "O campo {0} precisa ter entre {1} e {2} caracteres")]
    [Display(Name = "Nome")]
    public string Nome { get; set; }
    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    [EmailAddress(ErrorMessage = "O campo {0} deve ser um endereço de e-mail válido")]
    [Display(Name = "E-mail")]        
    public string Email { get; set; }
    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    [Display(Name = "Telefone")]
    public string Telefone { get; set; }
    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    [Display(Name = "Endereco")]
    public string Endereco { get; set; }
    
}
public class UpdateeClienteViewModel
{
    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    [StringLength(100, MinimumLength = 2, ErrorMessage = "O campo {0} precisa ter entre {1} e {2} caracteres")]
    [Display(Name = "Nome")]
    public string Nome { get; set; }
    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    [EmailAddress(ErrorMessage = "O campo {0} deve ser um endereço de e-mail válido")]
    [Display(Name = "E-mail")]
    public string Email { get; set; }
    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    [Display(Name = "Telefone")]
    public string Telefone { get; set; }
    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    [Display(Name = "Endereco")]
    public string Endereco { get; set; }

}