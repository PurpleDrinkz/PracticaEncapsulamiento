using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Practica_Encapsulamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            Contacto contactoUno = new Contacto();

            contactoUno.Nombre = "Benjamin Ortega";
            contactoUno.Direccion = "Tamaulipas 532";
            contactoUno.CorreoElectronico = "xbenja123@gmail.com";
            contactoUno.TelefonoCasa = "4223258";
            contactoUno.TelefonoCelular = "6421166822";

            Console.WriteLine("Nombre: " + contactoUno.Nombre);
            Console.WriteLine("Dirección: " + contactoUno.Direccion);
            Console.WriteLine("Correo: " + contactoUno.CorreoElectronico);
            Console.WriteLine("Telefono: " + contactoUno.TelefonoCasa);
            Console.WriteLine("Celular: " + contactoUno.TelefonoCelular);

            Console.ReadLine();
        }

    }
}
