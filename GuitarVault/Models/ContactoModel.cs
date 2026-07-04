using System.ComponentModel.DataAnnotations;

namespace GuitarVault.Models
{
    public class ContactoModel // modelo para el formulario de contacto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(80)]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [StringLength(20)]
        public string Guitarra { get; set; } = string.Empty;

        [Required]
        [StringLength(500)]
        public string Mensaje { get; set; } = string.Empty;

        public DateTime Fecha { get; set; }
    }
}