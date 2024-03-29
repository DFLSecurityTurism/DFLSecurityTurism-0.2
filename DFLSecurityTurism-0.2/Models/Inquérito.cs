﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DFLSecurityTurism_0._2.Models
{
    public class Inquérito
    {
        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage = "Por favor, insira o tipo de estabelecimento.")]
        [Display(Name = "Tipo de estabelecimento?")]
        public string TipoDeEstabelecimento { get; set; }


        [Required(ErrorMessage = "Por favor, insira o nome do estabelecimento.")]
        [Display(Name = "Nome?")]
        [StringLength(100)]
        public string Nome { get; set; }


        [Required(ErrorMessage = "Por favor, insira quantos certificados de segurança tem.")]
        [Display(Name = "Quantos certificados de segurança tem?")]
        public int QuantosCertificadosDeSegurançaTem { get; set; }


        [Required(ErrorMessage = "Por favor, diga quais são os certificados de segurança que tem.")]
        [Display(Name = "Quais são?")]
        public string QuaisSão { get; set; }

        [Required(ErrorMessage = "Por favor, diga que mecanismos de segurança o estabelecimento utiliza.")]
        [Display(Name = "Que Mecanismos de segurança o estabelecimento utiliza?")]
        public string QueMecanismosDeSegurançaOEstabelecimentoUtiliza { get; set; }

        [Required(ErrorMessage = "Por favor, diga quantos equipamentos de segurança o estabelecimento utiliza.")]
        [Display(Name = "Quantos equipamentos de segurança o estabelecimento utiliza?")]
        public int QuantosEquipamentosDeSegurançaOEstabelecimentoUtiliza { get; set; }

        [Required(ErrorMessage = "Por favor, diga quais são os equipamentos de segurança que tem.")]

        [Display(Name = "Quais são os equipamentos de segurança que tem?")]
        public string QuaisSãoOsEquipamentosDeSegurançaQueTem { get; set; }

        [Required(ErrorMessage = " Por favor, escolha uma imagem para ser exibida no website.")]
        public string Imagem { get; set; }

        public Inquérito()
        {

        }
    }
}
