using System.ComponentModel.DataAnnotations;

namespace WebApp.Models;

public class UserInput
{
    [Required(ErrorMessage = "Namn är obligatoriskt")]
    public string Name {get; set;}

    [Required(ErrorMessage = "Ålder är obligatoriskt")]
    [Range(1, 120, ErrorMessage = "Ålder måste bli mellan 1 och 120")]
    public int Age {get; set;}
}
