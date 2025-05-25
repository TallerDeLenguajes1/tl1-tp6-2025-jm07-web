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
} else
{
    Console.WriteLine("Debe ingresar un número positivo para obtener el invertido.");
}

