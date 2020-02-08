using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using InfMarket;
using InfMarket.Controllers;

namespace InfMarket.Models
{
    public class Produto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name ="Produto Id")]
        public int ProdutoId { get; set; }


        [Required(ErrorMessage = "Nome é obrigatório!")]
        [StringLength(50, ErrorMessage = "Nome com excesso de caracteres!")]
        [MinLength(2, ErrorMessage = "Nome muito curto!")]
        [Column(TypeName = "varchar(150)")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }


        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Fabricante { get; set; }


        [Required]
        [Column(TypeName = "varchar(50)")]
        public string CodBarras { get; set; }


        
        public decimal Preco { get; set; }


        
        public int Estoque { get; set; }



    }
}
