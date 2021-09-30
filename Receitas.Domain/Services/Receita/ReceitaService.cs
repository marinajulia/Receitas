using Receitas.Domain.Services.Receita;
using Receitas.Domain.Services.Receita.Dto;
using Receitas.Domain.Services.Receitas.Entities;
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
            var receitas = _receitaRepository.Get();

            if (receitas == null)
                return _notification.AddWithReturn<IEnumerable<ReceitaDto>>("Ops.. parece que não existe nenhuma receita no momento");

            return receitas.Select(x => new ReceitaDto
            {
                Id = x.Id,
                Descricao = x.Descricao,
                Dificuldade = x.Dificuldade,
                Horas = x.Horas,
                Nome = x.Nome
            });
        }

        public ReceitaDto GetById(int id)
        {
            var receita = _receitaRepository.GetById(id);
            if (receita == null)
                return _notification.AddWithReturn<ReceitaDto>("Ops.. Nenhuma receita com esse id foi encontrada");

            return new ReceitaDto
            {
                Id = receita.Id,
                Descricao = receita.Descricao,
                Dificuldade = receita.Dificuldade,
                Horas = receita.Horas,
                Nome = receita.Nome
            };
        }

        public IEnumerable<ReceitaDto> GetByName(string nome)
        {
            var receita = _receitaRepository.GetByName(nome);
            if (receita == null)
                return _notification.AddWithReturn<IEnumerable<ReceitaDto>>("Ops.. Nenhuma receita com esse nome foi encontrada");

            return receita.Select(x => new ReceitaDto
            {
                Id = x.Id,
                Descricao = x.Descricao,
                Dificuldade = x.Dificuldade,
                Horas = x.Horas,
                Nome = x.Nome

            }).ToList();
        }

        public ReceitaDto Post(ReceitaDto receitaDto)
        {
            if (receitaDto.Nome == null || receitaDto.Descricao == null || receitaDto.Dificuldade < 0
                || receitaDto.Dificuldade > 10)
                return _notification.AddWithReturn<ReceitaDto>("Ops.. existem campos inválidos");

            var receita = _receitaRepository.Post(new ReceitaEntity
            {
                Descricao = receitaDto.Descricao,
                Dificuldade = receitaDto.Dificuldade,
                Horas = receitaDto.Horas,
                Nome = receitaDto.Nome
            });

            return new ReceitaDto
            {

                Id = receita.Id,
                Descricao = receita.Descricao,
                Dificuldade = receita.Dificuldade,
                Horas = receita.Horas,
                Nome = receita.Nome
            };
        }
    }
}
