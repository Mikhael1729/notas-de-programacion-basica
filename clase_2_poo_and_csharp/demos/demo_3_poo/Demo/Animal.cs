using static System.Console;

namespace Demo
{
    public abstract class Animal
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Animal(string nombre, int edad)
        {
            this.Nombre = nombre;
            this.Edad = edad;
        }

        public virtual void Caminar()
        {
            WriteLine($"¡Yo, {Nombre} camino:");

            for(var i = 0; i < 10; i++)
                WriteLine(
                    "Muevo un pie",
                    "Pongo mi pie derecho."
                );
        }

        public abstract void Saltar(); // Todos los animales están obligados a implementar éste método.
    }
}

