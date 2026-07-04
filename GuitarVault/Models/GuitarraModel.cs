using System.ComponentModel.DataAnnotations;

namespace GuitarVault.Models
{
    public class GuitarraModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(80)]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string Marca { get; set; } = string.Empty;

        [Required]
        [StringLength(20)]
        public string Tipo { get; set; } = string.Empty;

        [Display(Name = "Año")]
        [Range(1900, 2100)]
        public int Anio { get; set; }

        [Display(Name = "Descripción")]
        [StringLength(500)]
        public string Descripcion { get; set; } = string.Empty;

        [Required]
        public string Imagen { get; set; } = string.Empty;

        public bool Disponible { get; set; }
    }
}