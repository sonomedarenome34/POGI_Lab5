using System;
using System.Linq;
using NUnit.Framework;
using NUnit.Framework.Internal;
using static Functions.Functions;

namespace Tests
{
	public class Test
	{
		[Test]
		public void TestInchToCm(
			[Random(0, 100.0, 10)] double inches)
		{
			Assert.DoesNotThrow(() => InchToCm(inches));
			Assert.AreEqual(inches * 2.54, InchToCm(inches), 0.01);

			inches *= -1;
			Assert.Throws<ArgumentException>(() => InchToCm(inches), "Число дюймов должно быть неотрицательным.");

		}

		[Test]
		public void TestIsEven(
			[Random(-100, 100, 10)] int n)
		{
			var isEven = n % 2 == 0;
			Assert.AreEqual(isEven, IsEven(n));
		}

		[Test]
		public void TestIntArrayMax(
			[Random(1, 20, 10)] int count)
		{
			var random = Randomizer.CreateRandomizer();
			var array = Enumerable.Range(0, count).Select(s => random.Next(-100, 100)).ToArray();
			var max = array.Max();
			Assert.DoesNotThrow(() => IntArrayMax(array));
			Assert.AreEqual(max, IntArrayMax(array));

			array = null;
			Assert.Throws<ArgumentNullException>(() => IntArrayMax(array), "Массив чисел не проинициализирован.");
		}

		[Test]
		public void TestMod(
			[Random(-100, 100, 10)] int a,
			[Random(-100, 100, 10)] int b)
		{
			if (b > 0)
			{
				Assert.DoesNotThrow(() => Mod(a, b));
				Assert.AreEqual(a % b, Mod(a, b));
			}
			else 
				Assert.Throws<ArgumentException>(() => Mod(a, b), "Делитель должен быть положительным числом.");
		}

		[Test]
		public void TestMod1001()
		{
			Assert.AreEqual(Mod(1001, 10), 1);
		}

		[Test]
		public void TestModSelf()
		{
			Assert.AreEqual(Mod(1001, 1001), 0);
		}
	}
}