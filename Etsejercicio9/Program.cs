using System;

public class Operaciones
{
    public static int Sumar(int a, int b)
    {
        return a + b;
    }
    public static int Multiplicar(int a, int b)
    {
        return a * b;
    }
    public static int Dividir(int a, int b)
    {
        if (b == 0)
        {
            throw new ArgumentException("No se puede dividir por cero.");
        }
        return a / b;
    }
    public static int Restar(int a, int b)
    {
        return a - b;
    }

}

public class Menu
{
    public void MostrarMenu()
    {
        Console.WriteLine("Seleccione una operación");
        Console.WriteLine("1. Sumar");
        Console.WriteLine("2. Restar");
        Console.WriteLine("3. Multiplicar");
        Console.WriteLine("4. Dividir");
        Console.WriteLine("Ingrese su elección: ");
        int opcion = int.Parse(Console.ReadLine());

        Console.WriteLine("INGRESE EL PRIMER NÚMERO: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("INGRESE EL SEGUNDO NÚMERO: ");
        int num2 = int.Parse(Console.ReadLine());
        if (opcion==4 && num2 == 0)
        {
            Console.WriteLine("No se puede dividir un número entre 0");
        }

        switch (opcion)

        {
            case 1:
                int resultado1 = Operaciones.Sumar(num1, num2);
                Console.WriteLine($"La suma de {num1} y {num2} es " + resultado1);
                break;
            case 2:
                int resultado2 = Operaciones.Restar(num1, num2);
                Console.WriteLine($"La resta de {num1} y {num2} es " + resultado2);
                break;
            case 3:
                int resultado3 = Operaciones.Multiplicar(num1, num2);
                Console.WriteLine($"La multiplicación de {num1} y {num2} es " + resultado3);
                break;
            case 4:
                 int resultado4 = Operaciones.Dividir(num1, num2);
                 Console.WriteLine($"La división de {num1} y {num2} es " + resultado4);
                break;
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        menu.MostrarMenu();
    }
}
