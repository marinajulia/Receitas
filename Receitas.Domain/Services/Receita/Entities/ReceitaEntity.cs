using System.ComponentModel.DataAnnotations;

namespace Receitas.Domain.Services.Receitas.Entities
{
    public class ReceitaEntity
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Dificuldade { get; set; }
        public double Horas { get; set; }
    }
}
