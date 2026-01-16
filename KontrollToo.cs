namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vali meetod");
            Console.WriteLine("1. püramid");
            Console.WriteLine("2. ruud");
            Console.WriteLine("3. ruutvõrrand");

            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {

                case 1:
                    püramid();
                    break;
                case 2:
                    ruud();
                    break;
                case 3:
                    ruutvõrrand();
                    break;
                default:
                    Console.WriteLine("vale valik");
                    break;


                    static void püramid()
                    {
                        int i, j, n;

                        Console.Write("Loo püramid tärnidest: \n");
                        Console.Write("\n\n");
                        Console.WriteLine("Sisesta püramid suurus");
                        n = Convert.ToInt32(Console.ReadLine());

                        for (i = 0; i <= n; i++)
                        {
                            for (j = 1; j <= n - i; j++)
                            {
                                Console.Write(" ");
                            }
                            for (j = 1; j <= 2 * i - 1; j++)
                            {
                                Console.Write("*");
                            }
                            Console.Write("\n");
                        }
                    }


                    static void ruud()
                    {
                        Console.Write("sisesta ruudu külg: ");
                        double side = double.Parse(Console.ReadLine());

                      

                        for (int i = 0; i < side; i++)
                        {
                            for (int j = 0; j < side; j++)
                            {
                                Console.Write("* ");
                            }
                            Console.WriteLine();
                        }

                        double area = side * side;
                        double perimeter = 4 * side;

                        Console.WriteLine("pindala; " + area);
                        Console.WriteLine("Ümbermõõt: " + perimeter);
                    }


                    static void ruutvõrrand()
                    {
                        Console.WriteLine("sisesta a: ");
                        double a = double.Parse(Console.ReadLine());

                        Console.Write("sisesta p: ");
                        double p = double.Parse(Console.ReadLine());

                        Console.Write("sisesta q: ");
                        double q = double.Parse(Console.ReadLine());

                        Console.Write("sisesta x: ");
                        double x = double.Parse(Console.ReadLine());

                        double y = a * Math.Pow(x - p, 2) + q;

                        Console.WriteLine("y = " + y);





                        


                    }
            }
        }
    }
}
