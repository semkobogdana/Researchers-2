using System;

namespace program;

class Program {
    static void Main() {
        string[] b = new string[10];
        Console.WriteLine("Введіть Імена 10 дослідників:");
        
        for (int i = 0; i < 10; i++) {
            do {
                Console.Write($"Дослідник #{i + 1}: ");
                b[i] = Console.ReadLine()?.Trim() ?? "";
                if (string.IsNullOrEmpty(b[i])) 
                    Console.WriteLine("Помилка: ім'я не може бути порожнім!");
            } while (string.IsNullOrEmpty(b[i]));
        }

        Array.Sort(b);
        Console.WriteLine("\n Відсортовані дослідники за алфавітом:");
        for (int i = 0; i < b.Length; i++)
            Console.WriteLine($"{i + 1}. {b[i]}");
    }
}
