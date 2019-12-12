
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectSnake
{
	/// <summary>
	/// Description of ClsSnake.
	/// doi tuong snake
	/// </summary>
	public enum Direction
	{
		PAUSE, RESUME, UP, DOWN, LEFT, RIGHT, NONE
	}
	public class ClsSnake
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
			this.Direct = Direction.RIGHT;
			for (int i = 0; i < this.lengh; i++)
			{
				this.Coor[i].X = (this.lengh - i - 1) * this.Size;
				this.Coor[i].Y = (this.MapSizeHeight / this.Size / 4 * locate) * this.Size; // can set lai theo param khung hinh
				this.Shape[i] = new Bitmap(Application.StartupPath + this.Link + ClsImage.Right + ClsParameter.Extension);
			}
			this.Status = true;
		}
		public void updateCorner(Direction direct)
		{
			switch (direct)
			{
				case Direction.UP:
				{
					this.Shape[0] = this.Direct == Direction.RIGHT ? 
						new Bitmap(Application.StartupPath + this.Link + ClsImage.LeftUp + ClsParameter.Extension) : 
						new Bitmap(Application.StartupPath + this.Link + ClsImage.RightUp + ClsParameter.Extension);
					this.Direct = Direction.UP;
					return;
				}
				case Direction.DOWN:
				{
					this.Shape[0] = this.Direct == Direction.RIGHT ? 
						new Bitmap(Application.StartupPath + this.Link + ClsImage.LeftDown + ClsParameter.Extension) : 
						new Bitmap(Application.StartupPath + this.Link + ClsImage.RightDown + ClsParameter.Extension);
					this.Direct = Direction.DOWN;
					return;
				}
				case Direction.LEFT:
				{
					this.Shape[0] = this.Direct == Direction.UP ? 
						new Bitmap(Application.StartupPath + this.Link + ClsImage.DownLeft + ClsParameter.Extension) : 
						new Bitmap(Application.StartupPath + this.Link + ClsImage.UpLeft + ClsParameter.Extension);
					this.Direct = Direction.LEFT;
					return;
				}
				case Direction.RIGHT:
				{
					this.Shape[0] = this.Direct == Direction.UP ? 
						new Bitmap(Application.StartupPath + this.Link + ClsImage.DownRight + ClsParameter.Extension) : 
						new Bitmap(Application.StartupPath + this.Link + ClsImage.UpRight + ClsParameter.Extension);
					this.Direct = Direction.RIGHT;
					return;
				}
			}
		}
		public void moveSnake()
		{
			for (int i = this.lengh; i > 0; i--)
			{
				this.Shape[i] = this.Shape[i - 1];
				this.Coor[i].X = this.Coor[i - 1].X;
				this.Coor[i].Y = this.Coor[i - 1].Y;
			}
			switch (this.Direct) // update the head's direction
			{
				case Direction.UP:
				{
					this.Coor[0].Y -= this.Size;
					this.Shape[0] = new Bitmap(Application.StartupPath + this.Link + ClsImage.Up + ClsParameter.Extension);
					return;
				}
				case Direction.DOWN:
				{
					this.Coor[0].Y += this.Size;
					this.Shape[0] = new Bitmap(Application.StartupPath + this.Link + ClsImage.Down + ClsParameter.Extension);
					return;
				}
				case Direction.LEFT:
				{
					this.Coor[0].X -= this.Size;
					this.Shape[0] = new Bitmap(Application.StartupPath + this.Link + ClsImage.Left + ClsParameter.Extension);
					return;
				}
				case Direction.RIGHT:
				{
					this.Coor[0].X += this.Size;
					this.Shape[0] = new Bitmap(Application.StartupPath + this.Link + ClsImage.Right + ClsParameter.Extension);
					return;
				}
			}
		}
		public void drawSnake(PaintEventArgs e)
		{
			Graphics graphic = e.Graphics;
			for (int i = 1; i < this.lengh - 1; i++)
			{
				graphic.DrawImage(this.Shape[i], this.Coor[i].X, this.Coor[i].Y, this.Size, this.Size);	
			}
			// draw tail
			graphic.DrawImage(new Bitmap(Application.StartupPath + this.Link + 
								(
									((this.Coor[this.lengh - 1].X > this.Coor[this.lengh - 2].X) &&
									(this.Coor[this.lengh - 1].X - this.Coor[this.lengh - 2].X) == this.Size) ? ClsImage.TailLeft :
									(((this.Coor[this.lengh - 1].X > this.Coor[this.lengh - 2].X) &&
									(this.Coor[this.lengh - 1].X - this.Coor[this.lengh - 2].X) > this.Size) ? ClsImage.TailRight :
									
									(((this.Coor[this.lengh - 1].X < this.Coor[this.lengh - 2].X) &&
									(this.Coor[this.lengh - 2].X - this.Coor[this.lengh - 1].X) == this.Size) ? ClsImage.TailRight :
									(((this.Coor[this.lengh - 1].X < this.Coor[this.lengh - 2].X) &&
									(this.Coor[this.lengh - 2].X - this.Coor[this.lengh - 1].X) > this.Size) ? ClsImage.TailLeft :
									
									(((this.Coor[this.lengh - 1].Y > this.Coor[this.lengh - 2].Y) &&
									(this.Coor[this.lengh - 1].Y - this.Coor[this.lengh - 2].Y) == this.Size) ? ClsImage.TailUp :
									(((this.Coor[this.lengh - 1].Y > this.Coor[this.lengh - 2].Y) &&
									(this.Coor[this.lengh - 1].Y - this.Coor[this.lengh - 2].Y) > this.Size) ? ClsImage.TailDown :
									
									(((this.Coor[this.lengh - 1].Y < this.Coor[this.lengh - 2].Y) &&
									(this.Coor[this.lengh - 2].Y - this.Coor[this.lengh - 1].Y) == this.Size) ? ClsImage.TailDown :
									
									(ClsImage.TailUp)))))))
								) + ClsParameter.Extension),
								this.Coor[this.lengh - 1].X, this.Coor[this.lengh - 1].Y, this.Size, this.Size);
			// draw head
			graphic.DrawImage(new Bitmap(Application.StartupPath + this.Link + (this.Direct == Direction.UP ? ClsImage.HeadUp :
								(this.Direct == Direction.DOWN ? ClsImage.HeadDown : 
								(this.Direct == Direction.LEFT ? ClsImage.HeadLeft : 
								ClsImage.HeadRight))) + ClsParameter.Extension),
								this.Coor[0].X, this.Coor[0].Y, this.Size, this.Size);
		}
		public void transformSnake(int width, int height)
		{
			if (this.Coor[0].X == -this.Size)
				this.Coor[0].X = width - this.Size;
			else if (this.Coor[0].X == width)
				this.Coor[0].X = 0;
			else if (this.Coor[0].Y == -this.Size)
				this.Coor[0].Y = height - this.Size;
			else if (this.Coor[0].Y == height)
				this.Coor[0].Y = 0;
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
