namespace Block3Labs
{
    internal class WaterLab
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Water Lab");
            Console.WriteLine("How many gallons of water do you have? ");
            decimal gallons = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"You have: {gallons * 8.33m} Lbs of water" );


        }//end main()
    }//end class
}//end name