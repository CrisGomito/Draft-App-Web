using System.ComponentModel.DataAnnotations;

namespace DraftAppWeb.Models
{
    public class Productos
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo Nombre es obligatorio.")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El campo Precio es obligatorio.")]
        public string Precio { get; set; }
        [Required(ErrorMessage = "El campo Codigo es obligatorio.")]
        public string Codigo { get; set; }
        [Required(ErrorMessage = "El campo Descripcion es obligatorio.")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "El campo Talla es obligatorio.")]
        public string Talla { get; set; }
        [Required(ErrorMessage = "El campo Genero es obligatorio.")]
        public string Genero { get; set; }
        [Required(ErrorMessage = "El campo Color es obligatorio.")]
        public string Color { get; set; }
    }
}
