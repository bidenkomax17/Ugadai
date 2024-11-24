using System;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("PC загадал число от 1 до 100, угадай");
        Random rnd = new Random();
        int pcNumber = rnd.Next(99)+1;
        //Console.WriteLine(pcNumber);
        bool status = true;
        int attempts = 0;
        while (status)
        {
            Console.WriteLine("Введите все число");
            int userNumber = int.Parse(Console.ReadLine());
            attempts++;
            if(pcNumber == userNumber)
            {
                Console.WriteLine("Вы выиграли ! Количество попыток: " + attempts);
                status = false;
            }
            else if (pcNumber > userNumber)
            {
                Console.WriteLine("Ваше число меньше");
            }
            else
            {
                Console.WriteLine("Ваше число больше");
            }
        }
        Console.ReadKey();
    }
}