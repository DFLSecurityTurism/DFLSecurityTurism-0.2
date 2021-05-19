using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace DFLSecurityTurism_0._2.ViewModels
{
    public class InquéritoViewModel
    {
        [Required(ErrorMessage = "Por favor, insira o tipo de estabelecimento.")]
        [Display(Name = "Tipo de estabelecimento?")]
        public string TipoDeEstabelecimento { get; set; }


        [Required(ErrorMessage = "Por favor, insira o nome do estabelecimento.")]
        [Display(Name = "Nome?")]

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
        [Display(Name = "Imagem:")]
        public IFormFile Imagem { get; set; }
    }
}
