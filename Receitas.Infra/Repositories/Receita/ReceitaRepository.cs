using Receitas.Domain.Services.Receita;
using Receitas.Domain.Services.Receitas.Entities;
using Receitas.Infra.Data;
using System.Collections.Generic;
using System.Linq;

namespace Receitas.Infra.Repositories.Receita
{
    public class ReceitaRepository : IReceitaRepository
    {
        public bool Delete(ReceitaEntity receita)
        {
            using (var context = new ApplicationContext())
            {
                context.Receitas.Remove(receita);
                context.SaveChanges();
                return true;
            }
        }

        public IEnumerable<ReceitaEntity> Get()
        {
            using (var context = new ApplicationContext())
            {
                var receitas = context.Receitas;
                return receitas.ToList();
            }
        }

        public ReceitaEntity GetById(int id)
        {
            using (var context = new ApplicationContext())
            {
                var receita = context.Receitas.FirstOrDefault(x => x.Id == id);
                return receita;
            }
        }

        public IEnumerable<ReceitaEntity> GetByName(string name)
        {
            using (var context = new ApplicationContext())
            {
                var receita = context.Receitas
                    .Where(x => x.Nome.Trim().ToLower().Contains(name));
                return receita.ToList();
            }
        }

        public ReceitaEntity GetNames(string name)
        {
            using (var context = new ApplicationContext())
            {
                var receita = context.Receitas.FirstOrDefault(x => x.Nome.Trim().ToLower() == name.Trim().ToLower());
                return receita;
            }
        }

        public ReceitaEntity Post(ReceitaEntity receita)
        {
            using (var context = new ApplicationContext())
            {
                context.Receitas.Add(receita);
                context.SaveChanges();
                return receita;
            }
        }

        public bool Put(ReceitaEntity receita)
        {
            using (var context = new ApplicationContext())
            {
                context.Receitas.Update(receita);
                context.SaveChanges();
                return true;
            }
        }
    }
}
