using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DFLSecurityTurism_0._2.Models
{
    public class Inquérito
    {
        public int Id { get; set; }

        [Display(Name = "Tipo de estabelecimento?")]
        public string Tipodeestabelecimento { get; set; }

        [Display(Name = "Nome?")]
        public string Nome { get; set; }

        [Display(Name = "Quantos certificados de segurança tem?")]
        public int Quantoscertificadosdesegurançatem { get; set; }

        [Display(Name = "Quais são?")]
        public string Quaissão { get; set; }

        [Display(Name = "Que mecanismos de segurança o estabelecimento utiliza?")]
        public string QueMecanismosdesegurançaoestabelecimentoutiliza { get; set; }

        [Display(Name = "Quantos equipamentos de segurança o estabelecimento utiliza?")]
        public int Quantosequipamentosdesegurançaoestabelecimentoutiliza { get; set; }

        [Display(Name = "Quais são?")]
        public string Quaissãoo { get; set; }
        public Inquérito()
        {

        }
    }
}
