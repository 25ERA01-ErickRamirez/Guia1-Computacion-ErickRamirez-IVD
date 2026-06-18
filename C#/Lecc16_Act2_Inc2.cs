internal class Program
{
    private static void Main(string[] args)
    {
        int indice = 0;
        int numeroMayor = 0;
        int posicionMayor = 0;
        int[] numerosEnteros = new int[9];

        for (indice = 1; indice <= 8; indice++)
        {
            Console.Write("Ingrese el número " + indice + ": ");
            numerosEnteros[indice] = int.Parse(Console.ReadLine());

            if (indice == 1)
            {
                numeroMayor = numerosEnteros[indice];
                posicionMayor = indice;
            }
            else
            {
                if (numerosEnteros[indice] > numeroMayor)
                {
                    numeroMayor = numerosEnteros[indice];
                    posicionMayor = indice;
                }
            }
        }

        Console.WriteLine("El número mayor es: " + numeroMayor);
        Console.WriteLine("Se encuentra en la posición: " + posicionMayor);

        Console.ReadKey();
    }
}