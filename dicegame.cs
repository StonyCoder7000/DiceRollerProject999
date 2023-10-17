using System;

class RiggedDiceRoller
{
    static void Main()
    {
        // Create a random number generator
        Random random = new Random();

        int rollCount = 0;
        bool continueRolling = true;

        while (continueRolling)
        {
            Console.WriteLine("Ready to roll the dice?");
            Console.WriteLine("Press Enter key to roll, or type 'exit' to stop...");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                continueRolling = false;
                Console.WriteLine("Exiting the program.");
            }
            else
            {
                // Roll the "dice"
                int result;
                if (rollCount % 9 == 0)
                {
                    result = 999; // Display 999 every ninth roll
                }
                else
                {
                    result = random.Next(1, 1001); // Generates a random number between 1 and 1000 (inclusive).
                }

                // Display the result
                Console.WriteLine($"Roll {rollCount + 1}: You rolled a {result}!");
                rollCount++;
            }
        }
    }
}
