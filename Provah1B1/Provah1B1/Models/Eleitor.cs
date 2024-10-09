using System.ComponentModel.DataAnnotations;
using Provah1B1.Validation;

namespace Provah1B1.Models
{
    public class Eleitor
    {
        [Required(ErrorMessage = "Campo obrigatório!")]
        [ValidacaoNome(ErrorMessage = "Nome com pouco caracter!")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "Campo obrigatório!")]
        [ValidacaoDescricao(ErrorMessage = "Falta justificativa!")]
        public string Descricao { get; set; }


        [Required(ErrorMessage = "Campo obrigatório!")]
        [ValidacaoIdade(ErrorMessage = "É menor de 16!")]
        public int Idade { get; set; }


        [Required(ErrorMessage = "Campo obrigatório!")]

        public int TituloEleitor { get; set; }
        [Required(ErrorMessage = "Campo obrigatório!")]

        public string Cidade { get; set; }


      
    }
}
