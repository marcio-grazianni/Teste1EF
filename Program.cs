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

            // Inserir um novo país
            InserirPais(context);
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

            Console.WriteLine($"País inserido: {novoPais.Nome}, Código: {novoPais.Codigo}");
        }

    }
}