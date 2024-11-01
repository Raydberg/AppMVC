using System.ComponentModel.DataAnnotations;

namespace CrudMVC.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "El telefono es obligatorio")]
        public string? Phone { get; set; }= string.Empty;
        [Required(ErrorMessage = "El email es obligatorio")]
        public string Email { get; set; }= string.Empty;
        public DateTime CreateTime { get; set; }


    }
}
