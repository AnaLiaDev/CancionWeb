using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CancionWeb.Models
{
    public class Cancion
    {
        [Key]
        [Required] // Sea obligatorio
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Por favor ingrese entre 2 a 100 caracteres")]
        [Display(Name = "Nombre de la canción")]
        public string NombreCancion { get; set; } //escribir prop y tab tab para que se cree automaticamente

        [Required] // Sea obligatorio
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Por favor ingrese entre 2 a 100 caracteres")]
        [Display(Name = "Nombre del Autor")]
        public string NombreAutor { get; set; } //escribir prop y tab tab para que se cree automaticamente

        [Url]
        [Required] // Sea obligatorio
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Por favor ingrese entre 2 a 100 caracteres")]
        [Display(Name = "Link de la canción")]
        public string LinkCancion { get; set; } //escribir prop y tab tab para que se cree automaticamente
  


    }
}
