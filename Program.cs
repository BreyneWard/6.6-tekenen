using static System.Console;
namespace _6._6_tekenen;
class Program
{   
    public const string STYLE = "*"; //Other styles: "-", "<"
    static void Main(string[] args)
    {   
        Console.WriteLine("Geef de lengte op: ");
        int lengte = int.Parse(Console.ReadLine());
        Console.WriteLine("Geef de breedte op: ");
        int breedte = int.Parse(Console.ReadLine());
        
        printLengte(lengte);
        printBreedte(breedte, lengte);
        printLengte(lengte);
        
    }

    // Lengte printen
    static void printLengte(int lengte)
    {
        for(int i=0; i<lengte; i++)
        {

        Console.Write(STYLE);

        }
        Console.WriteLine();
    }

    // Breedte printen
    static void printBreedte(int breedte, int lengte)
    {   
        for(int i= 0; i < (breedte -2); i++)
        {
            
            Console.Write("{0}{1}", STYLE,STYLE.PadLeft(lengte-1));
            Console.WriteLine();

        }
    }
    

    
}
