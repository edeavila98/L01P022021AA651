using System.ComponentModel.DataAnnotations;

namespace L01P022021AA651.Models
{
    public class facultades
    {
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }
        [Display(Name = "facultad")]

        public string? facultad { get; set; }



    }
}
