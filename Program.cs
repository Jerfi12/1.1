namespace _1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stopword = "exit";
            bool isWorking = true;
            while (isWorking)
            {
                Console.Write("Введите команду: ");
                string command = Console.ReadLine();
                if(command == stopword)
                {
                    break;
                }
            }
            
        }
    }
}
