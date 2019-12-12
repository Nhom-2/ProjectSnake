
using System;
using System.Windows.Forms;

namespace ProjectSnake
{
	/// <summary>
	/// Description of ClsEventKey.
	/// </summary>
	public class ClsEventKey
	{
		private Direction getKeyCode(ClsSnake snake, ClsKeyCode key)
		{
			if (ClsInput.KeyPressed(key.UpCode) && snake.Direct != Direction.UP && snake.Direct != Direction.DOWN)
				return Direction.UP;
			if (ClsInput.KeyPressed(key.DownCode) && snake.Direct != Direction.UP && snake.Direct != Direction.DOWN)
				return Direction.DOWN;
			if (ClsInput.KeyPressed(key.LeftCode) && snake.Direct != Direction.LEFT && snake.Direct != Direction.RIGHT)
				return Direction.LEFT;
			if (ClsInput.KeyPressed(key.RightCode) && snake.Direct != Direction.LEFT && snake.Direct != Direction.RIGHT)
				return Direction.RIGHT;
			return Direction.NONE;
		}
		public void processEventKey(ClsSnake snake, ClsKeyCode key)
		{
			Direction direction = this.getKeyCode(snake, key);
			if (direction == Direction.NONE)
				return;
			snake.updateCorner(direction);
		}
		public ClsEventKey()
		{
		}
	}
}
