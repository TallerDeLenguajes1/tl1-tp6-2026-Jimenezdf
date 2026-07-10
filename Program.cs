

Console.Write("Ingrese una cadena de texto principal: ");
string cadenaPrincipal = Console.ReadLine() ?? "";
Console.WriteLine($"Longitud de la cadena: {cadenaPrincipal.Length} caracteres.");


Console.Write("\nIngrese una segunda cadena para concatenar: ");
string cadenaSegunda = Console.ReadLine() ?? "";
string cadenaConcatenada = string.Concat(cadenaPrincipal, " ", cadenaSegunda);
Console.WriteLine($"Cadena concatenada resultante: \"{cadenaConcatenada}\"");

Console.WriteLine("\n--- Extracción de Subcadena ---");
if (cadenaPrincipal.Length > 3)
{
    string subcadena = cadenaPrincipal.Substring(0, 3);
    Console.WriteLine($"Subcadena extraída (primeros 3 caracteres): \"{subcadena}\"");
}
else
{
    Console.WriteLine("La cadena es muy corta para extraer 3 caracteres.");
}

Console.WriteLine("\n--- Formateo con la Calculadora (ToString) ---");
double num1 = 582.45;
double num2 = 2.10;
double resultadoSuma = num1 + num2;
Console.WriteLine("la suma de \"" + num1.ToString("F2") + "\" y de \"" + num2.ToString("F2") + "\" es igual a: \"" + resultadoSuma.ToString("F2") + "\"");

Console.WriteLine("\n--- Recorriendo la cadena principal con foreach ---");
Console.Write("Caracteres separados: ");
foreach (char caracter in cadenaPrincipal)
{
    Console.Write($"[{caracter}] ");
}
Console.WriteLine();

Console.WriteLine("\n--- Búsqueda de palabra ---");
Console.Write("Ingrese la palabra que desea buscar dentro de la cadena principal: ");
string palabraBuscar = Console.ReadLine() ?? "";
int posicion = cadenaPrincipal.IndexOf(palabraBuscar, StringComparison.OrdinalIgnoreCase);

if (posicion != -1)
{
    Console.WriteLine($"¡Encontrada! La palabra \"{palabraBuscar}\" comienza en el índice {posicion}.");
}
else
{
    Console.WriteLine($"La palabra \"{palabraBuscar}\" no se encuentra en la cadena.");
}

Console.WriteLine("\n--- Conversión de Caso ---");
Console.WriteLine($"En Mayúsculas: {cadenaPrincipal.ToUpper()}");
Console.WriteLine($"En Minúsculas: {cadenaPrincipal.ToLower()}");

Console.WriteLine("\n--- Segmentación de cadena (Split) ---");
Console.Write("Ingrese una lista de palabras separadas por comas (ej: rojo,azul,verde): ");
string cadenaLista = Console.ReadLine() ?? "";
string[] elementos = cadenaLista.Split(',');

Console.WriteLine("Elementos extraídos individualmente:");
for (int i = 0; i < elementos.Length; i++)
{
    Console.WriteLine($"- Elemento {i + 1}: {elementos[i].Trim()}");
}

Console.WriteLine("\n--- Resolución de Ecuación Simple ---");
Console.Write("Ingrese una ecuación simple sin espacios (ej: 582+2 o 10*5): ");
string ecuacion = Console.ReadLine() ?? "";

char[] operadoresValidos = { '+', '-', '*', '/' };
int indiceOperador = ecuacion.IndexOfAny(operadoresValidos);

if (indiceOperador != -1)
{
    char operador = ecuacion[indiceOperador];
    string[] partes = ecuacion.Split(operador);

    if (partes.Length == 2 && double.TryParse(partes[0], out double nEcuacion1) && double.TryParse(partes[1], out double nEcuacion2))
    {
        double resEcuacion = 0;
        bool operacionValida = true;

        switch (operador)
        {
            case '+': resEcuacion = nEcuacion1 + nEcuacion2; break;
            case '-': resEcuacion = nEcuacion1 - nEcuacion2; break;
            case '*': resEcuacion = nEcuacion1 * nEcuacion2; break;
            case '/':
                if (nEcuacion2 != 0) resEcuacion = nEcuacion1 / nEcuacion2;
                else { Console.WriteLine("Error: División por cero."); operacionValida = false; }
                break;
        }

        if (operacionValida)
        {
            string nombreOperacion = operador switch { '+' => "suma", '-' => "resta", '*' => "multiplicación", '/' => "división", _ => "" };
            Console.WriteLine($"La {nombreOperacion} de {partes[0]} con {partes[1]} es igual a: {resEcuacion}");
        }
    }
    else
    {
        Console.WriteLine("Error: Formato de ecuación inválido. Asegúrese de ingresar dos números.");
    }
}
else
{
    Console.WriteLine("Error: No se detectó un operador válido (+, -, *, /).");
}

Console.WriteLine("\n¡Ejercicio 4 finalizado con éxito!");