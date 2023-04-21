namespace Block5
{
    internal class ForLoop
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Looping with FOR");
            Console.Title = "-== LOOPING WITH FOR ==-";
            /*FOR LOOP SYNTAX
             * 
             * for (COUNTER; CONDITION; UPDATE)
             * {
             *      //code to run
             * }
             * 
             * Some books refer to COUNTER as INITIALIZER
             * //! Mnemonic device: ICU 
             * 
             * Counter - the starting point where you initailize a 
             * variable that is used to check the condition. The 
             * counter gets updated after each pass through the loop.
             *
             * Condition - A Boolean statement that tells the loop
             * when to stop. It is checked before each pass.
             * 
             * Update - the change to the counter after each 
             *          pass of the loop (increment, decrement, etc.)
             * 
             * Remember: a for loop is best used when you know exactly 
             *           how many times you want to run the code
             *           
             * For loops are common and useful in many algorithms 
             * and methods in the C# language
             */
            //Example of a for loop that prints numbers 1 - 10.

            for (int count = 1; count <= 10; count++)//when you know what the condition should be
            {
                Console.WriteLine(count);
            }//end FOR ie repeating code
            Console.WriteLine("Enter 5 scores!");
            int[] scores = new int[5];
            for (int index = 0; index < scores.Length; index++)
            {
                Console.Write($"Enter a score ({index + 1}): ");
                scores[index] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(scores.Sum());
            Console.WriteLine($"Min: {scores.Min()}\nMax: {scores.Max()}\n Average: {scores.Average():n2}");

            //MINI-LAB!!            //Write a for loop that iterates through the            //scores array. Print out each score with n2 formatting
            Console.WriteLine("MiniLab");
            for (int index = 0; index < scores.Length; index++)
            {
                Console.WriteLine($"Score: {scores[index]:n2)}");
            }
            // count to 20 but skip 13 word continue stops the loop and starts the next loop.
            for (int count = 0; count <= 20; count++)
            {
                if (count == 13)
                {
                    {
                        continue;//skips the number starts on the next.
                    }


                Console.WriteLine(count);
                }//end if
            }//end for

            #region Footer
            Console.WriteLine("All code has finished. Press any key to terminate the program...");
            Console.ReadLine();

            #endregion

        }//main
    }//class
}//name