namespace Block4
{
    internal class Arrays
    {
        static void Main(string[] args)
        {
            /*
             * An array stores a fixed-size sequential collection of 
             * objects of the same type. 
             * 
             * An array is used to store a collection of 
             * data, but it is often more useful to think of an array as 
             * a collection of variables of the same type.
             * 
             * Standard Arrays: 
             * 
             * - Have a fixed size (can't change it programmatically)
             * - The size is called the Length (1-based counting)
             * - Uses 0-based counting for the positions of the indexes.
             * - Type safe
             * - Use the "new" keyword to call the "constructor" that builds the object
             */
            Console.WriteLine("Arrays!");
            //     2 ways to make array
            //     first delare it with a set length. | datatype[] name = new datatype[int length];
            //     ^^ good for when you know the size but not the values
            //     second way Collection Initializationn syntax. Great if we have all the values we want
            //     ie. datatype[] name = {variable, " ", ect };

            //First way
            string[] dresser = new string[4];//declared a new string array called dresser with a length of 4.
            //Initialize the values of the drawers individually.
            //arrayName at the index of x => dresser[0]
            dresser[0] = "shirts";//0
            dresser[1] = "pants";//1
            dresser[2] = "socks";//2
            dresser[3] = "shorts";//3
            Console.WriteLine(dresser[2] + " are in the drawer with an index of 2");

            Console.WriteLine($"{dresser[3]} is in the last drawer");
            dresser[3] = "t-shirts";//reassignment
            Console.WriteLine("{3} are in the 4th drawer with an index of 3", dresser);
            Console.WriteLine("{1} are in index 1 and {2} are in index 2", dresser);

            //to explor an object in intellisence, use a period.
            Console.WriteLine(dresser.Length + " is the length of the Array.");
            // the last index is always -1 than the length of the array.
            //first index is ALWAYS 0
            Console.WriteLine(dresser[0]);
            Console.WriteLine(dresser[dresser.Length - 1]);

            /* Indexers / Index Operator =  ^
            string[] arrayName = new string[6];
            Index               Reverse Index
            0                   ^6 (length - 6)
            1                   ^5 (length - 5)
            2                   ^4 (length - 4)
            3                   ^3 (length - 3)
            4                   ^2 (length - 2)
            5                   ^1 (length - 1)
            arrayName.Length    ^0 (length - 0)--out of bounds exception
            */
            Console.WriteLine(dresser[^1]);
            decimal[] prices = new decimal[5];//0 to 4 index
            prices[0] = 24.99m;
            prices[1] = 100;
            prices[2] = 50;
            prices[3] = 9.75m;
            prices[4] = 199;
            //runtime error if you have try to use an index that is less than zero or bigger than the length
            Console.WriteLine(prices[1].ToString("c"));
            Console.WriteLine(prices.GetType());//Namespace.ClassName/System.Decimal[]
            Console.WriteLine("{0:c}", prices[1]);
            Console.WriteLine($"{prices[1]:c}");

            Console.WriteLine("Prices: " + (prices[0] + prices[1] + prices[2] + prices[3] + prices[4]).ToString("c"));
            decimal totalSale = prices.Sum();
            Console.WriteLine($"Total Sale: {totalSale:c}");
            Console.WriteLine(42.ToString("n"));//$42.00

            //Sort() is a static method called from the class name "array". it accepts an argument for the array to be sorted. it sorts the values into new indexes from a to z oldest to newest and 0 to 9 for numbers. this is known as an "ascending" sort
            Array.Sort(prices);
            Console.WriteLine("\nPrices has {0} indexes.\n" +
                     "1st Index: {1:c}\n" +
                     "last index: {2:c}",
                     prices.Length,
                     prices[0],
                     prices[^1]);

            //decending sort : sort the array normally then flip it 
            Array.Reverse(prices);
            Console.WriteLine("\nPrices has {0} indexes.\n" +
                     "1st Index: {1:c}\n" +
                     "last index: {2:c}",
                     prices.Length,
                     prices[0],
                     prices[^1]);


        }//end main()
    }//end class
}//end name