using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace visconde.Models
{
    [Table("Categorias")]
    public class Categoria
    {

        [Key]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Descricao { get; set; }
    }
}
