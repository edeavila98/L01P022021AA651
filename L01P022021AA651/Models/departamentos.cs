using System.ComponentModel.DataAnnotations;

namespace L01P022021AA651.Models
{
    public class departamentos
    {

        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }
        [Display(Name = "departamento")]

        public string? departamento { get; set; }

    }
}
