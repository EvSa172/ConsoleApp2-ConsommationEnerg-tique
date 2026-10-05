using System.Runtime.CompilerServices;

namespace ConsoleApp2_ConsommationEnergétique
{
    internal class Program
    {
        static void Main(string[] args)

        {
            decimal ConsoActuelle = 100m;
            decimal ConsoDouble = ConsoActuelle * 2;
           
            int année = 0;

            while (ConsoActuelle < ConsoDouble )
            {
                ConsoActuelle *= 1.08m;
                année++;
            }

            Console.WriteLine($"Le nombre d'années pour arriver au doublement de la conso est de {année} années");
        }
    }
}
