using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
1.	реализовать метод деления двух чисел. Внутри метода проверять входящие параметры.
Если они не заданы, то генерировать исключение ArgumentNullException.
Если делитель равен нулю, то генерировать исключение ArgumentException.
2.	Написать программу, которая обращается к элементам массива по индексу и выходит за его пределы.
После обработки исключения вывести в финальном блоке сообщение о завершении обработки массива.
*/
namespace Fifth_homework
{
	class Program
	{
		static void Main(string[] args)
		{
			//1 - DivisionException.cs
			DivisionException divide = new DivisionException();
			string firstNumber = "100";
			string secondNumber= "0";
			string thirdNumber = null;
			divide.DivisionOfNumbers(firstNumber, secondNumber);
			

			//2 - ArrayException.cs
			ArrayException arrayExcept = new ArrayException();
			arrayExcept.CheckException();



			Console.ReadKey();
		}
	}
}
