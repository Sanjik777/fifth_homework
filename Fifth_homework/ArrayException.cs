using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
2.	Написать программу, которая обращается к элементам массива по индексу и выходит за его пределы.
После обработки исключения вывести в финальном блоке сообщение о завершении обработки массива.
*/
namespace Fifth_homework
{
	public class ArrayException
	{
		public void CheckException()
		{
			const int arrayLength = 4;
			const int biggerLength = 5;

			int[] mas = new int[arrayLength];
			try
			{
				Console.Write("\nМассив: ");
				for (int i = 0; i < biggerLength; i++)
				{
					Console.Write(mas[i]);
					Console.Write(" ");
				}
			}
			catch (IndexOutOfRangeException exception)
			{
				Console.WriteLine($"\nВозникло исключение: {exception.Message}");
			}
			finally { Console.WriteLine("Finally"); }
		}
	}
}
