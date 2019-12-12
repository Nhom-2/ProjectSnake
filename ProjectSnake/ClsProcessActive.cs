
using System;
using System.Windows.Forms;

namespace ProjectSnake
{
	/// <summary>
	/// Description of ClsProcessEvent.
	/// </summary>
	public class ClsProcessActive// : IrfDirection
	{
		private void changeSpeed(Timer time)
		{
			time.Interval -= (time.Interval > 99) ? 15 : 
			((time.Interval > 50) ? 12 : 
			 ((time.Interval > 30) ? 8 :
			  ((time.Interval > 1) ? 5 : 0)));	
		}
		public void afterPressKey(ClsSnake snake, Direction direction)
		{
			snake.updateCorner(direction);
		}
		public void afterConlideBigFood(ClsSnake snake, ref bool increacefree, ClsFood food, int width, int height)
		{
			increacefree = false;
			snake.lengh++;
			food.generateFood(snake, width, height);
		}
		public void afterConlideBigFood(ClsSnake snake1, ClsSnake snake2, ref bool increacefree, ClsFood food, int width, int height)
		{
			increacefree = false;
			snake1.lengh++;
			food.generateFood(snake1, snake2, width, height);
		}
		public void afterCollideFood(ClsSnake snake, ref bool increacefree, ClsFood food, int width, int height, bool ischangespeed, Timer time)
		{
			snake.lengh++;
			if (food.isBigFood)
				increacefree = true;
			else
				food.generateFood(snake, width, height);
			if (ischangespeed)
				this.changeSpeed(time);
		}
		public void afterCollideFood(ClsSnake snake1, ClsSnake snake2, ref bool increacefree, ClsFood food, int width, int height, bool ischangespeed, Timer time)
		{
			snake1.lengh++;
			if (food.isBigFood)
				increacefree = true;
			else
				food.generateFood(snake1, snake2, width, height);
			if (ischangespeed)
				this.changeSpeed(time);
		}
		public void afterCollideSnake(ClsSnake snake)
		{
			snake.Status = false;
		}
		public void afterCollideBorder(ClsSnake snake, int width, int height)
		{
			snake.transformSnake(width, height);
		}
		public void afterCollideSnakeOrBorder(ClsSnake snake)
		{
			snake.Status = false;
		}
		public ClsProcessActive()
		{
		}
	}
}
