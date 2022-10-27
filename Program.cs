// See https://aka.ms/new-console-template for more information

// Create un progetto App Console csharp-cibi-preferiti con VS2022.
using System;

// Nel programma inizializzate un array con la classifica dei vostri cibi preferiti (minimo 5, massimo 10 elementi).
// L’array deve essere già inizializzato nel programma, e i vostri cibi preferiti non vanno chiesti all’utente tramite input.
// Una volta dichiarato l’array di cibi preferiti, stampate a video le seguenti informazioni:
// La lunghezza della classifica
//La vostra classifica (dunque stampare l’intero array in ordine indicando la posizione in classifica)
// Il vostro cibo top (prima posizione della classifica)
// Il vostro cibo preferito ma non troppo (ultima posizione della classifica)
// Le modalità di consegna sono le solite: repo GitHub, commit e push
// BONUS Stampate a video anche il cibo di mezza classifica, cioè che si trova nella posizione mediana. Attenzione: gestire anche il caso se aveste una classifica con un numero di elementi pari. In questo caso vanno stampati i 2 elementi in centro alla vostra classifica.


// Inizializzo la classifica
string[] cibiPreferiti = { "Pizza" , "Pasta" , "Parmigiana" , "Patate" , "Zucca" };

// Stampo la lunghezza della classifica
Console.WriteLine("La lunghezza della classifica è: " + cibiPreferiti.Length);

Console.WriteLine();

// Stampo la classifica
Console.WriteLine("La mia classifica è: ");
for (int i = 0; i < cibiPreferiti.Length; i++)
{
    Console.Write(i + 1 + ")");
    Console.WriteLine(cibiPreferiti[i]);
}

Console.WriteLine();

// Stampo il mio cibo preferito top
Console.WriteLine("Il mio cibo preferito top è: " + cibiPreferiti[0]);

Console.WriteLine();

// Stampo il mio cibo preferito ma non troppo
Console.WriteLine("Il mio cibo preferito ma non troppo è: " + (cibiPreferiti[cibiPreferiti.Length - 1]));

Console.WriteLine();

// Stampo il mio cibo preferito di mezza classifica
if(cibiPreferiti.Length % 2 == 0)
{
    // Pari
    // int medianaSuperiore = cibiPreferiti.Length / 2;
    // int medianaInferiore = medianaSuperiore - 1;
;
}
else
{
    // Dispari
    int mediana = cibiPreferiti.Length / 2;
    Console.WriteLine("La mediana è: " + cibiPreferiti[mediana]);
}