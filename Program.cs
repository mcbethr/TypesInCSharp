using System;

namespace TypesinCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int MyInteger = 2;
            decimal MyDecimal = 1.1m;
            bool MyBoolean = true;

            //You can't do this because of type checking
            //MyInteger = MyInteger / MyBoolean;






            string OneString = "1";
            int OneInt = Convert.ToInt32(OneString);


            ///VAR will type this at compile time and is smart enough to know
            ///What is a double and what is an integer.
            var one = 1;
            var two = 2.0;

            //This will work
            var sum = one + two;

            //So will this, because VAR knows that sum will be a Double
            double NewDouble;
            NewDouble = sum;


            //But This won't work
            int NewInteger;
            //NewInteger = sum;




            //We have to do this.
            //Is Pepsi OK?
            NewInteger = Convert.ToInt32(sum);




            //The dynamic keyword
            // turns off compile time checking.

            dynamic num1Dynamic = 1.5;
            dynamic num2Dynamic = 2;

            dynamic sumDynamic = num1Dynamic + num2Dynamic;
        }
    }
}
