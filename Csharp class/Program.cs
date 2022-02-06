using System;

namespace Operators
{
    public class Division
    {
        static void Main()
        {
            short age = 4;
            char gender = 'M';
            DivideNumbers();

            Subtraction.Subtract(10, 9, 6);
            Arguments.Multiply("8", "9");
            
                 

        }
        static void DivideNumbers()
        {
            int a = 8;
            int b = 4;

            Console.WriteLine(a / b);


        }

        static void TypeConverter()
        {
            int i = 1;
            float f = i;
            Console.WriteLine(f);


        }





    }
    public class Subtraction
    {
        public static void Subtract(int parameter1, int parameter2, int parameter3)
        {
            Console.WriteLine(parameter1 - parameter2 - parameter3);

        }


    }

    public class Arguments
    {
        public static void Multiply(string age1 , string age2)      
        {
            Console.WriteLine( );


        }

    }










}
