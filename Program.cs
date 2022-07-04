//---------- SNACK 12 ----------
//Scrivere una funzione per verificare se un numero è pari o dispari.
//Quindi chiedere un numero all'utente e comunicargli se è pari o dispari.
{
    Console.WriteLine("*** SNACK 12 *** ");

    void CheckNumber(int number)
    {
        if(number % 2 == 0)
        {
            Console.WriteLine($"\nIl numero {number} è pari");
        }
        else
        {
            Console.WriteLine($"\nIl numero {number} è dispari");
        }
    }

    int n;

    Console.WriteLine("Inserisci un numero intero");
    n= Convert.ToInt32(Console.ReadLine());
    CheckNumber(n);
}



//---------- SNACK 11 ----------
//Dare la possibilità di inserire due parole.
//Verificare tramite una funzione che le due parole abbiano la stessa
//lunghezza. Se hanno la stessa lunghezza, stamparle entrambe,
//altrimenti stampare la più lunga delle due.
{
    Console.WriteLine("\n\n*** SNACK 11 *** ");

    string GetWord()
    {
        Console.WriteLine("Scrivi una parola");
        string word = Console.ReadLine();

        return word;
    }

    void WordComparison(string word1, string word2)
    {
        if (word1.Length == word2.Length)
        {
            Console.WriteLine($"\n{word1}");
            Console.WriteLine(word2);
        } 
        else if (word1.Length < word2.Length)
        {
            Console.WriteLine($"\n{word2}");
        }
        else
        {
            Console.WriteLine($"\n{word1}");
        }
    }

    WordComparison(GetWord(), GetWord());
}



//---------- SNACK 10 ----------
//Fai inserire un numero, che chiameremo N, all’utente.
//Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100.
//Ogni volta che ne crei uno, stampalo a schermo.
{
    Console.WriteLine("\n\n*** SNACK 10 *** ");
    int n;

    Console.WriteLine("Inserisci un numero");
    n = Convert.ToInt32(Console.ReadLine());

    for(int i = 0; i < n; i++)
    {
        Console.Write($"\nArray {i+1} [");
        int[] array = new int[10];

        for(int j = 0; j < array.Length; j++)
        {
            array[j] = new Random().Next(1, 101);
            Console.Write($" {array[j]} ");
        }
        Console.Write("]");
    }
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

    Console.WriteLine("Scrivi una parola");
    primaParola = Console.ReadLine();

    Console.WriteLine("Scrivi un'altra parola");
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