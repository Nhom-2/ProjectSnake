
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectSnake
{
	/// <summary>
	/// Description of ClsSnake.
	/// doi tuong snake
	/// </summary>
	public class ClsSnake : IrfDirection
	{
		private readonly int MapSizeWidth;
		private readonly int MapSizeHeight;
		public int lengh;
		public int Size;
		public ClsCoordinates[] Coor;
		private Bitmap[] Shape;
		public Direction Direct;
		public bool Status;
		private readonly string Link;
		private void initSnake(int locate)
		{

		}
		public void updateCorner(Direction direct)
		{
				
		}
		public void moveSnake()
		{
			
		}
		public void drawSnake(PaintEventArgs e)
		{
			
		}
		public void transformSnake(int width, int height)
		{
			
		}
		public ClsSnake(int lengh, int size, string color, int locate, int width, int height)
		{
			this.lengh = lengh;
			this.Size = size;
			this.Coor = new ClsCoordinates[ClsParameter.SnakeMaxLengh];
			this.Shape = new Bitmap[ClsParameter.SnakeMaxLengh];
			this.Link = String.Concat(ClsParameter.LinkForSnake, color, "\\");
			this.MapSizeWidth = width;
			this.MapSizeHeight = height;
			for (int i = 0; i < ClsParameter.SnakeMaxLengh; i++)
			{
				this.Coor[i] = new ClsCoordinates();
				this.Shape[i] = new Bitmap(Application.StartupPath + ClsParameter.LinkInit + ClsParameter.Extension);
			}
			this.initSnake(locate);
		}
	}
}
