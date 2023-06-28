using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Scrieti un program care citind de la tastaura cele trei dimensiuni ale unui paralelipiped dreptunghic, va afisa volumul lui*/

            int latura1ArieBaza;
            int latura2ArieBaza;
            int inaltime;

            Console.WriteLine("Acest program va calcula volumul unui paralelipiped dreptunghic"+ "\n"+ "\n");

            Console.WriteLine("Introduceti dimensiunea primei laturi a bazei:");
            latura1ArieBaza=int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti a doua latura a bazei:");
            latura2ArieBaza = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti inaltimea paralelipipedului dreptunghic:");
            inaltime = int.Parse(Console.ReadLine());

            int volumparalelipipeddrept = latura1ArieBaza * latura2ArieBaza * inaltime;

            Console.WriteLine("Volumul paralelipipedului dreptunghic este "  +  volumparalelipipeddrept + ".");
        }
    }
}