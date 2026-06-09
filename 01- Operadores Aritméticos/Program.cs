public class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite o numero 1: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o numero 2: ");
        int n2 = Convert.ToInt32(Console.ReadLine());

        int nSum = n1 + n2; 
        string Result = "Sua soma é igual à: ";

        Console.WriteLine(Result + nSum);    
    }
}
