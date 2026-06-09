public class Program
{
    public static void Main()
    {
        Console.WriteLine("-=-=-=- Console -=-=-=-");
        Console.WriteLine("Digite o 1o número: ");
        int n1 = Convert.ToInt32(Console.ReadLine());  

        Console.WriteLine("Digite o 2o número: ");
        int n2 = Convert.ToInt32(Console.ReadLine());

        int nMed = (n1 + n2) / 2;

        if (nMed >= 60)
        {
            Console.WriteLine("Parabéns, você passou na matéria com média: "+ nMed);
        } else
        {
            Console.WriteLine("Você reprovou :( com média: "+ nMed);
        }   

        
    }
}