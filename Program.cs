using System;

namespace Self2
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            Class2 n1 = new Class2("Mobeen", 10, 20, 40, 90);
            Class2 n2 = new Class2("butt", 130, 220, 540, 690);
            Class2 n3 = new Class2("3loop", 320, 120, 3340, 3290);
            Class2[] n = new Class2[3];
            n[0] = n1;
            n[1] = n2;
            n[2] = n3;


            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine(n[i].sname + " " + n[i].matricMarks);
            }

            Console.ReadLine();
        }
    }
}
