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
    Console.WriteLine("**************** Ciferný součet **************");
    Console.WriteLine("**********************************************");
    Console.WriteLine("************** František Malý ****************");
    Console.WriteLine("**********************************************");
    Console.WriteLine("**********************************************");

    //vstup celého čísla
    Console.Write("Zadejte celé číslo:");
    int number;
    while(!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write("Nezadali jste celé číslo! Zadejte celé číslo znovu:");
    }




    //Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("==============================");

    //Výpis zadaných hodnot do jednoho řádku
    Console.WriteLine($"První číslo: {number}; ");

    Console.WriteLine("==============================");
    Console.WriteLine();


    //Jádro algoritmu

    // 1. příprava pomocných promenných pro výpočet
    int numberBackup = number;  // záloha původního čísla pro závěrečný výpis
    int sum = 0;                // neutrální hodnotou pro sčítání je 0
    int digit;                  // proměnná pro uložení právě zpracovávané číslice

    // 2. ošetrění záporných čísel, znaménko nemá vliv na součet čísel
    if(number < 0)
    {
        number = -number;
    }

    // 3. zvláštní případ
    if(number == 0)
    {
        sum = 0;
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Průběh rozkladu čísla na jednotlivé číslice (z prava do leva)");
        // 4. jádro problému - matematický rozklad čísla pomoci cyklu
        while (number > 0)
        {
            // operátoru % se říká MODULO (slouží k určení zbytku po celočíselném děleni)
            digit = number % 10;    // MODULO 10 nám získá poslední číslici
            sum = sum + digit;      // přičtení číslice k celkovému součtu
            number = number / 10;   // celočíselné dělení 10kou odstaní poslední číslici

            Console.WriteLine($" Aktuální číslice (zbytek): {digit}");
            Console.WriteLine($" Číslo po odříznutí aktuálni číslice: {number}");
            Console.WriteLine($" Aktuální hodnota ciferného součtu: {sum}");
        }
    }

    // 5. výpis výsledku
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("================================");
    Console.WriteLine($" Ciferný součet čísla {numberBackup} je {sum}");
    Console.WriteLine("================================");
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();


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

