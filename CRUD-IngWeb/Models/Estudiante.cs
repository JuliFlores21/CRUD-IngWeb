using System.ComponentModel.DataAnnotations;

namespace CRUD_IngWeb.Models
{
    public class Estudiante
    {
        public int Id { get; set; }

        [Required(ErrorMessage="Este campo es obligatorio")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int Edad {  get; set; }
    }
}
