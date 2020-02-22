using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_3._5
{
    class Program
    {
        struct facul
        {
            public string no;
            public int rgm;
            public double N1;
            public double N2;
            public double N3;
            public double N4;
        }
        static void Main(string[] args)
        {
            facul faculdade;
            entrada(out faculdade);
            saida(faculdade);
            Console.Write("\nmedia:{0}", calc(faculdade));
            Console.ReadKey();
        }
        static void entrada (out facul X)
        {
            Console.Write("digite o nome");
            X.no = Console.ReadLine();
            Console.Write("digite o rgm");
            X.rgm = int.Parse(Console.ReadLine());
            Console.Write("digite a primeira nota");
            X.N1 = double.Parse(Console.ReadLine());
            Console.Write("digite a segunda nota");
            X.N2 = double.Parse(Console.ReadLine());
            Console.Write("digite a terceira nota");
            X.N3 = double.Parse(Console.ReadLine());
            Console.Write("digite a quarta nota");
            X.N4 = double.Parse(Console.ReadLine());
        }
        static void saida (facul X)
        {
            Console.Write("\nnome:{0}", X.no);
            Console.Write("\nrgm:{0}", X.rgm);
        }
        static double calc (facul X)
        {
            double cont = 0;
            cont = (X.N1 + X.N2 + X.N3 + X.N4) / 4;
            return cont;
        }
    }
}
