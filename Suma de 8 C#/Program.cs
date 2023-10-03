// See https://aka.ms/new-console-template for more information
namespace Practica_01
{
    class Program
    {
        const int NUM = 8;
        static void Main()
        {
            int[] nums = new int[NUM];
            int total = 0;
            for (int i = 0; i < NUM; i++)
            {
                Console.Write("Por favor, introduzca el numero: ");
                nums[i] = int.Parse(Console.ReadLine());
                total += nums[i];

            }
            Console.WriteLine("El total de numero es: " + total);
            Console.ReadKey();
        }
    }
}
