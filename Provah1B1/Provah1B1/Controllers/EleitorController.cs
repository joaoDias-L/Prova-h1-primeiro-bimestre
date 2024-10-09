using Microsoft.AspNetCore.Mvc;
using Provah1B1.Repository;
using Provah1B1.Models;
using Provah1B1.Validation;
using System.ComponentModel.DataAnnotations;


namespace Provah1B1.Controllers
{
    [ApiController]
    [Route("API/EleitorController")]
    public class EleitorController : ControllerBase

    {
        private readonly IEleitorRepository _eleitorRepository;
        public EleitorController(IEleitorRepository eleitorRepository)
        {
            _eleitorRepository = eleitorRepository;
        }


        [HttpPost]
        [Route("ReceberDados")]
        public IActionResult ReceberDados(Eleitor eleitor)
        {
            _eleitorRepository.InserirEleitor(new Eleitor()
            {
                Nome = eleitor.Nome,
                Descricao = eleitor.Descricao,
                Idade = eleitor.Idade,
                TituloEleitor = eleitor.TituloEleitor,
                Cidade = eleitor.Cidade,

            }
             );
            return Ok($"{eleitor.Nome}, justificativa concluída!");
        }


        [HttpGet]
        [Route("ObterJustificativas")]
        public IActionResult ObterCartas()
        {
            return Ok(_eleitorRepository.GetEleitores());
        }
    }
}
