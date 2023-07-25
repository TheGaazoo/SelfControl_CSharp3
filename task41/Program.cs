Console.Write("Введите элементы (через пробел): ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
Console.WriteLine($"[{string.Join(", ", array)}]");
int count = array.Count(x => x > 0);
Console.WriteLine($"Количество положительных элементов = {count}");