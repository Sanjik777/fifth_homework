using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
1.	реализовать метод деления двух чисел. Внутри метода проверять входящие параметры.
Если они не заданы, то генерировать исключение ArgumentNullException.
Если делитель равен нулю, то генерировать исключение ArgumentException.
*/
namespace Fifth_homework
{
	public class DivisionException
	{
		public void DivisionOfNumbers(string firstNumber, string secondNumber)
		{
			try
			{
				if (firstNumber == null && secondNumber == null )
				{
					throw new ArgumentNullException("Параметры не заданы!");
				}

				int firstIntNumber = Convert.ToInt32(firstNumber);
				int secondIntNumber = Convert.ToInt32(secondNumber);

				if (secondIntNumber == 0)
				{
					throw new ArgumentException("Делитель равен нулю!");
				}
				else { Console.WriteLine($"\nРезультат деления = {firstIntNumber / secondIntNumber}"); }
				
			}
			//Если они не заданы, то генерировать исключение ArgumentNullException
			catch (ArgumentNullException exception)
			{
				Console.WriteLine($"Возникло исключение: {exception.Message}");
			}
			//Если делитель равен нулю, то генерировать исключение ArgumentException
			catch (ArgumentException exception)
			{
				Console.WriteLine($"Возникло исключение: {exception.Message}");
			}
		}
	}
}
