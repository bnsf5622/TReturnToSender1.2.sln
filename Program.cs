using System;

namespace TReturnToSender1._2.sln
{
    class Program
    {
        static void Main(string[] args)
        {
            string aMystery = Mystery();
            string totallyUnexpected = Unexpected();
            string aSurprise = Surprise();
            string itsClassified = Classified();
            string aSecret = Secret();

            Console.WriteLine("The methods have returned! Their results...\n");
            Console.WriteLine("Mysterious: " + aMystery);
            Console.WriteLine(" Secret: " + aSecret);
            Console.WriteLine("Suprising: " + aSuprise);
            Console.WriteLine("Classified: " + itsClassified);
            Console.WriteLine("Unexpected: " + totallyUnexpected);

        }

        public static int Secret()
        {
            return 42;
        }

        public static double Surprise()
        {
            return 3.14;
        }

        public static char Mystery()
        {
            return 'X';
        }

        public static bool Classified()
        {
            return true;
        }

        public static String Unexpected()
        {
            return "Spanish Inquisition";
        }
        
    }
}
