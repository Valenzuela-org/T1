Console.WriteLine("-------------------------------------------");
Console.WriteLine("++++++++++ BIENVENIDO AL BANCO ++++++++++");
Console.WriteLine("++++++++++  SISTEMA DE CAJERO   ++++++++++");
Console.WriteLine("-------------------------------------------");

double saldo = 1000.0; // Saldo inicial base
        int opcion = 0;

        while (opcion != 4) {
            Console.WriteLine("\n--- MENÚ DE OPERACIONES ---");
            Console.WriteLine("1. Consultar saldo");
            Console.WriteLine("2. Depositar dinero");
            Console.WriteLine("3. Retirar dinero");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            if (opcion == 1) {
                Console.WriteLine($"Su saldo actual es: ${saldo:F2}");
            }
            // Las demás opciones se implementarán en la siguiente fase
        }
        Console.WriteLine("Gracias por usar nuestros servicios.");