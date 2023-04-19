namespace Block2Labs
{
    internal class Block2LabTempconvert
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Converting temperatures");
            Console.WriteLine("Celsius to Fahrenheit");
            double fah = 75, cel = 30;
            Console.WriteLine("The temperature in Celsius is " + cel);
            fah = cel * (9.0 / 5.0) + 32;
            Console.WriteLine("The temperature in FahrenHeit is " + fah);
            fah = 75;
            Console.WriteLine("Fahrenheit to Celsius");
            cel = (5.0 / 9.0) * (fah - 32);
            Console.WriteLine("The temperature in Fahrenheit is " + fah);
            Console.WriteLine("The temperature in Celsius is " + cel);
        }
    }
}