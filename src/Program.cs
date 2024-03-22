using System;

namespace FunctionChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            // Challenge 1: String and Number Processor
            Console.WriteLine("Challenge 1: String and Number Processor");
            StringNumberProcessor("Hello", 100, 200, "World"); // Expected outcome: "Hello World; 300"

            // Challenge 2: Object Swapper
            Console.WriteLine("\nChallenge 2: Object Swapper");
            int num1 = 25, num2 = 30;
            int num3 = 10, num4 = 30;
            string str1 = "HelloWorld", str2 = "Programming";
            string str3 = "Hi", str4 = "Programming";
                          
            SwapObjects( ref  num1,ref  num2); // Expected outcome: num1 = 30, num2 = 25  
            SwapObjects( ref num3, ref num4); // Error: Value must be more than 18

            SwapObjects(ref  str1,ref  str2); // Expected outcome: str1 = "Programming", str2 = "HelloWorld"
            SwapObjects(ref  str3, ref  str4); // Error: Length must be more than 5

            SwapObjects( true, false); // Error: Upsupported data type
            SwapObjects( num1, str1); // Error: Objects must be of same types

            Console.WriteLine($"Numbers: {num1}, {num2}");
            Console.WriteLine($"Strings: {str1}, {str2}");
            

            // Challenge 3: Guessing Game
            Console.WriteLine("\nChallenge 3: Guessing Game");
            
            GuessingGame(); // Expected outcome: User input until the correct number is guessed or user inputs `Quit`

            //Challenge 4: Simple Word Reversal
            Console.WriteLine("\nChallenge 4: Simple Word Reversal");
            string sentence = "This is the original sentence!";
            string reversed = ReverseWords(sentence);
            Console.WriteLine(reversed); // Expected outcome: "sihT si eht lanigiro !ecnetnes"
        }

         static void StringNumberProcessor(params object[] inputs)
        {
            string concatenate = "";
            int sum = 0;
            foreach (var input in inputs) {
                if (input is string)
                {
                   concatenate += (string)input + " ";
                }
                else {
                    sum += (int)input;

                }


             }
            concatenate= concatenate.Trim();
        Console.WriteLine($"{concatenate}; {sum}");
            
        }
        
        public static void SwapObjects(ref int num1, ref int num2)
        {
            if (num1 > 18 && num2 > 18)
            {
                (num1, num2) = (num2, num1);
            }
            else { 
                Console.WriteLine("Error: Value must be more than 18");
            }
        }
        public static void SwapObjects(ref string str1,ref string str2) {
            if (str1.Length > 5 && str2.Length > 5)
            {
                (str1, str2) = (str2, str1);
            }
            else { 
             Console.WriteLine("Error: Length must be more than 5");

            }

        }
        static void SwapObjects( object obj1, object obj2)
    {
        if (obj1.GetType() != obj2.GetType())
        {
            Console.WriteLine("Error: Objects must be of the same types (string or number)");
        }
        else
        {
            Console.WriteLine("Error: Unsupported type");
        }
    }


         static void GuessingGame()
        {
            Random random = new Random();
        int randomNumber = random.Next(1, 100);

        while (true)
        {
            Console.WriteLine("__________________________________________________________");
            Console.WriteLine("Enter your guessing number or enter 'quit' to end the game: ");
                Console.WriteLine("__________________________________________________________");
            string input = Console.ReadLine()?? "";

            if (input == "quit")
            {
                Console.WriteLine("The game has ended.");
                break;
            }

            if (!int.TryParse(input, out int guess))
            {
                Console.WriteLine("Please enter a valid number.");
                continue;
            }

            if (guess == randomNumber)
            {
                Console.WriteLine("Congratulations! You guessed the correct number.");
                break;
            }
            else
            {
                Console.WriteLine(guess < randomNumber ? "you almost there ,just try a higher number!" : "you almost there ,just try a lower number!");
            }
        }
            
        }

        public static string ReverseWords(string sentence)
    {

           string[] words = sentence.Split(' ');


        IEnumerable<string> reversedWords = words.Select(word => new string(word.Reverse().ToArray()));


string reversedSentence = string.Join(" ", reversedWords);

return reversedSentence;

    }

        
        
    }
}
