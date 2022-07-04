//SNACK 1

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
    Console.WriteLine($"Il numero maggiore è: {numA}");
}
else
{
    Console.WriteLine($"Il numero maggiore è: {numB}");
}