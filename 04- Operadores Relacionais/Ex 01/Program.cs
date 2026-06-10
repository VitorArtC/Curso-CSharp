public class Program
{
    public static void Main()
    {
        Console.WriteLine("-=-=-=- Console -=-=-=-");
        Console.WriteLine("Digite o 1o número: ");
        int n1 = Convert.ToInt32(Console.ReadLine());  

        Console.WriteLine("Digite o 2o número: ");
        int n2 = Convert.ToInt32(Console.ReadLine());

        bool condition = n1 == n2;

        //Operador que compara Igualdade (==)

        if (condition == true)
        {
            Console.WriteLine("Números são iguais.");
        } else {
            Console.WriteLine("Números são diferentes.");
        }


        
        condition = n1 != n2;

        //Operador que compara Diferença (!=)

        if (condition == true)
        {
            Console.WriteLine("Números são Diferentes.");
        } else {
            Console.WriteLine("Números são Iguais.");
        }


         condition = n1 >= n2;

        //Operador que retorna true caso x >= y (>)

        if (condition == true)
        {
            Console.WriteLine(n1+" é maior ou igual que "+n2);
        } else {
            Console.WriteLine(n1+" é menor que "+n2);
        }


        condition = n1 <= n2;

        //Operador que retorna true caso n1 <= n2 (<=)

        if (condition == true)
        {
            Console.WriteLine(n1+" é menor ou igual que "+n2);
        } else {
            Console.WriteLine(n1+" é maior que "+n2);
        }



    }
}