public class Program
{
    public static void Main()
    {
        //valor inicial
        int x = 10;
        Console.WriteLine("-=-=-=-= CONSOLE DO ATRIBUIDOR -=-=-=-=");
        Console.WriteLine("\nValor inicial de x é: "+x);
        
        //atribuição simples
        x = 20;
        Console.WriteLine("Valor de atribuição simples de x é: "+x);
        
        //atribuição composta -- increment;
        x++;
        Console.WriteLine("Valor de atribuição composta de x é: "+x);

        //atribuição composta -- realizar operações ligadas à variável;
        x += 20;
        Console.WriteLine("Valor de atribuição composta de x é: "+x);



    }
}