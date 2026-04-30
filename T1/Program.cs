Console.WriteLine("-------------------------------------------");
Console.WriteLine("++++++++++ BIENVENIDO AL BANCO ++++++++++");
Console.WriteLine("++++++++++  SISTEMA DE CAJERO   ++++++++++");
Console.WriteLine("-------------------------------------------");

double saldo = 1000.0; 
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
            else if (opcion == 2) {
                Console.Write("Ingrese monto a depositar: ");
                double deposito = double.Parse(Console.ReadLine());
                if (deposito > 0) {
                    saldo += deposito;
                    Console.WriteLine("Depósito exitoso.");
                } else {
                    Console.WriteLine("Monto inválido.");
                }
            }
            else if (opcion == 3) {
                Console.Write("Ingrese monto a retirar: ");
                double retiro = double.Parse(Console.ReadLine());
                // Condicional anidada para validar fondos
                if (retiro > saldo) {
                    Console.WriteLine("Error: Fondos insuficientes.");
                } else if (retiro <= 0) {
                    Console.WriteLine("Monto inválido.");
                } else {
                    saldo -= retiro;
                    Console.WriteLine("Retiro exitoso.");
        }
        Console.WriteLine("Gracias por usar nuestros servicios.");
            }
        }