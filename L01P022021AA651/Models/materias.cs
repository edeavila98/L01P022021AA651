using System.ComponentModel.DataAnnotations;

namespace L01P022021AA651.Models
{
    public class materias
    {

        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }
        [Display(Name = "materia")]

        public string? materia { get; set; }
        [Display(Name = "unidades valorativas")]
        public int? unidades_valorativas { get; set; }
        [Display(Name = "estado")]
        public string? estado { get; set; }



    }
}
