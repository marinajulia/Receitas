using Microsoft.AspNetCore.Mvc;
using Receitas.Domain.Services.Receita;
using Receitas.Domain.Services.Receita.Dto;
using Receitas.SharedKernel.Notification;

namespace Receitas.Api.Controllers
{
    [ApiController]
    [Route("receita")]
    public class ReceitaController : Controller
    {
        private readonly INotification _notification;
        private readonly IReceitaService _receitaService;

        public ReceitaController(IReceitaService receitaService, INotification notification)
        {
            _receitaService = receitaService;
            _notification = notification;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var receitas = _receitaService.Get();

            if (receitas == null)
                return BadRequest(_notification.GetNotifications());

            return Ok(receitas);
        }

        [HttpGet("id")]
        public IActionResult GetById(int id)
        {
            var receita = _receitaService.GetById(id);
            if(receita == null)
                return BadRequest(_notification.GetNotifications());

            return Ok(receita);
        }

        [HttpGet("name")]
        public IActionResult GetByName(string name)
        {
            var receita = _receitaService.GetByName(name);
            if (receita == null)
                return BadRequest(_notification.GetNotifications());

            return Ok(receita);
        }

        [HttpPost]
        public IActionResult Post(ReceitaDto receita)
        {
            var response = _receitaService.Post(receita);
            if (response == null)
                return BadRequest(_notification.GetNotifications());

            return Ok(response);
        }

        [HttpDelete]
        public IActionResult Delete (int id)
        {
            var response = _receitaService.Delete(id);

            if (!response)
                return BadRequest(_notification.GetNotifications());

            return Ok();
        }

        [HttpPut]
        public IActionResult Put (int Id, string Nome, string Descricao, int Dificuldade, double Horas)
        {
            var response = _receitaService.Put(Id, Nome, Descricao, Dificuldade, Horas);

            if (response == false)
                return BadRequest(_notification.GetNotifications());

            return Ok();
        }
    }
}
