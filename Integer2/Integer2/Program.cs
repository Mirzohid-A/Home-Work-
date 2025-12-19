using System;
  namespace integer2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Массаро бо кг ворид намоед m = ?");
            int m = Convert.ToInt32(Console.ReadLine());// double варинат агар барои нишон доданни резуьтати полный
            var kg = m / 1000;

            if (m <= 999) 
            {
                Console.WriteLine("Масса бо кг = " + kg);
            }
            else
            {
                Console.WriteLine("Mасса бо тонана = " + kg);
            }

                
        }
    }
}