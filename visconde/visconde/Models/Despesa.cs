using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace visconde.Models
{
    [Table("Despesas")]
    public class Despesa
    {

        [Key]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Descricao { get; set; }

        [Display(Name = "Data")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public DateTime Data { get; set; }

        [Display(Name = "Valor")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public double Valor { get; set; }

        [Display(Name = "Categoria")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public int CategoriaId { get; set; }

        [ForeignKey("CategoriaId")]
        public Categoria Categoria { get; set; }


        public ICollection<Despesa> Despeas { get; set; }


    }
}
