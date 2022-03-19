using System;

namespace Alg_3._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Poadj a: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Poadj b: ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Poadj c: ");
            float c = float.Parse(Console.ReadLine());
            Console.WriteLine("Poadj d: ");
            float d = float.Parse(Console.ReadLine());


            double w = -b / 3 * a;
            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);
            Console.WriteLine("c: " + c);
            Console.WriteLine("d: " + d);
            Console.WriteLine("w: " + w);

            double p = (3*a*Math.Pow(w,2) + 2*b*w + c)/a;
            double q = (a*Math.Pow(w,3) + b*Math.Pow(w, 2) + c*w + d)/a;

            Console.WriteLine("p: " + p);
            Console.WriteLine("q: " + q);

            double delta = (Math.Pow(q, 2) / 4) + (Math.Pow(p, 3) / 27);

            Console.WriteLine("delta: " + delta);
            
            if(delta > 0)
            {

                double p1 = -q / 2;
                double p2 = Math.Pow(delta, 1D / 2);
                double p3 = (p1-p2) * -1;
                

                double u = Math.Pow(p1+p2,1D/3);
                Console.WriteLine("u: " + u);
                double v = Math.Pow(p3, 1D/3) * -1;
                Console.WriteLine("v: " + v);

                double x1 = u + v + w;

                Console.WriteLine("x1: " + x1);
            }
            
            
        }
    }
}
