Console.WriteLine("Введите строки (элементы массива) через запятую:");
string? line = Console.ReadLine();
if (!string.IsNullOrEmpty(line))
{
    string[] input = line.Split(',');
    string[] result = new string[0];
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i].Length <= 3)
        {
            Array.Resize(ref result, result.Length + 1);
            result[result.Length - 1] = input[i];
        }
    }
    if (result.Length != 0) Console.WriteLine($"Новый массив: {String.Join(", ", result)}");
    else Console.WriteLine("В исходном массиве нет строк длиной меньше или равно 3");
}
else Console.WriteLine("Исходный массив пуст");


