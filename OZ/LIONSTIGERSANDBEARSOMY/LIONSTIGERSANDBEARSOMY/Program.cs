using System;

namespace LIONSTIGERSANDBEARSOMY
{
    class Program
    {
        static void Main(string[] args)
        {
            OZ(4);

            void OZ(int Dorthy)
            {
                int Lion = 0, Tiger = 1, Bear = 0;
                Console.Write("{0} {1}", Lion, Tiger);
                for(int x = 2; x < Dorthy; x++)
                {
                    Bear = Lion + Tiger;
                    Console.Write(" {0}", Bear);
                    Lion = Tiger;
                    Tiger = Bear;
                }
                Console.ReadKey();
            }
           
        }
    }
}
