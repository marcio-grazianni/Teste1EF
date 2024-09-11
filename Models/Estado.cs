namespace pratico.Models
{
    public class Estado
    {
        public long Id { get; set; }
        public string? Nome { get; set; }
        public string? Sigla { get; set; }
        public int? CodigoIbge { get; set; }
        public DateTime DataCadastro { get; set; }
        public TimeSpan HoraCadastro { get; set; }

        // Chave estrangeira
        public int PaisId { get; set; }
        public Pais? Pais { get; set; }
    }
}
