using System;
using System.Linq;

namespace Functions
{
	public static class Functions
	{
		public static double InchToCm(double inches)
		{
			if (inches < 0) throw new ArgumentException("Число дюймов должно быть неотрицательным.");
			return inches * 2.54;
		}

		public static bool IsEven(int n) => n % 2 == 0;

		public static int IntArrayMax(int[] array)
		{
			if (array == null) throw new ArgumentNullException("Массив чисел не проинициализирован.");
			return array.Max();
		}

		public static int Mod(int a, int b)
		{
			if (b <= 0) throw new ArgumentException("Делитель должен быть положительным числом.");
			return a % b;
		}
	}
}
