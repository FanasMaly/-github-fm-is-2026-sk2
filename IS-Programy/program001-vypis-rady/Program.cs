//jednořádkový komentář


/*
toto je
více řádkový
komentář
*/

// jako první si připravíme smyčku pro opakování programu
Console.Clear();
string again ="a";
//.ToLower() převede vstup na malá písmena, takže program bude pokračovat při zadávání "a".
while(again.ToLower() == "a")
{
    Console.WriteLine();
    Console.Clear();
    Console.WriteLine("**********************************************");
    Console.WriteLine("**************** Výpis řady ******************");
    Console.WriteLine("**********************************************");
    Console.WriteLine("************** František Malý ****************");
    Console.WriteLine("**********************************************");
    Console.WriteLine("**********************************************");

    //vstup počáteční hodnoty - špatně řešený
    //Console.Write("Zadejte první číslo řady:");
    //int first = int.Parse(Console.ReadLine());

    //vstup počáteční hodnoty - správně řešený
    Console.Write("Zadejte první celé číslo řady:");
    int first;
    while(!int.TryParse(Console.ReadLine(), out first))
    {
        Console.Write("Nezadali jste celé číslo! Zadejte první celé číslo řady znovu:");
    }


    //vstup koncové hodnoty - správně řešený
    Console.Write("Zadejte poslední celé číslo řady:");
    int last;
    while(!int.TryParse(Console.ReadLine(), out last))
    {
        Console.Write("Nezadali jste celé číslo! Zadejte poslední celé číslo řady znovu:");
    }

    //Vstup diference s kontrolou kladné hodnoty
    Console.Write("Zadejte diferenci (Kladné celé číslo):");
    int step;
    while(!int.TryParse(Console.ReadLine(), out step) || step <=0 )
    {
        Console.Write("Diference musí být kladné celé číslo, zadejte diferenci znovu:");
    }



     //dotaz směrem k uživateli na opkování
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stisknete klávesu a. Následně potvrďte klávesou Enter. ");
    Console.WriteLine("Jakoukoli jinou klávesou program ukončíte.");
    Console.WriteLine();
    Console.Write("Chcete program spustit znovu?");
    again = Console.ReadLine() ?? "";



}

