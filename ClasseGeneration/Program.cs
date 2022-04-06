int alunniAttuali = 0;
int numeroPostiAlunni = 10;

string[] nomeAlunni = new string[numeroPostiAlunni];
string[] cognomeAlunni = new string[numeroPostiAlunni];
int[] etaAlunni = new int[numeroPostiAlunni];


    void stampaAlunni(string[] array)
    {

        int ultimoIndiceArray = array.Length - 1;
        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            if (i == ultimoIndiceArray)
            {
                Console.Write(array[i]);
            }
            else
            {
                Console.Write(array[i] + ", ");
            }
        }
        Console.WriteLine("]");
    }




void stampaEta(int[] array)
{

    int ultimoIndiceArray = array.Length - 1;
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == ultimoIndiceArray)
        {
            Console.Write(array[i]);
        }
        else
        {
            Console.Write(array[i] + ", ");
        }
    }
    Console.WriteLine("]");
}


void aggiungiAlunno(string nome, string cognome, int eta)
    {
        if (alunniAttuali < numeroPostiAlunni)
        {

            nomeAlunni[alunniAttuali] = nome;
            cognomeAlunni[alunniAttuali] = cognome;
            etaAlunni[alunniAttuali] = eta;
            alunniAttuali++;

        }
        else
        {
            Console.WriteLine("Mi dispiace non ci sono più posti");
        }
    }





    void rimuoviAlunno()
    {
        if (alunniAttuali > 0)
        {
            alunniAttuali--;
            nomeAlunni[alunniAttuali] = "";
            cognomeAlunni[alunniAttuali] = "";
            etaAlunni[alunniAttuali] = 0;
        }
        else
        {
            Console.WriteLine("Mi dispiace non ci sono più alunni!");
        }
    }


//una funzione calcolaEtaMediaClasse che vi restituisca l'età media della classe.


void CalcolaEtaMediaClasse(int[] array)
{
    int media = 0;
    int somma = 0;
    for(int i = 0; i < array.Length; i++)
    {
        somma += array[i];
    }

    media = somma / alunniAttuali;
    Console.WriteLine(media);
    

}

//una funzione EtaPiuGiovane che vi restituisce l'età dell'alunno più giovane in classe.

void alunnoPiuGiovane(int[] array)
{
    int etaPiugiovane = array[0];
    for( int i = 1; i < array.Length; i++)
    {
        if (array[i] < etaPiugiovane && array[i]!=0)
        {
            etaPiugiovane = array[i];
        }

        else if (array[i] == 0)
        {
            break;
        }
    }

    Console.WriteLine(etaPiugiovane + " anni");
}


//una funzione EtàPiuVecchio che vi restituisce l'età dell'alunno più vecchio.

void alunnoPiuVecchio(int[] array)
{
    int etaPiuVecchio = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > etaPiuVecchio)
        {
            etaPiuVecchio = array[i];
        }

        
    }

    Console.WriteLine(etaPiuVecchio + " anni");
}
















// ------------- PROGRAMMA PRINCIPALE -------------
Console.WriteLine("Il numero attuale di alunni è: " + alunniAttuali);


while (true)
{
    Console.Write("Vuoi aggiungere o rimuovere un alunno [aggiungi/rimuovi/alunni/statistiche]? ");
    string risposta = Console.ReadLine();

    switch (risposta)
    {
        case "aggiungi":
            Console.WriteLine("Dimmi il nome dell'alunno: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Dimmi il cognome dell'alunno: ");
            string cognome = Console.ReadLine();
            Console.WriteLine("Dimmi l'eta dell'alunno: ");
            int eta = int.Parse(Console.ReadLine());
            aggiungiAlunno(nome, cognome, eta);
            Console.WriteLine("Il numero attuale di alunni è: " + alunniAttuali);
            break;
        case "rimuovi":
            rimuoviAlunno();
            Console.WriteLine("Il numero attuale di alunni è: " + alunniAttuali);
            break;
        case "alunni":
            Console.Write("I nomi degli alunni sono: ");
            stampaAlunni(nomeAlunni);
            Console.Write("I cognomi degli alunni sono: ");
            stampaAlunni(cognomeAlunni);
            Console.Write("l'eta degli alunni è: ");
            stampaEta(etaAlunni);
            break;
        case "statistiche":
            Console.Write("L'eta media della classe è: ");
            CalcolaEtaMediaClasse(etaAlunni);
            Console.Write("L'alunno più giovane ha : ");
            alunnoPiuGiovane(etaAlunni);
            Console.Write("L'alunno più vecchio ha : ");
            alunnoPiuVecchio(etaAlunni);


            break;



        default:
            Console.WriteLine("Mi dispiace non è un opzione tra quelle che puoi usare ");
            break;
    }

}



