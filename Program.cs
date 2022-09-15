// See https://aka.ms/new-console-template for more information

// Definizione ed Inizializzazione dell'array "myFoods"
string[] myFoods = { "Lasagne", "Carbonara", "Cotoletta", "Patate fritte", "Hamburger", "Sushi", "Cornetto salato" };

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

//Stampa dell'elemento nella posizione mediana
if (myFoods.Length % 2 == 1)
{
    int middleIndex = myFoods.Length - 1;
    middleIndex = middleIndex / 2;
    Console.WriteLine(myFoods[middleIndex]);
} else
{
    int firstIndex;
    firstIndex = myFoods.Length - 1;
    firstIndex = firstIndex / 2;
    int secondIndex = firstIndex + 1;
    Console.WriteLine(myFoods[firstIndex]);
    Console.WriteLine(myFoods[secondIndex]);
}