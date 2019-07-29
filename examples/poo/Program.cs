using static System.Console;

namespace poo
{

    class Persona
    {
        public string Nombre;
        public string Apellido;

        public Persona (string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

        public void Camina ()
        {
            Presentarse();
            
            for (var i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                    WriteLine ("- Mover pié izquierdo");
                else
                    WriteLine ("- Mover pié derecho");
            }
        }

        private void Presentarse()
        {
            WriteLine ($"Yo, {Nombre}, camino: \n");
        }
    }

    class Estudiante : Persona
    {
        public string Matricula;

        public Estudiante (string nombre, string apellido, string matricula="") : base (nombre, apellido)
        {
            this.Matricula = matricula;
        }

        public void MuestraMatricula ()
        {
            WriteLine ($"Mi maticula es {Matricula}");
        }

        public void Estudia()
        {
            WriteLine($"Yo, {Nombre} estoy estudiando...");
        }
    }

    class Program
    {
        static void Main (string[] args)
        {
            /*- Ejemplo de Herencia -*/
            var hilel = new Estudiante ("Hilel", "Rodríguez");

            // Estudiante hereda de Persona, por lo que puede caminar.
            hilel.Camina ();

            /*- Ejemplo de Polimorfismo -*/
            Persona abraham = new Estudiante("Abraham", "Santos", "20190123");
            abraham.Estudia(); // No puede estudiar porque es abraham es solo una Persona.
        }
    }
}