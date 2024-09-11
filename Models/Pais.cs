using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pratico.Models
{
    public class Pais
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required int Codigo { get; set; }

        // public List<Estado>? Estados { get; set; }
    }
}