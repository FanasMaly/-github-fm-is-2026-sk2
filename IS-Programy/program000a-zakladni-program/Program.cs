//jednořádkový komentář


/*
toto je
více řádkový
komentář
*/

// jako první si připravíme smyčku pro opakování programu
Console.Clear();
string again ="a";
//.ToLower() převede vstup na malá písmena, takže program bude pokračovat při zadávání "a" tak i "A".
while(again.ToLower() == "a")
{
    Console.WriteLine();
    Console.Clear();
    Console.WriteLine("**********************************************");
    Console.WriteLine("**************** Název programu ******************");
    Console.WriteLine("**********************************************");
    Console.WriteLine("************** František Malý ****************");
    Console.WriteLine("**********************************************");
    Console.WriteLine("**********************************************");

    //vstup první hodnoty
    Console.Write("Zadejte první hodnotu:");
    int aaa;
    while(!int.TryParse(Console.ReadLine(), out aaa))
    {
        Console.Write("Nezadali jste celé číslo! Zadejte první hodnotu znovu:");
    }


    //vstup další hodnoty
    Console.Write("Zadejte další hodnotu:");
    int bbb;
    while(!int.TryParse(Console.ReadLine(), out bbb))
    {
        Console.Write("Nezadali jste celé číslo! Zadejte další hodnotu znovu:");
    }


    //Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("==============================");

    //Výpis zadaných hodnot do jednoho řádku
    Console.WriteLine($"První číslo: {aaa}; Poslední číslo: {bbb};");

    Console.WriteLine("==============================");
    Console.WriteLine();


    //Jádro algoritmu

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

