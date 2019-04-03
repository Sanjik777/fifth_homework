using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 1.	Реализовать несколько методов или классов с методами и вызвать один метод из другого.
 В вызываемом методе сгенерировать исключение и «поднять» его в вызывающий метод.
*/
namespace Practical_work
{
	public class MethodsException
	{
		public void FirstMethod()
		{
			try
			{
				SecondMethod();
			}
			catch (Exception exception)
			{
				Console.WriteLine($"Выхвано исключение: {exception.Message}");
			}
		}

		public void SecondMethod()
		{
			string text = "asd";
			if (text == "asd") { throw new Exception(); }
		}
	}
}
