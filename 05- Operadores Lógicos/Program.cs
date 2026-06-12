public class Program
{
    public static void Main()
    {
        Console.WriteLine("-=-=-=-=-= CONSOLE -=-=-=-=-=");

        bool isLogged = true;
        bool hasAdminAccess = true;
        string acessStatus;
    
        if (hasAdminAccess == true)
        {
            acessStatus = "Liberado";
        } else
        {
            acessStatus = "Negado";
        }

        Console.WriteLine("\nInformações do Usuário:");
        Console.WriteLine("Usuário logado: " + isLogged);
        Console.WriteLine("Acesso ao painel de admin: " + acessStatus);
    }
}