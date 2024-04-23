using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace c_sharp_lecture
{
    internal class Program
    {
        static void Method1()
        {
            Console.WriteLine("This is Function Command Execution");
        }
        static void Main(string[] args)
        {


            ////Variable 
            // int noOfQuantity = 23;
            // string productName = "Dell Latitude 5300";
            // double productPrice = 23.99;
            // bool isAvailble = false;
            // char qualityType = 'A';
            //// Constant Variable
            // const int myNumber = 03421214;
            //// Multi-Variable
            //// int x, y, z;
            // //x = y = z = 50;


            // //For Taking Input
            // string input;
            // Console.Write("Give Any String as Input: ");
            // input = Console.ReadLine();
            // Console.WriteLine("Input Value: "+input);

            // //string concat in writeline
            // Console.WriteLine("Product Name: " + productName);
            // //output command
            // Console.WriteLine("Hello World ");
            // Console.Write("from C#");//This Function will not change line after execution
            // Console.ReadLine(); //Take Enter as a Input

            // //Type - Casting
            // //Implict Casting
            // int myInt = 9;
            // double myDouble = myInt; // Automatic casting int to double 
            // bool myBool = false;
            //// or
            //// Explict Casting
            // double myDouble2 = 3.55;
            // int myInt2 = (int)myDouble2;
            // Console.WriteLine(myInt2);
            // Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            // Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            // Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            // Console.WriteLine(Convert.ToString(myBool));

            // //Operators
            // //Aritmaetic
            // int x = 5;
            // int y = 10;
            // Console.WriteLine(x + y); //addition 
            // Console.WriteLine(y - x); // subtraction
            // Console.WriteLine(y / 5); // division
            // Console.WriteLine(5 % 10); // Modulus
            // x++; // Incrment
            // Console.WriteLine(x);
            // y--;//Decrement
            // Console.WriteLine(y);

            ////Assignment Operator
            //int v1 = 10; //= is Assignment operator
            //v1 += 50; // += Adds a value to a variable
            //Console.WriteLine(v1); //Output 60

            ////Comparison Operator
            //int val1 = 50;
            //int val2 = 60;
            //int val3 = 50;
            //// Equal to 
            //Console.WriteLine(val1 == val3); //Output True
            //Console.WriteLine(val2 == val3); //Output False
            //// Not Equal to 
            //Console.WriteLine(val1 != val2);//Output True
            //Console.WriteLine(val2 != val3);//Output True
            //// Greater Then 
            //Console.WriteLine(val2 > val1);//Output True
            //// Greater or Equal to 
            //Console.WriteLine(val2 >= val1);//Output True

            ////Less than 
            //Console.WriteLine(val3 < val1);//Output False
            ////Less than or equal to
            //Console.WriteLine(val3 <= val1);//Output True

            ////Logical Operator
            //int cam1 = 5;
            //int cam2 = 10;

            ////logical and (&&)
            //Console.WriteLine(cam1 > 3 && cam2 <= 10); // returns True because 5 is greater than 3 AND 10 is less than equal to 10

            ////logical or (||)
            //Console.WriteLine(cam1 > 3 || cam2 < 4); // returns True because one of the conditions are True

            ////logical not (!)
            //Console.WriteLine(!(cam1 > 3 || cam2 < 4)); // returns False because ! (not) is used to reverse the result 

            ////C# Math 
            //Console.WriteLine(Math.Max(5, 10));//maximum value
            //Console.WriteLine(Math.Min(5, 10));//minimum value
            //Console.WriteLine(Math.Sqrt(64));//square root
            //Console.WriteLine(Math.Abs(-4.7));//returns the absolute (positive) value
            //Console.WriteLine(Math.Round(9.99));//

            ////String Methods
            //string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            //Console.WriteLine("The length of the txt string is: " + txt.Length);

            //string txt2 = "Hello World";
            //Console.WriteLine(txt2.ToUpper());
            //Console.WriteLine(txt2.ToLower());

            //string firstName = "Shammas";
            //string lastName = "Khan";
            //string name = string.Concat(firstName, lastName);
            //// string interpolation 
            //string name2 = $"My full name is: {firstName} {lastName}";
            //Console.WriteLine(name2);

            ////Strin access
            //string example = "ABCDEFG";
            //Console.WriteLine(example[0]); //first letter of string on index 0 

            //Console.WriteLine(example.IndexOf("F")); // return the index position of specific character 

            //string subString = example.Substring(3); //get all the string after  the position of 3
            //Console.WriteLine(subString);


            //// Arrays 
            //// Sort a string
            //string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            //Array.Sort(cars);
            //foreach (string i in cars)
            //{
            //    Console.WriteLine(i);
            //}
            ////2D Multi Dimensional Array 
            ////The single comma [,] specifies that the array is two-dimensional. A three-dimensional array would have two commas: int[,,].
            //int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };
            //Console.WriteLine(numbers[0, 2]);  // Outputs 2
            ////                       [row,column] RC Cola
            ////Itration through the 2D array 
            //for (int i = 0; i < numbers.GetLength(0); i++)
            //{
            //    for (int j = 0; j < numbers.GetLength(1); j++)
            //    {
            //        Console.WriteLine(numbers[i, j]);
            //    }
            //}

            ////If Else 
            //int cond1 = 10;
            //int cond2 = 20;
            //if( cond1 > cond2) {
            //    Console.WriteLine("Hey");
            //}
            //else {
            //    Console.WriteLine("Bye");
            //}

            ////if else ternary Operator
            //bool vr = (cond1 > cond2) ? true : false;

            //// switch
            //string inpurt = Console.ReadLine();
            //switch (inpurt)
            //{
            //    case "x":
            //        // code block
            //        break;
            //    case "y":
            //        // code block
            //        break;
            //    default:
            //        // code block
            //        break;
            //}
            //// Loop
            ////While 
            //while (inpurt == "y")
            //{
            //    // code block to be executed
            //}
            ////do While 
            //do
            //{
            //    // code block to be executed
            //}
            //while (inpurt == "y");

            ////for loop
            //for(int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Hey" + i);
            //}
            ////for eachLoop
            ////string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            //foreach (string i in cars)
            //{
            //    Console.WriteLine(i);
            //}



            Console.ReadLine();
            }
    }
}
