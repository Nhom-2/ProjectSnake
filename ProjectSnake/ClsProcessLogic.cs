
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
			return (snake.Coor[0].X < 0 || snake.Coor[0].X > width - 1 || snake.Coor[0].Y < 0 || snake.Coor[0].Y > height - 1);
		}
		private bool collideSnake(ClsSnake snake)
		{
			for (int i = 1; i < snake.lengh; i++)
				if (snake.Coor[0].X == snake.Coor[i].X && snake.Coor[0].Y == snake.Coor[i].Y)
					return true;
			return false;
		}
		private bool collideSnake(ClsSnake snake1, ClsSnake snake2)
		{
			for (int i = 0; i < snake2.lengh; i++)
				if (snake1.Coor[0].X == snake2.Coor[i].X && snake1.Coor[0].Y == snake2.Coor[i].Y)
					return true;
			return false;
		}
		private bool collideFood(ClsSnake snake, ClsFood food)
		{
			return (food.Coor.X == snake.Coor[0].X && food.Coor.Y == snake.Coor[0].Y);
		}
		public void logicBorderEnable(ClsSnake snake, ref bool increacefree, ClsFood food, int width, int height, bool ischangespeed, Timer time)
		{
			if (increacefree)
				active.afterConlideBigFood(snake, ref increacefree, food, width, height);
			else if (this.collideFood(snake, food))
				active.afterCollideFood(snake, ref increacefree, food, width, height, ischangespeed, time);	
			if (this.collideSnake(snake) || this.collideBorder(snake, width, height))
				active.afterCollideSnakeOrBorder(snake);
			else
				snake.moveSnake();
		}
		public void logicBorderEnable(ClsSnake snake1, ClsSnake snake2, ref bool increacefree, ClsFood food, int width, int height, bool ischangespeed, Timer time)
		{
			if (increacefree)
				active.afterConlideBigFood(snake1, snake2, ref increacefree, food, width, height);
			else if (this.collideFood(snake1, food))
				active.afterCollideFood(snake1, snake2, ref increacefree, food, width, height, ischangespeed, time);	
			if (this.collideSnake(snake1) || this.collideSnake(snake1, snake2) || this.collideBorder(snake1, width, height))
				active.afterCollideSnakeOrBorder(snake1);
			else
				snake1.moveSnake();
		}
		public void logicBorderDisable(ClsSnake snake, ref bool increacefree, ClsFood food, int width, int height, bool ischangespeed, Timer time)
		{
			if (increacefree)
				active.afterConlideBigFood(snake, ref increacefree, food, width, height);
			else if (this.collideFood(snake, food))
				active.afterCollideFood(snake, ref increacefree, food, width, height, ischangespeed, time);
			if (this.collideSnake(snake))
				active.afterCollideSnake(snake);
			else if (this.collideBorder(snake, width, height))
				active.afterCollideBorder(snake, width, height);
			else 
				snake.moveSnake();
		}
		public void logicBorderDisable(ClsSnake snake1, ClsSnake snake2, ref bool increacefree, ClsFood food, int width, int height, bool ischangespeed, Timer time)
		{
			if (increacefree)
				active.afterConlideBigFood(snake1, snake2, ref increacefree, food, width, height);
			else if (this.collideFood(snake1, food))
				active.afterCollideFood(snake1, snake2, ref increacefree, food, width, height, ischangespeed, time);
			if (this.collideSnake(snake1) || this.collideSnake(snake1, snake2))
				active.afterCollideSnake(snake1);
			else if (this.collideBorder(snake1, width, height))
				active.afterCollideBorder(snake1, width, height);
			else
				snake1.moveSnake();
		}
		public ClsProcessLogic()
		{
			active = new ClsProcessActive();
		}
	}
}
