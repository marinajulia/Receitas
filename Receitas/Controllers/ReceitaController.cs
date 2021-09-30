using Microsoft.AspNetCore.Mvc;
using Receitas.Domain.Services.Receita;
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
    }
}
