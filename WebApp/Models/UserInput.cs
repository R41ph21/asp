using System.ComponentModel.DataAnnotations;

namespace WebApp.Models;

public class UserInput
{
    [Required(ErrorMessage = "Namn är obligatoriskt")]
    public string Name {get; set;} = string.Empty;

    [Required(ErrorMessage = "Email är obligatoriskt")]
    public string Email {get; set;} = string.Empty;

    [Required(ErrorMessage = "Password är obligatoriskt")]
    public string Password {get; set;} = string.Empty;
}
