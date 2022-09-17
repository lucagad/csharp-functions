﻿// See https://aka.ms/new-console-template for more information


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

int[] numeri = { 2, 6, 7, 5, 3, 9 };

StampaArray(numeri);

StampaArray(ElevaArrayAlQuadrato(numeri));



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
    for (int i = 0; i < array.Length; i++)
    {
		array[i] = Quadrato(array[i]);
    }

	return array;
}