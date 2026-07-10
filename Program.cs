string continuar = "";
        do
        {
            Console.Clear();
            Console.WriteLine("=== CALCULADORA V1 ===");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.Write("Seleccione una opción (1-4): ");
            string? opcion = Console.ReadLine();

            if (opcion != "1" && opcion != "2" && opcion != "3" && opcion != "4")
            {
                Console.WriteLine("Opción no válida.");
            }
            else
            {
                double num1 = 0;
                double num2 = 0;

                Console.Write("Ingrese el primer número: ");
                bool n1Valido = double.TryParse(Console.ReadLine(), out num1);

                Console.Write("Ingrese el segundo número: ");
                bool n2Valido = double.TryParse(Console.ReadLine(), out num2);

                if (n1Valido && n2Valido)
                {
                    switch (opcion)
                    {
                        case "1":
                            Console.WriteLine("Resultado: " + (num1 + num2));
                            break;
                        case "2":
                            Console.WriteLine("Resultado: " + (num1 - num2));
                            break;
                        case "3":
                            Console.WriteLine("Resultado: " + (num1 * num2));
                            break;
                        case "4":
                            if (num2 == 0)
                            {
                                Console.WriteLine("Error: No se puede dividir entre cero.");
                            }
                            else
                            {
                                Console.WriteLine("Resultado: " + (num1 / num2));
                            }
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Error: Uno o ambos valores no son números válidos.");
                }
            }

            Console.Write("\n¿Desea realizar otro cálculo? (s/n): ");
            string? entradaContinuar = Console.ReadLine();
            continuar = entradaContinuar != null ? entradaContinuar.ToLower() : "n";

        } while (continuar == "s");

