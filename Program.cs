using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Working_with_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" i am enjoying this C# class \n Evans is  Great Teacher \n I am learning alot from him");
            Console.WriteLine("Hi, my name is \"Nokubongwa\"");

            //declearations

            string name = "Nokubongwa";
            string surname = "Mncube";

            Console.WriteLine(name + " " + surname); // the + is used to concatinate
            Console.WriteLine("The length of my name is " + name.Length);

            //change name to upper case and surname to lowercase
            Console.WriteLine("name as uppercase " + name.ToUpper());
            Console.WriteLine("surname to lower " + surname.ToLower());
            Console.WriteLine("Does name contain No " + name.Contains("No"));
            Console.WriteLine("Does surname contain XO " + surname.Contains("Xo"));
            Console.WriteLine("The first letter of my name is " + name[0]);
            Console.WriteLine("What is the index of k in " + name.IndexOf("k"));
            Console.WriteLine("The substring from 2 is " + name.Substring(2));
            Console.WriteLine("The substring from 0 to 10 " + name.Substring(0, 10));




              
               
            Console.ReadLine();

        }
    }
}
