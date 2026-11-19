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
    Console.WriteLine("****** Generátor pseudonáhodných čísel *******");
    Console.WriteLine("**********************************************");
    Console.WriteLine("************** František Malý ****************");
    Console.WriteLine("**********************************************");
    Console.WriteLine("**********************************************");

    //vstup pro počet generovaných čísel
    Console.Write("Zadejte počet generovaných:");
    int n;
    while(!int.TryParse(Console.ReadLine(), out n) || n <= 0)
    {
        Console.Write("Nezadali jste kladné celé číslo! Zadejte počet čísel znovu:");
    }


    //vstup pro dolní mez
    Console.Write("Zadejte dolní mez:");
    int lowerBound;
    while(!int.TryParse(Console.ReadLine(), out lowerBound))
    {
        Console.Write("Nezadali jste celé číslo! Zadejte dolní mez znovu:");
    }


    //vstup pro horní mez
    Console.Write("Zadejte horní mez, vetší nebo rovno hodnotě pro dolni mez:");
    int upperBound;
    while(!int.TryParse(Console.ReadLine(), out upperBound) || upperBound < lowerBound)
    {
        Console.Write("Nezadali jste celé číslo nebo je horní mez menší než dolní mez! Zadejte horní mez znovu:");
    }

    //Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("==============================");

    //Výpis zadaných hodnot do jednoho řádku
    Console.WriteLine($"Počet vygenerovaných čísel: {n}; Dolní mez: {lowerBound}; Horní mez: {upperBound};");

    Console.WriteLine("==============================");
    Console.WriteLine();


    //Jádro algoritmu


    // deklarace pole a alokace v paměti
    int[] myRandNumbs = new int[n];

    // inicializace generátoru náhodných čísel
    Random myRandNumb = new Random();
    // Random myRandNumb = new Random(50); // pevný seed pro testovací účely (vždy stejná čísla)

    for(int i = 0; i < myRandNumbs.Length ; i++)
    {
        // generování i-tého náhodného čísla
        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound+1);
        Console.Write($"{myRandNumbs[i]}; ");
    }






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

