namespace Block3
{
    internal class InputParseConvert
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Capturing input, parsing, and converting.");//line return aftrer writeing
            Console.Write("Hello!");// no line return 
            Console.Write(" Hello my name is Jace.");
            Console.WriteLine(" - an now a line return.");// aka line break, new line 

            Console.WriteLine();
            //input 
            // console.read() only takes 1 keystroke of input and stores the ascii value of the key.
            //console.readkey(bool intercept) - optional bool - only takes 1 keystroke, but it stores the character value.
            //console.readline() - most common - it allows the user to type anything and reads the input as a string.
            //Console.Read();
            /*
             * you cannot put any code inside of the perens of a console.readline()
             * you must store or use the information returned by the readline() or you lose it forever
             * allways tell the user what you want them to do before collecting input.
             */

            Console.WriteLine("What is your name? ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!!");

            //an example of using the info immediately
            Console.Write("What is your quest? ");
            Console.WriteLine(Console.ReadLine() + " is a silly quest...");


            //Ask the user their favorite color. Tell them their color back and what you think of it.
            //Use the name they gave you in the variable above in your response.
            //MINI LAB!

            Console.WriteLine("What is your favorite color? ");
            Console.WriteLine(Console.ReadLine() + "?" + " That color is ugly!" + name);//conCATuNATION

            Console.Write("What planet are you from?: ");
            string planet = Console.ReadLine();
            //Console.WriteLine(planet + " is great, " + name + "!");
            //string interpolation!! ** $ starts the interpolation **
            Console.WriteLine($"{planet} is a great planet, {name}!");//$ denotes string interpolation

            //readline method always returns a string we cant math with a string so we have to do some work to use that 
            //information as another datatype.
            //parse syntax : targetDataType.Parse(stringvalue)
            int firstParse = int.Parse("1209");

            Console.WriteLine("Enter your age: ");
            string userAge = Console.ReadLine();
            int age = int.Parse(userAge);
            Console.WriteLine($"Only {100 - age} more years until 100! {name} from the planet {planet}!");


            Console.Write("How much do you want to make per year? $");
            decimal salary = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"Well, {salary * .35m:c} will go to taxes...");

            //Convert method requires using true names for datatype
            /*
             * byte = Byte
             * short = Int16
             * int = Int32
             * long = Int34
             * decimal = Decimal
             * double = Double
             * float = Single
             * string = String
             * char = Char
             * bool = Boolean
             */
            //Convert.ToTrueName(target)
            Console.Write("How many times have you been smuggled though Imperial lines by Solo and Chewie" +
                "Shipping, LLC? ");
            string strTimesSuggled = Console.ReadLine();
            //short shortTimesSumggled = short.Parse(strTimesSuggled);
            short shortTimesSmuggled = Convert.ToInt16(strTimesSuggled);
            Console.WriteLine($"You have {10 - shortTimesSmuggled} more trips to get a free Wookie Bowcaster");

            //String Formatting
            //uses content place holders {#} with 0-based counting for indexes.
            string message = string.Format("You have {0} more trips to get free Wookie Bowcaster. ",
            10 - shortTimesSmuggled,//{0}
                name,//1
                planet);//2
            Console.WriteLine(message);
            
            

        }//end main()
    }//end class
}// end namspace