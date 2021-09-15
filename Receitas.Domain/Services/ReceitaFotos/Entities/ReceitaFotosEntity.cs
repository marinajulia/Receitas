using Receitas.Domain.Services.Receitas.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Receitas.Domain.Services.ReceitaFotos.Entities
{
    public class ReceitaFotosEntity
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Receita")]
        public int IdReceita { get; set; }
        public ReceitaEntity IdReceitas { get; set; }

        public byte[] File { get; set; }
        public string Format { get; set; }
    }
}
