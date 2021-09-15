namespace Receitas.Domain.Services.Receita.Dto
{
    public class ReceitaDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Dificuldade { get; set; }
        public double Horas { get; set; }
    }
}
