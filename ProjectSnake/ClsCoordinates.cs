
using System;

namespace ProjectSnake
{
	/// <summary>
	/// Description of ClsCoordinates.
	/// luu toa do diem snake, food
	/// </summary>
	public class ClsCoordinates
	{
		private int _X;
		private int _Y;
		public int X
		{
			get
			{
				return _X;
			}
			set
			{
				_X = value;
			}
		}
		public int Y
		{
			get
			{
				return _Y;
			}
			set
			{
				_Y = value;
			}
		}
		public ClsCoordinates()
		{
			this._X = 0;
			this._Y = 0;
		}
	}
}
