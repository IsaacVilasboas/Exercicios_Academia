using System.Globalization;
namespace Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int a, b, c, d;
           double m;
             
           a = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           b = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           c = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           d = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

           m = (a+b+c+d) / 4.0;
           Console.WriteLine(m.ToString("F2",CultureInfo.InvariantCulture));

            if ( m >= 0)
            {
                if ( m < a)
                {
                    
                    Console.WriteLine(a);

                }
                if ( m < b) {
                    
                Console.WriteLine(b);
                }            
                if ( m < c)
                {
                  
                    Console.WriteLine(c);
                }            
                if (m < d)
                {
                    Console.WriteLine(d);
                }          
                
            }
        }
    }
}