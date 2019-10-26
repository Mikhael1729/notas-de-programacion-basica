using static System.Console;

namespace Demo
{
    public class Perro : Animal
    {
        public Perro (string nombre, int edad) : base(nombre, edad)
        { }

        public void Ladrar ()
        {
            WriteLine ($"¡Yo, {Nombre} ladro!");
        }

        public override void Saltar () => 
            WriteLine("¡Guaugh! Me coloco sobre mis patas traseras y me impulso");
    }
}
