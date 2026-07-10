  Console.WriteLine("Hello, World!");
        int a; 
        int b; 
        a=10; 
        b=a; 
        Console.WriteLine("valor de a:"+a); 
        Console.WriteLine("valor de b:"+b); 

        Console.Write("Por favor, ingrese un número: ");
        string? entrada = Console.ReadLine();

        int numero = 0; 
        bool esNumero = int.TryParse(entrada, out numero);

        if (esNumero)
        {
         
            if (numero > 0)
            {
                int numeroInvertido = 0;
                int auxiliar = numero;

                // Ciclo iterativo while (pág. 44)
                while (auxiliar > 0)
                {
                    int ultimoDigito = auxiliar % 10;
                    numeroInvertido = (numeroInvertido * 10) + ultimoDigito;
                    auxiliar = auxiliar / 10;
                }

                Console.WriteLine("El número invertido es: " + numeroInvertido);
            }
            else
            {
                Console.WriteLine("Error: El número debe ser mayor a 0.");
            }
        }
        else
        {
            Console.WriteLine("Error: El texto ingresado no es un número válido.");
        }
 