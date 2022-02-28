using System.ComponentModel.DataAnnotations;

namespace Shopping.Data.Entitties
{
    public class Country
    {
        public int Id { get; set; }

        [Display(Name ="País")]
        [MaxLength(50,ErrorMessage ="El campo {0} debe tener un máximo de {1} carácters")]
        [Required(ErrorMessage ="El campo {0} es requerido")]
        public string Name { get; set; }

    }
}
