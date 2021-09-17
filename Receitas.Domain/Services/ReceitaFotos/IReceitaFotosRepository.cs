using Receitas.Domain.Services.ReceitaFotos.Entities;
using System.Collections.Generic;

namespace Receitas.Domain.Services.ReceitaFotos
{
    public interface IReceitaFotosRepository
    {
        IEnumerable<ReceitaFotosEntity> Get();
        ReceitaFotosEntity GetById(int id);
        bool Delete(ReceitaFotosEntity foto);
        ReceitaFotosEntity Post(ReceitaFotosEntity foto);

    }
}
