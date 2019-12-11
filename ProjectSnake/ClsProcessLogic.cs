
using System;
using System.Windows.Forms;

namespace ProjectSnake
{
	/// <summary>
	/// Description of ClsProcessLogic.
	/// </summary>
	public class ClsProcessLogic
	{
		private readonly ClsProcessActive active;
		private bool collideBorder(ClsSnake snake, int width, int height)
		{
			return false;
		}
		private bool collideSnake(ClsSnake snake)
		{

			return false;
		}
		private bool collideSnake(ClsSnake snake1, ClsSnake snake2)
		{

			return false;
		}
		private bool collideFood(ClsSnake snake, ClsFood food)
		{
			return false;
		}
		public void logicBorderEnable(ClsSnake snake, ref bool increacefree, ClsFood food, int width, int height, bool ischangespeed, Timer time)
		{

		}
		public void logicBorderEnable(ClsSnake snake1, ClsSnake snake2, ref bool increacefree, ClsFood food, int width, int height, bool ischangespeed, Timer time)
		{

		}
		public void logicBorderDisable(ClsSnake snake, ref bool increacefree, ClsFood food, int width, int height, bool ischangespeed, Timer time)
		{

		}
		public void logicBorderDisable(ClsSnake snake1, ClsSnake snake2, ref bool increacefree, ClsFood food, int width, int height, bool ischangespeed, Timer time)
		{

		}
		public ClsProcessLogic()
		{
			active = new ClsProcessActive();
		}
	}
}
