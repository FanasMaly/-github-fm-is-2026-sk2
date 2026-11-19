//jednořádkový komentář


/*
toto je
více řádkový
komentář
*/

// jako první si připravíme smyčku pro opakování programu
using System.Runtime.Serialization.Formatters;

Console.Clear();
string again ="a";
//.ToLower() převede vstup na malá písmena, takže program bude pokračovat při zadávání "a" tak i "A".
while(again.ToLower() == "a")
{
    Console.WriteLine();
    Console.Clear();
    Console.WriteLine("**********************************************");
    Console.WriteLine("*********** Vykreslení obdélníku**************");
    Console.WriteLine("**********************************************");
    Console.WriteLine("************** František Malý ****************");
    Console.WriteLine("**********************************************");
    Console.WriteLine("**********************************************");

    //vstup pro šířku
        Console.Write("Zadejte šířku obrazce (kladné celé číslo):");
    int width;
    while(!int.TryParse(Console.ReadLine(), out width) || width <= 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Nezadali jste celé číslo! Zadejte šířku obrazce znovu:");
        Console.ResetColor();
    }


    //vstup pro výšku
    Console.Write("Zadejte výšku obrazce (kladné celé číslo):");
    int height;
    while(!int.TryParse(Console.ReadLine(), out height) || height <= 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Nezadali jste celé číslo! Zadejte výšku obrazce znovu:");
        Console.ResetColor();
    }


    //Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("==============================");

    //Výpis zadaných hodnot do jednoho řádku
    Console.WriteLine($"Šířka: {width}; Výška: {height};");

    Console.WriteLine("==============================");
    Console.WriteLine();


    //Jádro algoritmu

    // vnejší cyklus, který bude řídit správný počet zobrazených řádků

    for (int i =1; i <= height; i++)
    {
        if (i % 2 == 0)
        {
            //sudý
            Console.ForegroundColor = ConsoleColor.Blue;
        }
        else
        {
            //lichý
            Console.ForegroundColor = ConsoleColor.Green;
        }

        //vnitřní cyklus se stará o to aby ...
        for(int j = 1; j <= height; j++)
        {
            Console.Write("* ");
            System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100)); // Efekt animace vykreslování
        }
        Console.WriteLine();
    }

    Console.ResetColor();


     


    // Konec jádra algoritmu
 

     //dotaz směrem k uživateli na opkování
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stisknete klávesu a. Následně potvrďte klávesou Enter. ");
    Console.WriteLine("Jakoukoli jinou klávesou program ukončíte.");
    Console.WriteLine();
    Console.Write("Chcete program spustit znovu?");
    again = Console.ReadLine() ?? "";



}

