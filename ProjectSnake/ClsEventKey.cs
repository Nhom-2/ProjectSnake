
using System;
using System.Windows.Forms;

namespace ProjectSnake
{
	/// <summary>
	/// Description of ClsEventKey.
	/// </summary>
	public class ClsEventKey : IrfDirection
	{
		private Direction getKeyCode(ClsSnake snake, ClsKeyCode key)
		{
			return Direction.NONE;
		}
		public void processEventKey(ClsSnake snake, ClsKeyCode key)
		{

		}
		public ClsEventKey()
		{
			
		}
	}
}
