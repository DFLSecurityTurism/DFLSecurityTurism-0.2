using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DFLSecurityTurism_0._2.Models
{
    public class AvaliacaoRestaurante
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Por favor, insira o eestaurante.")]
        [Display(Name = "Restaurante?")]
        public string Restaurante { get; set; }

        [Required(ErrorMessage = "Por favor, insira a classificação.")]
        [Display(Name = "Classifique de 0 a 10 as medidas de segurança tomadas pelo estabelecimento.")]
        public string Classifique { get; set; }

        [Required(ErrorMessage = "Por favor, insira a classificação.")]
        [Display(Name = "De 0 a 10 como classificaria os equipamentos usados pelo estabelecimento direcionado para a covid-19.")]
        public string Equipamentos { get; set; }


        [Required(ErrorMessage = "Por favor, insira a classificação.")]
        [Display(Name = "Classifique de 0 a 10 o quão seguro se sentiu durante o período em que frequentou o estabelecimento, em relação á covid-19.")]
        public string Período { get; set; }


        [Required(ErrorMessage = "Por favor, insira a classificação.")]
        [Display(Name = "Como classificaria os procedimentos e comportamentos tomados pelos funcionários perante a situação atual?")]
        public string Procedimentos { get; set; }

        [Required(ErrorMessage = "Por favor, insira a classificação.")]
        [Display(Name = "Se tivesse que recomendar o estabelecimento a um amigo/familiar/conhecido, que classificação daria de 0 a 10?")]
        public string Recomendação { get; set; }

        [Display(Name = "Comentário:")]
        public string Comentário { get; set; }

        public AvaliacaoRestaurante()
        {

        }
    }
}
