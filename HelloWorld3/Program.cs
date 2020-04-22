using System;

namespace HelloWorld3
{



    class Program

    {
        static void Main(string[] args)
        {

            try
            {

                var number = "1234";
                byte b = Convert.ToByte(number);
                Console.WriteLine(b);
            }
            catch (Exception)
            {

                Console.WriteLine("The number couldnot be converter...");
                
            }
          
        }
    }
}
