using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace c_sharp_lecture
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            
           //Variable 
            int noOfQuantity = 23;
            string productName = "Dell Latitude 5300";
            double productPrice = 23.99;
            bool isAvailble = false;
            char qualityType = 'A';
           // Constant Variable
            const int myNumber = 03421214;
           // Multi-Variable
           // int x, y, z;
            //x = y = z = 50;


            //For Taking Input
            string input;
            Console.Write("Give Any String as Input: ");
            input = Console.ReadLine();
            Console.WriteLine("Input Value: "+input);

            //string concat in writeline
            Console.WriteLine("Product Name: " + productName);
            //output command
            Console.WriteLine("Hello World ");
            Console.Write("from C#");//This Function will not change line after execution
            Console.ReadLine(); //Take Enter as a Input
        
            //Type - Casting
            //Implict Casting
            int myInt = 9;
            double myDouble = myInt; // Automatic casting int to double 
            bool myBool = false;
           // or
           // Explict Casting
            double myDouble2 = 3.55;
            int myInt2 = (int)myDouble2;
            Console.WriteLine(myInt2);
            Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));

            //Operators
            //Aritmaetic
            int x = 5;
            int y = 10;
            Console.WriteLine(x + y); //addition 
            Console.WriteLine(y - x); // subtraction
            Console.WriteLine(y / 5); // division
            Console.WriteLine(5 % 10); // Modulus
            x++; // Incrment
            Console.WriteLine(x);
            y--;//Decrement
            Console.WriteLine(y);

            Console.ReadLine();
            }
    }
}
