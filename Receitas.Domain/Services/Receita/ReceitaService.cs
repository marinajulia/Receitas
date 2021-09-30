using Receitas.Domain.Services.Receita;
using Receitas.Domain.Services.Receita.Dto;
using Receitas.SharedKernel.Notification;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Receitas.Domain.Services
{
    public class ReceitaService : IReceitaService
    {

        private readonly INotification _notification;
        private readonly IReceitaRepository _receitaRepository;

        public ReceitaService(IReceitaRepository receitaRepository, INotification notification)
        {
            _receitaRepository = receitaRepository;
            _notification = notification;
        }

        public bool Delete(int receita)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReceitaDto> Get()
        {
            var receita = _receitaRepository.Get();

            if (receita == null)
                return _notification.AddWithReturn<IEnumerable<ReceitaDto>>("Ops.. parece que não existe nenhuma receita no momento");

            return receita.Select(x => new ReceitaDto
            {
                Id = x.Id,
                Descricao = x .Descricao,
                Dificuldade = x.Dificuldade,
                Horas = x.Horas,
                Nome = x.Nome
            });
        }

        public IEnumerable<ReceitaDto> GetById()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReceitaDto> GetByName(string nome)
        {
            throw new NotImplementedException();
        }

        public ReceitaDto Post(ReceitaDto receitaDto)
        {
            throw new NotImplementedException();
        }
    }
}
