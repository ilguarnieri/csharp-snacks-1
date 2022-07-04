//---------- SNACK 1 ----------
//L’utente inserisce due numeri in successione.
//Il software stampa il maggiore.

int numA;
int numB;

Console.WriteLine("Inserisci un numero intero");
numA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Inserisci un'altro numero intero");
numB = Convert.ToInt32(Console.ReadLine());

if(numA > numB)
{
    Console.WriteLine($"\nIl numero più grande è: {numA}");
}
else
{
    Console.WriteLine($"\nIl numero più grande è: {numB}");
}


//---------- SNACK 2 ----------
//L’utente inserisce due parole in successione.
//Il software stampa prima la parola più corta, poi la parola più lunga.

string primaParola;
string secondaParola;

Console.WriteLine("\n\nInserisci una parola");
primaParola = Console.ReadLine();

Console.WriteLine("Inserisci un'altra parola");
secondaParola = Console.ReadLine();

if (primaParola.Length > secondaParola.Length)
{
    Console.WriteLine($"\n{secondaParola}");
    Console.WriteLine($"{primaParola}");
}
else
{
    Console.WriteLine($"\n{primaParola}");
    Console.WriteLine($"{secondaParola}");
}


//---------- SNACK 3 ----------