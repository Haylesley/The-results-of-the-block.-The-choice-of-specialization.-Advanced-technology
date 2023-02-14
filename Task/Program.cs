/* Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк,
 длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
 либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
 лучше обойтись исключительно массивами.
Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []
*/

string[] array = CreatingArray();
string[] newArray = TaskSolution(array);

Console.Write($"[\"{String.Join("\", \"", array)}\"] -> [\"{String.Join("\", \"", DeleteNull(newArray))}\"]");

//=====================Methods=============================

string[] CreatingArray()
{
    int n = GetNumberFromUser($"Введите количество элементов массива: ", "Ошибка");
    string[] array = new string[n];
    
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива: ");
        array[i] =Console.ReadLine();
    }
    return array;

}

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}