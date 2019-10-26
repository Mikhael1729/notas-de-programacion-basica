using static System.Console;

namespace Demo
{
    public class Serpiente : Animal
    {
        public Serpiente (string nombre, int edad) : base(nombre, edad)
        { }

        public void Hablar () => WriteLine ($"Yo, {Nombre} Zzzzzzz!");

        public override void Caminar() =>
            WriteLine(
                "Me deslizo a la izquierda\n" + 
                "Me deslizo a la derecha"
            );

        public override void Saltar() => 
            WriteLine("¡Zzz! Me coloco sobre mi cola, tomo impulso y brinco");
    }
}
