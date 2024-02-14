using System;
namespace ILU6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Störst(23,12));
        }
        static int Störst(int tal1, int tal2)
        {
            int störst;
            if (tal1 < tal2) 
            {
                störst = tal2;
            }
            else if(tal2 < tal1) 
            { 
                störst=tal1;
            }
            else
            {
                störst=tal1;
            }
            return störst;
        }

    }
}