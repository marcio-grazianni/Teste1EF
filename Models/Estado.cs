using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pratico.Models
{
    public class Estado
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public int CodigoIbge { get; set; }
        public int PaisId { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime HoraCadastro { get; set; }
    }
}