using System;

class Program
{
    static void Main()
    {
        Console.Write("Setiri daxil edin: ");
        string setir = Console.ReadLine();

        string enUzun = "";

        for (int i = 0; i < setir.Length; i++)
        {
           
            int sol = i, sag = i;
            while (sol >= 0 && sag < setir.Length && setir[sol] == setir[sag])
            {
                if (sag - sol + 1 > enUzun.Length)
                {
                    enUzun = "";
                    for (int k = sol; k <= sag; k++)
                        enUzun += setir[k];  
                }
                sol--; sag++;
            }
