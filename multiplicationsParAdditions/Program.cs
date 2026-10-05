namespace multiplicationsParAdditions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Entrez un premier nombre:");
        int a = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Entrez un deuxieme nombre : ");
        int b = int.Parse(Console.ReadLine());

        int compteur = 0, resultat = 0;
        
        while (compteur < b)
        {
            resultat = resultat + a;
            compteur++;
            }
        Console.WriteLine($"Le résultat est : {resultat}");
    }
}