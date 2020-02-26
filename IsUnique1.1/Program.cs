using System;

// Interview Question

// Implement an algorithm to determine if a string has all unique characters. 
// What if you cannot use additional data structures?



namespace IsUnique1._1
{
    class Program
    {
        static void Main(string[] args)
        {

            //non-unique string
            string isUnique = "sfdasyhidsjahfiuhushufhuehuehuheuheuhuwheuhruehwruhebfdhbah";

            //Unique string
            string isUnique1 = "qazwsxedcrfvtgb";

            //First solution that comes to mind-----------------------------------------------------------------------------------

            /*
            for (int firstIndex = 0; firstIndex < length; firstIndex++)
			{
                string check = isUnique[firstIndex];
                for (int secondIndex = 0; secondIndex < length; secondIndex++)
			    {
                    if (check == isUnique[second])
	                {
                        return "We have repeating characters";
	                }
			    }
			}
            return "We have no repeating characters!";
            */
            

            //Solution from reading chapter---------------------------------------------------------------------------------------
            //Solution shown in book----------------------------------------------------------------------------------------------


        }
    }
}
