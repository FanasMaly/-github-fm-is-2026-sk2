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


    //Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("==============================");
    //Console.WriteLine($"První číslo: {first}");
    //Console.WriteLine($"Poslední číslo: {last}");
    //Console.WriteLine($"Didetence (krok): {step}");

    //Výpis zadaných hodnot do jednoho řádku
    Console.WriteLine($"První číslo: {first}; Poslední číslo: {last}; Diference (krok): {step};");

    Console.WriteLine("==============================");
    Console.WriteLine();


    //Jádro algoritmu pro výpis řady
     Console.WriteLine("Výpis číselné řady: ");

    if(first <= last)
    {
       int current = first;
        while(current <= last) {
            Console.WriteLine(current);
            //current = current + step;
            // předchozí řádek lze napsat stručněji
            current += step;
        }

    }
    else
    {
        Console.WriteLine("Řadu nelze vypsat!");
        Console.WriteLine("První číslo je větší než poslední.");
        Console.WriteLine("Tento program umí vypsat pouze vzestupnou řadu (od menšího k vetšímu)");
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

