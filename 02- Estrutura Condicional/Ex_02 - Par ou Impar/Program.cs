public class Program
{
    public static void Main()
    {
        Console.WriteLine("-=-=-=-=- CONSOLE -=-=-=-=-");
        Console.WriteLine("Digite um número: ");
        
        int num = Convert.ToInt32(Console.ReadLine());
        int resto = num % 2;

        if (resto == 1)
        {
            Console.WriteLine("O número é impar");
        } else {
            Console.WriteLine("O número é par");
        }
        
    }
}
