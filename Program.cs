// See https://aka.ms/new-console-template for more information

// Definizione ed Inizializzazione dell'array "myFoods"
string[] myFoods = { "Lasagne", "Carbonara", "Cotoletta", "Patate fritte", "Hamburger", "Sushi", "Cornetto salato", "Barbabietola" };

//Calcolo e stampa della lunghezza dell'array
Console.WriteLine(myFoods.Length);

//Stampa della classifica in ordine
for(int i = 0; i < myFoods.Length; i++)
{
    Console.WriteLine(myFoods[i]);
}

//Stampa del primo elemento in classica (nell'array)
Console.WriteLine(myFoods[0]);

//Stampa dell'ultimo elemento in classifica (nell'array)
Console.WriteLine(myFoods[myFoods.Length - 1]);