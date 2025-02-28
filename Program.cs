namespace Задание_1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            while(userInput != "exit")
            {
                Console.Write("Введите что-нибудь (или 'exit' для выхода):");
                userInput = Console.ReadLine();
                
                if(userInput != "exit")
                {
                    Console.WriteLine($"Вы ввели: {userInput}");
                }
            }
            Console.WriteLine("Вы завершили программу");
        }
    }
}
