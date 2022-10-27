// See https://aka.ms/new-console-template for more information


// Inizializzo la classifica
string[] cibiPreferiti = { "Pizza" , "Pasta" , "Parmigiana" , "Patate" , "Zucca" };

// Stampo la lunghezza della classifica
Console.WriteLine("La lunghezza della classifica è: " + cibiPreferiti.Length);

// Stampo la classifica
for(int i = 0; i < cibiPreferiti.Length; i++)
{
    Console.WriteLine(cibiPreferiti[i]);
}

// Stampo il mio cibo preferito top
Console.WriteLine("Il mio cibo preferito top è: " + cibiPreferiti[0]);

// Stampo il mio cibo preferito ma non troppo
Console.WriteLine("Il mio cibo preferito ma non troppo è: " + cibiPreferiti[4]);

// Stampo il mio cibo preferito di mezza classifica
Console.WriteLine("Il mio cibo preferito di mezza classifica è: " + cibiPreferiti[2]);