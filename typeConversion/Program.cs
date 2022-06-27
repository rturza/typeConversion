using System;

namespace typeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*byte b = 1;
            int i = b;
            Console.WriteLine(i);*/

            /*var number = "1234";
            int i = Convert.ToInt32(number);
            Console.WriteLine(i);*/

            /*try
            {
                var number = "1234";
                byte b = Convert.byte(number);
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("This number couldn't be converted to byte.");
            }*/

            var a = 1;
            var b = 2;
            var c = 3;

            Console.WriteLine(!(c>b) || (c==a));
        }
    }
}
