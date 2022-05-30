using System;

namespace StringsV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Guilliam Oberholster ";
            Console.WriteLine("trim: '{0}'", fullName.Trim() );
            Console.WriteLine("To Upper: '{0}'", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firsName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("First name" + firsName);
            Console.WriteLine("last Name" +lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("First name" + names[0]);
            Console.WriteLine("last Name" + names[1]);

           Console.WriteLine( fullName.Replace ("Guilliam" ,"Guills"));

            if (String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");

            var str = "25";
            var age = Convert.ToByte (str);
            Console.WriteLine(age);

            float price = 29.95f;
            price.ToString("C");
            
            Console.WriteLine(price.ToString("C0"));
          
        }
    }
}
