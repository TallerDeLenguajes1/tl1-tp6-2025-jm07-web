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
        Console.WriteLine("  1. Sumar | 2. Restar | 3. Multiplicar | 4. Dividir \n");
        Console.WriteLine("Eleja una opción: ");
        String_operacion = Console.ReadLine();
        int.TryParse(String_operacion, out operacion);
    } while (operacion < 1 || operacion > 4);

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
            Console.WriteLine($"\nResultado: {resultado}");
            break;
        case 2:
            resultado = num1 - num2;
            Console.WriteLine($"\nResultado: {resultado}");
            break;
        case 3:
            resultado = num1 * num2;
            Console.WriteLine($"\nResultado: {resultado}");
            break;
        case 4:
            if (num2 != 0)
            {
                resultado = num1 / num2;
                Console.WriteLine($"\nResultado: {resultado}");
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
