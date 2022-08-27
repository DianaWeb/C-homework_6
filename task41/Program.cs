/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */
System.Console.WriteLine("Укажите сколько чисел вы введете: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] array = new int[N];
int[] arrayNumber = EnterNumber(N);
HowManyPositiveNumbers(arrayNumber);

int[] EnterNumber(int number)
{
	for (int i = 0; i < number; i++)
	{
		System.Console.WriteLine("Введите число: ");
		array[i] = Convert.ToInt32(Console.ReadLine());
	}
	System.Console.WriteLine(string.Join(", ", array));
	return array;
}

void HowManyPositiveNumbers(int[] array)
{
	int count = 0;
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] > 0) count++;
	}
	System.Console.WriteLine($"Чисел больше нуля: {count}");
}
