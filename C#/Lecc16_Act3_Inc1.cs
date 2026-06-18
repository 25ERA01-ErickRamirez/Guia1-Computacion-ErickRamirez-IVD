internal class Program
{
    private static void Main(string[] args)
    {
        int indice = 0;
        int comparador = 0;
        bool existeRepetido = false;
        int[] numerosEnteros = new int[16];

        existeRepetido = false;

        for (indice = 1; indice <= 15; indice++)
        {
            Console.Write("Ingrese el número " + indice + ": ");
            numerosEnteros[indice] = int.Parse(Console.ReadLine());
        }

        for (indice = 1; indice <= 14; indice++)
        {
            for (comparador = indice + 1; comparador <= 15; comparador++)
            {
                if (numerosEnteros[indice] == numerosEnteros[comparador])
                {
                    existeRepetido = true;
                }
            }
        }

        if (existeRepetido)
        {
            Console.WriteLine("Sí existe al menos un número repetido.");
        }
        else
        {
            Console.WriteLine("No existe ningún número repetido.");
        }

        Console.ReadKey();
    }
}