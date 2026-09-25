namespace PF01._Actividad_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("David", 25, true);
            persona.EsMayorDeEdad();
            Persona persona1 = new Persona("Juan", 30, true);
            persona1.Nombre = "Juan Pérez";
        }
    }
}
