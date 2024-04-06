using System.ComponentModel.DataAnnotations;

namespace L01P022021AA651.Models
{
    public class alumnos
    {

        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }
        [Display(Name = "codigo")]
        public string? codigo { get; set; }
        [Display(Name = "nombre")]
        public string? nombre { get; set; }
        [Display(Name = "apellidos")]
        public string? apellidos { get; set; }
        [Display(Name = "dui")]
        public int? dui { get; set; }
        [Display(Name = "estado")]
        public int? estado { get; set; }


    }
}
