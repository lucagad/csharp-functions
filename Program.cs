// See https://aka.ms/new-console-template for more information


//Scrivete nel vostro programma principale Program.cs le seguenti funzioni di base:

//void StampaArray(int[] array): che preso un array di numeri interi, stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]“.

//int Quadrato(int numero): che vi restituisca il quadrato del numero passato come parametro.

//int[] ElevaArrayAlQuadrato(int[] array): che preso un array di numeri interi, restituisca un nuovo array con tutti gli elementi elevati quadrato.
//Attenzione: è importante restituire un nuovo array, e non modificare l’array come parametro della funzione! Vi ricordate perchè? Pensateci (vedi slide)

//int sommaElementiArray(int[] array): che preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array.

//Una volta completate queste funzioni di utilità di base, 
//e dato il seguente array di numeri [2, 6, 7, 5, 3, 9] già dichiarato nel vostro codice, si vogliono utilizzare le funzioni per:

//Stampare l’array di numeri fornito a video

//Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato (Verificare che l’array originale non sia stato modificato quindi ristampare nuovamente l’array originale e verificare che sia rimasto [2, 6, 7, 5, 3, 9])

//Stampare la somma di tutti i numeri

//Stampare la somma di tutti i numeri elevati al quadrati

using System;

int[] numeri = { 2, 6, 7, 5, 3, 9 };

Console.WriteLine("Quanti numeri vuoi inserire? ");
int N = Convert.ToInt32(Console.ReadLine());

int[] arrayNumeri = new int [N];

for (int i = 0; i < arrayNumeri.Length; i++)
{
    Console.WriteLine("Inserisci il {0}° numero: ", i+1);
    arrayNumeri[i] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(" ");
}



Console.WriteLine("ARRAY ORIGINALE:");
StampaArray(arrayNumeri);

Console.WriteLine("");
Console.WriteLine("ARRAY AL QUADRATO:");

StampaArray(ElevaArrayAlQuadrato(arrayNumeri));

Console.WriteLine("");
Console.WriteLine("ARRAY ORIGINALE:");
StampaArray(arrayNumeri);

Console.WriteLine("");
Console.WriteLine("SOMMA ELEMENTI ARRAY ORIGINALE:");
Console.WriteLine(sommaElementiArray(arrayNumeri));


Console.WriteLine("");
Console.WriteLine("SOMMA ELEMENTI ARRAY AL QUADRATO:");
Console.WriteLine(sommaElementiArray(ElevaArrayAlQuadrato(arrayNumeri)));




void StampaArray(int[] array)
{
	Console.Write("[");

	for (int i = 0; i < array.Length - 1; i++)
	{
		Console.Write(array[i]);
		Console.Write(",");
	}

	Console.Write(array[array.Length - 1]);
	Console.Write("]");
}


int Quadrato(int numero)
{
	return numero * numero;
}

int[] ElevaArrayAlQuadrato(int[] array)
{
	int[] arrayClone = (int[]) array.Clone();
    for (int i = 0; i < arrayClone.Length; i++)
    {
        arrayClone[i] = Quadrato(arrayClone[i]);
    }

	return arrayClone;
}

int sommaElementiArray(int[] array)
{
	int somma = 0;

    for (int i = 0; i < array.Length; i++)
    {
        somma += array[i];
    }

	return somma;
}