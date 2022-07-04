//---------- SNACK 6 ----------
{
    Console.WriteLine("\n\n*** SNACK 6 *** ");
}



//---------- SNACK 6 ----------
{
    Console.WriteLine("\n\n*** SNACK 6 *** ");
}



//---------- SNACK 5 ----------
//Il software chiede all’utente di inserire un numero. Se il numero inserito
//è pari, stampa il numero, se è dispari, stampa il numero successivo.
{
    Console.WriteLine("\n\n*** SNACK 5 *** ");
    int num;

    Console.WriteLine("Inserisci un numero intero");
    num = Convert.ToInt32(Console.ReadLine());

    if(num % 2 == 0)
    {
        Console.WriteLine("Il numero inserito è pari");
    }
    else
    {
        Console.WriteLine("Il numero inserito è dispari");
    }
}



//---------- SNACK 4 ----------
//Calcola la somma e la media dei numeri da 2 a 10.
{
    Console.WriteLine("\n\n*** SNACK 4 *** ");
    int min = 2;
    int max = 10;

    float average;
    int sum = 0;

    for(int i = min; i <= max; i++)
    {
        sum += i;
    }

    average = (float)sum / (max - min + 1);

    Console.WriteLine($"Numeri da {min} a {max}");
    Console.WriteLine($"\nLa loro somma è: {sum}");
    Console.WriteLine($"La loro media è: {average}");
}



//---------- SNACK 3 ----------
//Il software deve chiedere per 10 volte all’utente di inserire un numero.
//Il programma stampa la somma di tutti i numeri inseriti.
{
    Console.WriteLine("\n\n*** SNACK 3 *** ");
    int[] numbers = new int[10];
    int sum = 0;


    for(int i = 0; i < numbers.Length; i++)
    {
        Console.WriteLine($"Inserisci il {i+1}º numero");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
        sum += numbers[i];
    }

    Console.WriteLine($"\nLa somma di tutti i numeri inseriti è {sum}");
}



//---------- SNACK 2 ----------
//L’utente inserisce due parole in successione.
//Il software stampa prima la parola più corta, poi la parola più lunga.

{
    Console.WriteLine("\n\n*** SNACK 2 *** ");
    string primaParola;
    string secondaParola;

    Console.WriteLine("Inserisci una parola");
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
}




//---------- SNACK 1 ----------
//L’utente inserisce due numeri in successione.
//Il software stampa il maggiore.
{
    Console.WriteLine("\n\n*** SNACK 1 *** ");
    int numA;
    int numB;

    Console.WriteLine("Inserisci un numero intero");
    numA = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Inserisci un altro numero intero");
    numB = Convert.ToInt32(Console.ReadLine());

    if(numA > numB)
    {
        Console.WriteLine($"\nIl numero più grande è: {numA}");
    }
    else
    {
        Console.WriteLine($"\nIl numero più grande è: {numB}");
    }
}