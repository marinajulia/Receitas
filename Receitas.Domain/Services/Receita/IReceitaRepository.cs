using Receitas.Domain.Services.Receitas.Entities;
using System.Collections.Generic;

namespace Receitas.Domain.Services.Receita
{
    public interface IReceitaRepository
    {
        IEnumerable<ReceitaEntity> Get();
        IEnumerable<ReceitaEntity> GetByName(string name);
        ReceitaEntity GetById(int id);
        ReceitaEntity GetNames(string name);
        bool Delete(ReceitaEntity receita);
        ReceitaEntity Post(ReceitaEntity receita);

    }
}
