using pratico.Data;
using pratico.Models;

namespace Teste1EF
{
    internal class Program
    {
        static string codigo = "105800";

        private static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Entity Framework Core");

            using var context = new DataContext();

            var novoPais = new Pais
            {
                Nome = "País de Marcio",
                Codigo = "105800"
            };

            context.Paises.Add(novoPais);
            context.SaveChanges();

            var novoEstado = new Estado
            {
                Nome = "Estado de Marcio",
                Sigla = "EM",
                CodigoIbge = 1234567,
                PaisId = novoPais.Id
                // Pais = novoPais
            };

            context.Estados.Add(novoEstado);
            context.SaveChanges();

            Console.WriteLine($"País inserido: {novoPais.Id}, {novoPais.Nome}, Código: {novoPais.Codigo}");
            Console.WriteLine($"Estado inserido: {novoEstado.Id}, {novoEstado.Nome}, CódigoIbge: {novoEstado.CodigoIbge}");
        }

        static void InserirPais(DataContext context)
        {
            var novoPais = new Pais
            {
                Nome = "País de Marcio",
                Codigo = codigo
            };

            context.Paises.Add(novoPais);
            context.SaveChanges();
            Console.WriteLine($"País inserido: {novoPais.Id}, {novoPais.Nome}, Código: {novoPais.Codigo}");

            var novoEstado = new Estado
            {
                Nome = "Estado de Marcio",
                Sigla = "EM",
                CodigoIbge = 2304400,
                PaisId = novoPais.Id
            };

            context.Estados.Add(novoEstado);
            context.SaveChanges();

            // Console.WriteLine($"País inserido: {novoPais.Id}, {novoPais.Nome}, Código: {novoPais.Codigo}");
        }

    }
}