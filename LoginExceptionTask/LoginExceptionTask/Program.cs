using System;

namespace LoginExceptionTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Login("fidash.13", 12345);
        }

        public static void Login(string name, int pascode)
        {
            try
            {
                string n = "fidash.13";
                int m = 12345;

                if (pascode == m && (name == n))
                {
                    throw new Account("Girish olundu");
                }
                Console.WriteLine("Girish olunmadi");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}