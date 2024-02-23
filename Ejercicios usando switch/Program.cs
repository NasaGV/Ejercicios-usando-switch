using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine(" \nMenu de seleccion: ");
            Console.WriteLine("1. Convertir numero a letras: ");
            Console.WriteLine("2. Dias de la semana a partir de numeros: ");
            Console.WriteLine("3. Calcular importe a pagar por un servicio: ");
            Console.WriteLine("4. Mensajes de bienvenidas en diferentes idiomas: ");
            Console.WriteLine("5. Evaluar calificacion de un examen: ");
            Console.WriteLine("0. Para salir del programa: ");

            Console.Write("Ingrese su opción: ");
            int opcion;
            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        ConvertirNumeroALetras();
                        break;
                    case 2:
                        MenuDiasDeLaSemana();
                        break;
                    case 3:
                        MenuCalcularImporte();
                        break;
                    case 4:
                        MenuBienvenida();
                        break;
                    case 5:
                        MenuCalificaciones();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                        break;
                }
            }
            Console.WriteLine();
        }
    }

    static void ConvertirNumeroALetras()
    {
        Console.WriteLine("\nIngrese un número del 1 al 5 en letra: ");
        string numeroEnLetra = Console.ReadLine().ToLower(); 

        int numero;

        switch (numeroEnLetra)
        {
            case "uno":
                numero = 1;
                break;
            case "dos":
                numero = 2;
                break;
            case "tres":
                numero = 3;
                break;
            case "cuatro":
                numero = 4;
                break;
            case "cinco":
                numero = 5;
                break;
            default:
                Console.WriteLine("Por favor ingresar el numero en letras.");
                return;
        }

        Console.WriteLine($"El número en dígito es: {numero}");
    }

    static void MenuDiasDeLaSemana()
    {
        Console.WriteLine("\nIngrese un numero para saber a que dia de la semana corresponde: (1 al 7) ");
        int opcion;
       if (int.TryParse(Console.ReadLine(), out opcion))
        {
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Domingo");
                    break;
                case 2:
                    Console.WriteLine("Lunes");
                    break;
                case 3:
                    Console.WriteLine("Martes");
                    break;
                case 4:
                    Console.WriteLine("Miercoles");
                    break;
                case 5:
                    Console.WriteLine("Jueves");
                    break;
                case 6:
                    Console.WriteLine("Viernes");
                    break;
                case 7:
                    Console.WriteLine("Sabado");
                    break;
                default:
                    Console.WriteLine("El Numero Ingresado no es valido por favor ingresar solo en el rango de 1-7; ");
                    break;

            }

        }
       else
        {
            Console.WriteLine("Por Favor ingresar solo numeros: ");
        }

    }

    static void MenuCalcularImporte()
    {
        Console.WriteLine("\nSelecciona el tipo de servicio: ");
        Console.WriteLine("1. Lavado de auto");
        Console.WriteLine("2. Cambio de aceite");
        Console.WriteLine("3. Revisión mecánica");
        Console.Write("Ingrese su opción: ");
        int opcion;
        if (int.TryParse(Console.ReadLine(), out opcion))
        {
            double importe;
            switch (opcion)
            {
                case 1:
                    importe = 15; 
                    Console.WriteLine($"El importe a pagar por el lavado de auto es: {importe}");
                    break;
                case 2:
                    importe = 100; 
                    Console.WriteLine($"El importe a pagar por el cambio de aceite es: {importe}");
                    break;
                case 3:
                    importe = 300; 
                    Console.WriteLine($"El importe a pagar por la revisión mecánica es: {importe}");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Por favor, ingrese solo números.");
        }
    }

    static void MenuBienvenida()
    {
        Console.Write("\nIngrese su idioma (español, ingles, frances): ");
        string idioma = Console.ReadLine().ToLower(); 

        switch (idioma)
        {
            case "español":
                Console.WriteLine("¡Bienvenido! Gracias por usar nuestro programa. ");
                break;
            case "ingles":
                Console.WriteLine("Welcome! Thank you for using our program. ");
                break;
            case "frances":
                Console.WriteLine("Accueillir! Merci d'utiliser notre programme. ");
                break;
            default:
                Console.WriteLine("Idioma no válido. Por favor, seleccione uno de los idiomas disponibles.");
                break;
        }
    }

    static void MenuCalificaciones()
    {
        Console.WriteLine("\nIngrese la calificación de tu examen: ");
        if (int.TryParse(Console.ReadLine(), out int calificacion))
        {
            switch (calificacion)
            {
                case int n when (n >= 95 && n <= 100):
                    Console.WriteLine("!Felicidades! eres un estudiante sobresaliente sigue asi. ");
                    break;
                case int n when (n >= 80 && n <= 94):
                    Console.WriteLine("Increible se nota que te has esforzado eres alguien notable.");
                    break;
                case int n when (n >= 62 && n <= 79):
                    Console.WriteLine("nada mal, pero debes esforzarte mas opara seguir aprobando");
                    break;
                case int n when (n >= 1 && n <= 59):
                    Console.WriteLine("Muy mal, no has aprobado debes esforzarte mucho mas la proxima vez...");
                    break;
                case int n when (n >= 60 && n <= 61):
                    Console.WriteLine(" has aprobado por poco se nota que te has esforzado pero puedes ser mejor no te rindas :) ");
                    break;
                default:
                    Console.WriteLine("La calificación ingresada no es válida.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Por favor, ingrese una calificación válida (número entero).");
        }
    }
}
