namespace Block2
{
    //in order for block2 to execute we must set it as our startup project.
    //this is different from the startup object
    //to set startup project right click pon the project and select set as startup project
    //to set start object go to properties
    internal class Casting
    {
        static void Main(string[] args)
        {
            #region Casting Notes
            /*
             * casting is just copying the value from a variable of one type into a variable of a different but similar type.
             * IMPLICIT casting copies contents from small to big automatically for you.
             */
            #endregion
            Console.WriteLine("Casting!");

            byte small = 1;//8 bits
            short medium = 200;//16 bits
            int large = 32_261;//32 bits
            long xl;//declare, but not initalize. 64bits

            //right to left thinking.
            //long container = byte value
            //(byte to long)
            xl = small;
            Console.WriteLine("the XL container has a value of:" + xl);//1
            long extraLarge = xl;//not actually casting. long to a long. both have the same datatype(bit count)
            Console.WriteLine("The container has a value of:" + small);

            //small = xl;
            #region Explicit Casting
            /*
             * going from a larger to a smaller container. this requies extra work.
             * you must explicitly state the datatype you are converting/casting to.
             * 
             * this can create issues if the value doesnt fit
             */


            #endregion
            //medium into small
            small = (byte)medium;//Explicit casting
            Console.WriteLine("The Small Container has the value of:" + small);
            Console.WriteLine("the Medium container keeps its value of:" + medium);

            //if you expicitly cast a value that exceedes datatype.MaxValue to a smaller container,
            //you get truncation
            //above, we set large to 32,261 what happens if we copy that value to a byte?
            small = (byte)large;
            Console.WriteLine("The Small container has the value of:" + small);
            /*
            00000000 00000000 00000000 00000000 | 00000000 00000000 | 00000000 | 00000000
            
            00000000 00000000 01111110 00000101 --int 32,261
                                       00000101 --byte 32,261 = 5
             */
            //Cast the long into the int and display it.
            large = (int)xl;//Explicit casting without truncation
                            //large = the int version of xl
                            //large is assigned the int version of the value in xl.

            decimal dec1 = 4.3m;
            decimal dec2 = (decimal)4.3;
            //same outcome
            //m or M is a shortcut for explicitly casting a double to a decimal.
            //f and F shortcut for explicitly casting a double to float.

            //foat is a single-precision floating-point number.
            //double uses 2 floats. it is a double-precision floating-point number.

            decimal deathStars = 1.75m;
            //as an example where truncation might be usful
            int completedDS = (int)deathStars;
            Console.WriteLine( " Out of " + deathStars + " Death Stars, only "
                 + completedDS + " was/were completed.");

            //MINI LAB
            //Create two string variables for first name and last name 
            //using these two variables create the signature intro for 007
            string fName = "James";
            string lName = "Bond";
            Console.WriteLine( "The names " + lName + ", " + fName +"," + lName + "."  );



        }
    }
}