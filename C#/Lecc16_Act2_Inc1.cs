internal class Program
{
    private static void Main(string[] args)
    {
        int indice = 0;
        int cantidadMayoresEdad = 0;
        int[] edadesPersonas = new int[8];

        cantidadMayoresEdad = 0;

        for (indice = 1; indice <= 7; indice++)
        {
            Console.Write("Ingrese la edad de la persona " + indice + ": ");
            edadesPersonas[indice] = int.Parse(Console.ReadLine());

            if (edadesPersonas[indice] >= 18)
            {
                cantidadMayoresEdad = cantidadMayoresEdad + 1;
            }
        }

        Console.WriteLine("Cantidad de personas mayores de edad: " + cantidadMayoresEdad);

        Console.ReadKey();
    }
}