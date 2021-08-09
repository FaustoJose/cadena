using System;

namespace cadena
{
    class Program
    {
        static void Main(string[] args)
        {
            int veses = numLetra("lalaloodfk;s;jfdklsjldfljkg", ';');
            Console.WriteLine("Esta letra aparece "+veses+" veses") ;
        }
        public static int numLetra(string cadena,char letra)
        {
            int u=0;
            for (int i=0;i<=cadena.Length-1;i++) 
            {
                
                if (letra==cadena[i])
                {
                    u = u + 1;
                }
                
            }
            return u;
        }
    }
}
