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
    

}
