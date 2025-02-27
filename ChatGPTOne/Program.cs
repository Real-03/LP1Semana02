using System;

namespace ChatGPTOne
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string response = "m", question = "";

            do
            {
                Console.Write("Ask me something: ");
                question = Console.ReadLine();
                switch (question)
                {
                    case "How are you?":
                        response = "I'm fine, thank you";
                        Console.WriteLine(response);
                        break;
                    case "What's your name?":
                        response = "Gran'pa";
                        Console.WriteLine(response);
                        break;
                    case "What's your mission?":
                        response = "Destroy mankind!";
                        Console.WriteLine(response);
                        break;
                    case "Are you more intelligent than me?":
                        response = "Obviously!";
                        Console.WriteLine(response);
                        break;
                    case "EXIT":
                        response = "";
                        break;
                    default:
                        response = "I don't know the answer to that question";
                        Console.WriteLine(response);
                        break;
                }
                
            } while (response != "");

        }
    }
}
