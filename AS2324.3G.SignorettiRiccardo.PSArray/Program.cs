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

        Random rnd = new Random();
        for (int i = 0; i < nVoti; i++)
        {
            voti[i] = rnd.Next(0, 11);
            pesi[i] = rnd.Next(0, 101);
        }



        StampaVotiPesi(voti, pesi, nVoti);
        Console.ReadLine();

    }

    static void StampaVotiPesi(double[] voti, int[] pesi, int nVoti)
    {
        Console.WriteLine("Voti e Pesi:");
        for (int i = 0; i < nVoti; i++)
        {
            Console.WriteLine($"Voto: {voti[i]}, Peso: {pesi[i]}");
        }
    }

}
