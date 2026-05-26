
class Program
{
    static void Main()
    {
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
            
            // Casteo explícito a entero para obtener la parte entera (pág. 27, 46)
            int parteEntera = (int)numero; 
            Console.WriteLine("- La parte entera de un tipo float: " + parteEntera);
        }
        else
        {
            Console.WriteLine("Error: El valor ingresado no es un número float válido.");
            return; 
        }

        // PARTE 2: Máximos y Mínimos con dos números
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
    }
}