
class Program
{
    static void Main()
    {
        // ====================================================
        // PARTE 1: CALCULADORA V1 (Operaciones Básicas)
        // ====================================================
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

            Console.Write("\n¿Desea realizar otro cálculo en la V1? (s/n): ");
            string? entradaContinuar = Console.ReadLine();
            continuar = entradaContinuar != null ? entradaContinuar.ToLower() : "n";

        } while (continuar == "s");


        // ====================================================
        // PARTE 2: CALCULADORA V2 (Funciones Avanzadas)
        // ====================================================
        Console.WriteLine("\nPresione cualquier tecla para pasar a la CALCULADORA V2...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("=== CALCULADORA V2 ===");
        Console.Write("Ingrese un número (puede ser decimal/float): ");
        float numero = 0;
        bool esFloatValido = float.TryParse(Console.ReadLine(), out numero);

        if (esFloatValido)
        {
            Console.WriteLine("\nResultados para el número " + numero + ":");
            Console.WriteLine("- Valor absoluto: " + Math.Abs(numero));
            Console.WriteLine("- El cuadrado: " + Math.Pow(numero, 2));

            if (numero >= 0)
            {
                Console.WriteLine("- La raíz cuadrada: " + Math.Sqrt(numero));
            }
            else
            {
                Console.WriteLine("- La raíz cuadrada: No existe en reales");
            }

            Console.WriteLine("- El seno: " + Math.Sin(numero));
            Console.WriteLine("- El coseno: " + Math.Cos(numero));

            int parteEntera = (int)numero; 
            Console.WriteLine("- La parte entera de un tipo float: " + parteEntera);
        }
        else
        {
            Console.WriteLine("Error: El valor ingresado no es un número float válido.");
        }

        // PARTE 3: Comparación de dos números
        Console.WriteLine("\n--- Comparación de dos números ---");
        float n1 = 0;
        float n2 = 0;

        Console.Write("Ingrese el primer número: ");
        bool n1Ok = float.TryParse(Console.ReadLine(), out n1);

        Console.Write("Ingrese el segundo número: ");
        bool n2Ok = float.TryParse(Console.ReadLine(), out n2);

        if (n1Ok && n2Ok)
        {
            Console.WriteLine("El Máximo entre ambos es: " + Math.Max(n1, n2));
            Console.WriteLine("El Mínimo entre ambos es: " + Math.Min(n1, n2));
        }
        else
        {
            Console.WriteLine("Error: Valores incorrectos.");
        }

        Console.WriteLine("\n¡Programa finalizado con éxito!");
    }
}