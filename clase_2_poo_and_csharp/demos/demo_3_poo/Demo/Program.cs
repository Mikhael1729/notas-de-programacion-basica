using static System.Console;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Título
            WriteLine(
                "Mascotas de Mikhael\n",
                "-------------------\n"
            );

            // Crear mis mascotas.
            var perro = new Perro("Dobi", 7);
            var gato = new Gato("Gari", 1);
            var serpiente = new Serpiente("Snake", 2);

            // Sacar a pasear al perro y al gato.
            WriteLine("SACAR A PASEAR:\n");

            WriteLine($"Saco a {perro.Nombre} a pasear.");
            SacarAPasear(perro);

            WriteLine("");

            WriteLine($"Saco a {gato.Nombre} a pasear.");
            SacarAPasear(gato);

            WriteLine("");

            // Hacer brincar a los animales.
            WriteLine("HACER BRINCAR\n");
            HacerSaltar(perro);
            HacerSaltar(gato);
            HacerSaltar(serpiente);
        }

        static void SacarAPasear(Animal animal)
        {
            WriteLine($"Mikhael saca a pasear a {animal.Nombre}");
            animal.Caminar();
        }

        static void HacerSaltar(Animal animal) => animal.Saltar();
    }
}
