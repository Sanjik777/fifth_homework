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
	class Program
	{
		static void Main(string[] args)
		{
			MethodsException methodsExcept = new MethodsException();
			methodsExcept.FirstMethod();

			Console.ReadKey();
		}
	}
}
