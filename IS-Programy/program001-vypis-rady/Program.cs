//jednořádkový komentář


/*
toto je
více řádkový
komentář
*/

// jako první si připravíme smyčku pro opakování programu

string again ="a";
//.ToLower() převede vstup na malá písmena, takže program bude pokračovat při zadávání "a".
while(again.ToLower() == "a")
{
    Console.Clear();
    Console.WriteLine("**********************************************");
    Console.WriteLine("**************** Výpis řady ******************");
    Console.WriteLine("**********************************************");
    Console.WriteLine("************** František Malý ****************");
    Console.WriteLine("**********************************************");
    Console.WriteLine("**********************************************");



     //dotaz směrem k uživateli na opkování
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stisknete klávesu a. Následně potvrďte klávesou Enter. ");
    Console.WriteLine("Jakoukoli jinou klávesou program ukončíte.");
    Console.WriteLine();
    Console.WriteLine("Chcete program spustit znovu?");
    again = Console.ReadLine() ?? "";



}

