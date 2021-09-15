﻿using Receitas.Domain.Services.Receita.Dto;
using System.Collections.Generic;

namespace Receitas.Domain.Services.Receita
{
    public interface IReceitaService
    {
        ReceitaDto Post(ReceitaDto receitaDto);
        IEnumerable<ReceitaDto> Get();
        IEnumerable<ReceitaDto> GetById();
        IEnumerable<ReceitaDto> GetByName(string nome);
        bool Delete(int receita);

    }
}
