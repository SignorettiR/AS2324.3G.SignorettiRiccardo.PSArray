using System;
namespace as2324._3g.Signoretti.Riccardo.Verifica;
class Program
{
    static void Main(string[] args)
    {


        Console.WriteLine("Inserisci il numero di voti:");
        int nVoti = Convert.ToInt32(Console.ReadLine());

        double[] voti = new double[nVoti];
        int[] pesi = new int[nVoti];

        CaricaVettori(ref voti, ref pesi, nVoti);
        StampaVotiPesi(voti, pesi, nVoti);
        StampaVotiDispariMaggiori4(ref voti, ref pesi, nVoti);

        double max = 0, min = 10; 
        int posmax = 0, posmin = 0;
        double media = MediaPonderata(voti, pesi, nVoti, ref max, ref posmax, ref min, ref posmin);
        Console.WriteLine($"\nMedia Ponderata: {media}");  
        Console.WriteLine($"Voto massimo: {max} - Posizione: {posmax}");
        Console.WriteLine($"Voto minimo: {min} - Posizione: {posmin}");
        Console.WriteLine("Inserisci un voto:");
        double voto = Convert.ToDouble(Console.ReadLine());
        ElencoVotiNellIntorno(voti, pesi, nVoti, voto); 
        Console.ReadLine();

    }

    static void StampaVotiPesi(double[] voti, int[] pesi, int nVoti)
    {
        Console.WriteLine("Voti e Pesi:");
        for (int i = 0; i < nVoti; i++)
        {
            Console.WriteLine($"Voto: {voti[i]} - Peso: {pesi[i]}");
        }
    }

    static void CaricaVettori(ref double[] voti, ref int[] pesi, int nVoti)
    {
        Random rnd = new Random();
        for (int i = 0; i < nVoti; i++)
        {
            voti[i] = rnd.Next(1, 11); //si mette 11 e non 10 perche il random non considera l'ultimo numero (non è compreso)
            pesi[i] = rnd.Next(0, 101);
        }
    }
    static void StampaVotiDispariMaggiori4(ref double[] voti, ref int[] pesi, int nVoti)
    {
        Console.WriteLine("\nVoti maggiori di 4 in posizione dispari: ");
        for (int i = 0; i < nVoti; i++)
        {
            if (voti[i] > 4 && i % 2 == 0) // si verifica se il voto in posizione i è maggiore di 4 e se la posizione è dispari
            {
                Console.WriteLine($"Voto: {voti[i]} - Peso: {pesi[i]}");
            }
        }
    }
    static double MediaPonderata(double[] voti, int[] pesi, int nVoti, ref double max, ref int posmax, ref double min, ref int posmin)
    {
        double sommaVoti = 0;
        double sommaPonderata = 0;

        for (int i = 0; i < nVoti; i++)
        {
            sommaVoti += voti[i] * pesi[i];
            sommaPonderata += pesi[i];

            if (voti[i] > max)
            {
                max = voti[i]; //andimao ad aggiornare il valore massimo e la sua posizione
                posmax = i;
            }

            if (voti[i] < min)
            {
                min = voti[i];//andimao ad aggiornare il valore minimo e la sua posizione
                posmin = i;
            }
        }

        return sommaVoti / sommaPonderata;  //media
    }
    static void ElencoVotiNellIntorno(double[] voti, int[] pesi, int nVoti, double voto)
    {
        double tolleranza = 0.5;
        Console.WriteLine($"\nElenco dei voti nell'intorno di +/- {tolleranza} rispetto al voto {voto}:");
        for (int i = 0; i < nVoti; i++)
        {
            if (voti[i] >= voto - tolleranza && voti[i] <= voto + tolleranza)
            {
                Console.WriteLine($"Voto: {voti[i]}, Peso: {pesi[i]}");
            }
        }
    } 

}
