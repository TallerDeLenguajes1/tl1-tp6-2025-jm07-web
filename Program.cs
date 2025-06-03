// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);

//Ejercicio 1
int numero = 0;
int invertido = 0;
int dig;
string numeroString;

while (true)
{
    Console.WriteLine("Ingrese un numero entero: ");
    numeroString = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(numeroString))
    {
        Console.WriteLine("No puede ingresar una entrada vacía o solo con espacios");
        continue;
    }

    if (!int.TryParse(numeroString, out numero))
    {
        Console.WriteLine("No puede ingresar letras u otros simbolos");
        continue;
    }

    break;
}

if (numero > 0)
{
    while (numero != 0)
    {
        dig = numero % 10;
        invertido = invertido * 10 + dig;
        numero = numero / 10;
    }

    Console.WriteLine("El numero invertido es: " + invertido);
}
else
{
    Console.WriteLine("Debe ingresar un número positivo para obtener el invertido.");
}

//Ejercicio 2
int continuar = 1, operacion;
float num1, num2, resultado = 0;
string String_operacion, Snum1, Snum2;

while (continuar != 0)
{
    do
    {
        Console.WriteLine("\nMenú de Operaciones: ");
        Console.WriteLine("  1. Sumar | 2. Restar | 3. Multiplicar | 4. Dividir | 5. Ingresar ecuación como cadena \n");
        Console.WriteLine("Eleja una opción: ");
        String_operacion = Console.ReadLine();
        int.TryParse(String_operacion, out operacion);
    } while (operacion < 1 || operacion > 5);

    if (operacion == 5)
    {
        Console.WriteLine("\nIngrese una ecuación simple (ej: 582+2): ");
        string ecuacion = Console.ReadLine();

        // Buscar el operador y separar los números
        char[] operadores = { '+', '-', '*', '/' };
        char operadorEncontrado = ' ';
        int indice = -1;

        foreach (char op in operadores)
        {
            indice = ecuacion.IndexOf(op);
            if (indice != -1)
            {
                operadorEncontrado = op;
                break;
            }
        }

        if (indice != -1)
        {
            string parte1 = ecuacion.Substring(0, indice);
            string parte2 = ecuacion.Substring(indice + 1);

            if (float.TryParse(parte1, out num1) && float.TryParse(parte2, out num2))
            {
                switch (operadorEncontrado)
                {
                    case '+':
                        resultado = num1 + num2;
                        Console.WriteLine($"\nResultado: {num1} + {num2} = {resultado}");
                        break;
                    case '-':
                        resultado = num1 - num2;
                        Console.WriteLine($"\nResultado: {num1} - {num2} = {resultado}");
                        break;
                    case '*':
                        resultado = num1 * num2;
                        Console.WriteLine($"\nResultado: {num1} * {num2} = {resultado}");
                        break;
                    case '/':
                        if (num2 != 0)
                        {
                            resultado = num1 / num2;
                            Console.WriteLine($"\nResultado: {num1} / {num2} = {resultado}");
                        }
                        else
                        {
                            Console.WriteLine("\nNo se puede dividir por 0.");
                        }
                        break;
                }
            }
        }
        else
        {
            Console.WriteLine("No se encontró un operador válido en la ecuación.");
        }
    }
    else
    {
        do
        {
            Console.WriteLine("\nIngrese el primer numero: ");
            Snum1 = Console.ReadLine();
            Console.WriteLine("\nIngrese el segundo numero: ");
            Snum2 = Console.ReadLine();
        } while (string.IsNullOrWhiteSpace(Snum1) || string.IsNullOrWhiteSpace(Snum2) || !float.TryParse(Snum1, out num1) || !float.TryParse(Snum2, out num2));

        switch (operacion)
        {
            case 1:
                resultado = num1 + num2;
                Console.WriteLine($"\nLa suma de " + num1.ToString() + " y de " + num2.ToString() + " es igual a: " + resultado.ToString());
                break;
            case 2:
                resultado = num1 - num2;
                Console.WriteLine($"\nLa resta de " + num1.ToString() + " y de " + num2.ToString() + " es igual a: " + resultado.ToString());
                break;
            case 3:
                resultado = num1 * num2;
                Console.WriteLine($"\nLa multiplicación de " + num1.ToString() + " y de " + num2.ToString() + " es igual a: " + resultado.ToString());
                break;
            case 4:
                if (num2 != 0)
                {
                    resultado = num1 / num2;
                    Console.WriteLine($"\nLa división de " + num1.ToString() + " y de " + num2.ToString() + " es igual a: " + resultado.ToString());
                }
                else
                {
                    Console.WriteLine("\nNo se puede dividir por 0.");
                }
                break;
            default:
                Console.WriteLine("\nNo se encontró esa operación.");
                continue;
        }
    }

    Console.WriteLine("\nQuiere continuar? (SI = 1, NO = 0): ");
    int.TryParse(Console.ReadLine(), out continuar);
}

//Ejercicio 3
int Numero1, Numero2;
float Numero;
string SNumero, SNumero1, SNumero2;

do
{
    Console.WriteLine("\nIngrese un número: ");
    SNumero = Console.ReadLine();
} while (string.IsNullOrWhiteSpace(SNumero) || string.IsNullOrEmpty(SNumero) || !float.TryParse(SNumero, out Numero));

Console.WriteLine("1.Valor Absoluto: " + MathF.Abs(Numero));
Console.WriteLine("2.Cuadrado: " + MathF.Pow(Numero, 2));
if (Numero > 0)
{
    Console.WriteLine("3.Raíz Cuadrada: " + MathF.Sqrt(Numero));
} else
{
    Console.WriteLine("3.No se puede calcular la raíz cuadrada de un número negativo.");
}
Console.WriteLine("4.Seno: " + MathF.Sin(Numero));
Console.WriteLine("5.Coseno: " + MathF.Cos(Numero));
Console.WriteLine("6.Parte entera: " + MathF.Truncate(Numero));

do
    {
        Console.WriteLine("\nIngrese el primer numero entero: ");
        SNumero1 = Console.ReadLine();
        Console.WriteLine("Ingrese el segundo numero entero: ");
        SNumero2 = Console.ReadLine();
    } while (string.IsNullOrWhiteSpace(SNumero1) || string.IsNullOrWhiteSpace(SNumero2) || !int.TryParse(SNumero1, out Numero1) || !int.TryParse(SNumero2, out Numero2));


if (Numero1 != Numero2)
{
    if (Numero1 > Numero2)
    {
        Console.WriteLine("El máximo entre los dos numeros ingresados es: " + Numero1);
        Console.WriteLine("El mínimo entre los dos numeros ingresados es: " + Numero2);
    }
    else
    {
        Console.WriteLine("El máximo entre los dos numeros ingresados es: " + Numero2);
        Console.WriteLine("El minimo entre los dos numeros ingresados es: " + Numero1);
    }
} else
{
    Console.WriteLine("Los numeros ingresados son iguales.");
}

//Ejercicio 4
string cadena, cadena2, palabraBuscada, cadena3;
int longitud;
char separador = '/';

Console.WriteLine("\nIngrese una cadena: ");
cadena = Console.ReadLine();
longitud = cadena.Length;
Console.WriteLine("La longitud de la cadena ingresada es: " + longitud);

Console.WriteLine("\nIngrese la cadena 2: ");
cadena2 = Console.ReadLine();
Console.WriteLine("\nLas cadenas concatenadas: " + string.Concat(cadena, cadena2));

Console.WriteLine("\nLos elementos de la primera cadena ingresada son: ");
foreach (char letras in cadena)
{
    Console.WriteLine(letras);
}

Console.WriteLine("\nIngrese la palabra que quiere buscar en la primera cadena: ");
palabraBuscada = Console.ReadLine();
if (cadena.IndexOf(palabraBuscada) != -1)
{
    Console.WriteLine("La palabra se encuentra en la cadena.");
}
else
{
    Console.WriteLine("La palabra NO se encuentra en la cadena.");
}

Console.WriteLine("\nPrimera cadena en mayúscula: ");
Console.WriteLine(cadena.ToUpper());
Console.WriteLine("\nPrimera cadena en minúscula: ");
Console.WriteLine(cadena.ToLower());

Console.WriteLine("\nIngrese una cadena con / para ver el comportamiento del split: ");
cadena3 = Console.ReadLine();
Console.WriteLine("Subcadenas: ");
foreach (string subcadena in cadena3.Split(separador))
{
    Console.WriteLine(subcadena);
}

