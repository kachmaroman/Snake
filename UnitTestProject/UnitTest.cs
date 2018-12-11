using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Snake;

namespace UnitTestProject
{
	[TestClass]
	public class UnitTest
	{
		[TestMethod]
		public void TestIsHit()
		{
			// Arrange
			Point wasllPoint = new Point(50, 1, '-');
			Point snakePoint = new Point(50, 1, '*');

			// Action
			bool isHit = wasllPoint.IsHit(snakePoint);

			// Assert
			Assert.IsTrue(isHit);
		}

		[TestMethod]
		public void TestIsTail()
		{
			// Arrange
			Point headSnake = new Point(20, 20, '*');
			Point tailSnake = new Point(25, 20, '*');

			// Action
			bool isHit = headSnake.IsTail(tailSnake);

			// Assert
			Assert.IsTrue(isHit);
		}
	}
}
