
class Program
{
    static void Main()
    {
        string continuar;
        do
        {
            Console.Clear();
            Console.WriteLine("=== TITULO EXCLUSIVO DE LA V1 ===");
            Console.WriteLine("=== CALCULADORA V1 ===");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.Write("Seleccione una opción (1-4): ");
            string opcion = Console.ReadLine();

            
            if (opcion != "1" && opcion != "2" && opcion != "3" && opcion != "4")
            {
                Console.WriteLine("Opción no válida.");
            }
            else
            {
             
                Console.Write("Ingrese el primer número: ");
                if (!double.TryParse(Console.ReadLine(), out double num1))
                {
                    Console.WriteLine("Error: El primer valor no es un número válido.");
                }
               
                else Console.Write("Ingrese el segundo número: ");
                if (!double.TryParse(Console.ReadLine(), out double num2))
                {
                    Console.WriteLine("Error: El segundo valor no es un número válido.");
                }
                else
                {
                    // Realizar operaciones
                    switch (opcion)
                    {
                        case "1":
                            Console.WriteLine($"Resultado: {num1} + {num2} = {num1 + num2}");
                            break;
                        case "2":
                            Console.WriteLine($"Resultado: {num1} - {num2} = {num1 - num2}");
                            break;
                        case "3":
                            Console.WriteLine($"Resultado: {num1} * {num2} = {num1 * num2}");
                            break;
                        case "4":
                            if (num2 == 0)
                            {
                                Console.WriteLine("Error: No se puede dividir entre cero.");
                            }
                            else
                            {
                                Console.WriteLine($"Resultado: {num1} / {num2} = {num1 / num2}");
                            }
                            break;
                    }
                }
            }

            Console.Write("\n¿Desea realizar otro cálculo? (s/n): ");
            continuar = Console.ReadLine().ToLower();

        } while (continuar == "s");
    }
}