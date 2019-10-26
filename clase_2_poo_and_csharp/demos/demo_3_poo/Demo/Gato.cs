using static System.Console;

namespace Demo
{
    public class Gato : Animal
    {
        public Gato (string nombre, int edad) : base(nombre, edad)
        { }

        public void Maullar () => WriteLine ($"¡Yo, {Nombre} maullo!");

        public override void Saltar() => 
            WriteLine("¡Miau! Me paro en mis patas traseras y me impulso");
    }
}
