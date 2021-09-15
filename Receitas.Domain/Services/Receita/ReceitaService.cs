using Receitas.Domain.Services.Receita;
using Receitas.Domain.Services.Receita.Dto;
using System;
using System.Collections.Generic;

namespace Receitas.Domain.Services
{
    public class ReceitaService : IReceitaService
    {
        public bool Delete(int receita)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReceitaDto> Get()
        {
            throw new NotImplementedException();
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
