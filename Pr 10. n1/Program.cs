namespace Pr_10._n1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double z, x, n;
            z = 0;
            Console.Write("x= ");
            x = double.Parse(Console.ReadLine());
            Console.Write("(n>0), n= ");
            n = double.Parse(Console.ReadLine());

            for (int i = 1; i < n + 1; i++) z += Math.Pow((-1),i-1) * (Math.Pow(x, (2*i + 1))/ ((2*i + 1)*(2*(i-1) + 1)));
            Console.WriteLine("z = {0}", z);
        }
    }
}