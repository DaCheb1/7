using System;
using System.Threading;

class Program
{
    static void Main()
    {
        // Создаем два потока
        Thread thread1 = new Thread(CountToTen);
        Thread thread2 = new Thread(CountToTen);

        // Запускаем потоки
        thread1.Start();
        thread2.Start();

        // Ожидаем завершения потоков
        thread1.Join();
        thread2.Join();

        Console.WriteLine("Оба потока завершены.");
    }

    static void CountToTen()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Поток {Thread.CurrentThread.ManagedThreadId}: {i}");
            Thread.Sleep(100); // Задержка в 100 миллисекунд
        }
    }
}