namespace MadLibGenerator {
    internal class Program {
        static void Main(string[] args) {
          
            bool playAgain;

            do {
                // Get words from the user
                Console.WriteLine("Welcome to Mad Libs! Let's create a story." +
                "Please enter the following?");

                Console.Write("Enter a name: ");
                string name = Console.ReadLine();

                Console.Write("Enter a place: ");
                string place = Console.ReadLine();

                Console.Write("Enter a noun: ");
                string noun = Console.ReadLine();

                Console.Write("Enter a verb: ");
                string verb = Console.ReadLine();

                Console.Write("Enter a adjective: ");
                string adjective = Console.ReadLine();

                // Conditional with ternary operator
                string emotion = name.Length > 3 ? "excited" : "curious";

                // Story output using interpolation and concatenation
                string story = $"Once upon a time, {name} went to {place}. " +
                               $" {name} saw a vey {adjective} {noun} there, and decided to ${verb} with it. " +
                               $"{name} felt {emotion} about the adventure.";

                Console.WriteLine("\nHere's you story:\n " + story);

                // Loop to continue story
                Console.WriteLine("\nDo you want to add a twist to your story? (Y/N)");
                char choice = Console.ReadKey().KeyChar;

                switch (choice) {
                    case 'Y':
                    case 'y':
                        Console.WriteLine("\nAdding a twist...");
                        Console.WriteLine($"Suddenly, a giant {noun} appeared in {place}, and " +
                                          $" {name} had to {verb} faster then ever!");
                        break;
                    case 'N':
                    case 'n':
                        Console.WriteLine("\nNo twist added. Maybe next time!");
                        break;
                    default:
                        Console.WriteLine("\nInvalid choice. No twist added.");
                        break;
                }

                // ask the user if they want to play again
                Console.WriteLine("\nDo you want to play again? (yes/no)");
                playAgain = Console.ReadLine().ToLower() == "yes";
            } while (playAgain);

            Console.WriteLine("\nThank you for playing Mad Libs! Goodbye!");
        }
    }
}
