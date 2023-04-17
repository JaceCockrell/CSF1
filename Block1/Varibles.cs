
//A namespace refers to the project your code file lives in . Here, is is Block1.
//A namespace is typically defined using PascalCase nameing convention.
//C# keywords are all lowercase, and are typically darkblue.
namespace Block1
{
    //adding "//" to a line will create a lingle-line comment. comment still ignored by compliler.
    /*
     * this is a multi-line comment.
     * any content between the slashtrisks will be ignored
     * the cannot be nested
     */
    //A class is a C# file that contains code that your app will use to run.
    //PascalCase
    class Varibles
    {
        //A method is the verb of the C# language it is where action is performed.
        //All classes that are intented to run will hace at least one method callled Main()
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Save changes with CTRL + S or save all CTRL + SHIFT + S
            //we can build (compile) our project with CTRL + shift + B
            //we can launch (run) with CTRL + F5 which saves the build as well.

            //**** Varibles ****//
            /*
             * A variable is just a container to hold information.
             * when the container is created, we must define what type of data it will hold (type-safety).
             * the data stored in the variable can be changed but the type cannot 
             * Variables are traditionally named using camelCase convention
             * --Must begin with alphabetic characters or and underscore
             * --connot contain spaces
             * -- cannot be a reserved C# keyword (dark blue, static, void, class, namespace ect )
             * --they must be unique within their scope {}
             * */

            //When creating a variable, we must do at least 2 things before we can use it.
            //1. declaration: create the variable by giving it a DataType and a Name.
            int firstExample;

            //int firstExample;
            //string firstExample; 
            //2. Initalization: Giving an example a value for the first time.
            firstExample = 1;//Note no datatpe After it is declared, we refer it by name only.
            Console.WriteLine(firstExample);

            //3. Assignment/Reassignment - Giving a variable a value other that the first time (Initialalization)
            firstExample = 42;
            Console.WriteLine(firstExample);

            //Declaration with initialization
            string name = "Anakin Skywalker";
            Console.WriteLine(name);
            Console.WriteLine("After episode III");
            name = "Darth Vader";
            Console.WriteLine(name);
               //Variables are objects (instances of [insert datatype here])
               //Literal is just a value without a container. "hardcoded" and cannot be reused without typing it again.

            //Strings store an unlimited number of text characters.
            //Ints can only store whole numbers.

            //+
            Console.WriteLine(17 + 25); //numeric calculation (adding two literal ints together)
            Console.WriteLine("17" + "25");
            //CTRL k CTRL D format (prettier)

            Console.WriteLine("The answer is: " + (42 + 19));
            //When adding (+) a string with anything else, it is considered 'concatenation'
            //This combines all values as a string and smashes them all together. 
            //Surround equations/expressions in a () to trump the concatention order of operations. OoO
        }//end Main()
    }//end class  
}//end namspace
