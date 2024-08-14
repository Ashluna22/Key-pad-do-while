using System;







namespace Key_Pad_with_do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continueProgram = true;
            string correctCode = "13579";
            int attempts = 0;
            int maxAttempts = 5;

            do
            {
                Console.WriteLine("Hello, Please enter key code: ");
                string code = Console.ReadLine();
                attempts++;

                if (code == correctCode)
                {
                    continueProgram = false;
                    Console.WriteLine("Welcome!");
                }
            } while (continueProgram && attempts < maxAttempts);

            if (attempts == maxAttempts && continueProgram)
            {
                Console.WriteLine("Too many incorrect attempts. Goodbye!");
            }
        }
    }
}



