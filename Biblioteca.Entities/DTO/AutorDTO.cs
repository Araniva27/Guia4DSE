using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entities.DTO
{
    public class AutorDTO
    {
        public int Codigo { get; set; }

        [Required(ErrorMessage = "El mensaje es requerido")]
        [StringLength(50, ErrorMessage = "El nombre no puede tener mas de 50 caracteres")]
        public string NombreAutor { get; set; } = string.Empty;

        [Required(ErrorMessage = "El mensaje es requerido")]
        [StringLength(50, ErrorMessage = "El apellido no puede tener mas de 50 caracteres")]
        public string ApellidoAutor {  get; set; } = string.Empty;
        

    }
}
