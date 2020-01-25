using System;

namespace Compromiso1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            input = Console.ReadLine();
            Validator validator = new Validator(input);

            Console.WriteLine($"¿La entrada es una matrícula válida?  {validator.IsValidMatriculationNumber()}");
            Console.WriteLine($"¿La entrada es un código de asignatura de la PVA válido?  {validator.IsValidPVASubjectCode()}");
            Console.WriteLine($"¿La entrada es un teléfono dominicano válido?  {validator.IsValidDominicanPhoneNumber()}");
            Console.WriteLine($"¿La entrada es una dirección de correo válida?  {validator.IsValidEmailAddress()}");
            Console.WriteLine($"¿La entrada es una dirección URL válido?  {validator.IsValidURLAddress()}");
            Console.ReadKey();
        }
    }
}
