
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectSnake
{
	/// <summary>
	/// Description of ClsFood.
	/// doi tuong food
	/// </summary>
	public class ClsFood
	{
		private readonly string Link;
		private ClsCoordinates _Coor;
		public bool isBigFood;
		public ClsCoordinates Coor
		{
			get
			{
				return _Coor;
			}
			set
			{
				_Coor = value;
			}
		}
		public void generateFood(ClsSnake snake, int width, int height) 
		{
			Random random = new Random();
			this.isBigFood = (random.Next(0, 100) < ClsParameter.PercentBigFood);
			bool check;
			do 
			{
				this._Coor.X = random.Next(0, width / snake.Size) * snake.Size;
				this._Coor.Y = random.Next(0, height / snake.Size) * snake.Size;
				check = true;
				for (int i = 0; i < snake.lengh; i++)
					if (snake.Coor[i].X == this._Coor.X && snake.Coor[i].Y == this._Coor.Y)
					{
						check = false;
						break;
					}
			} 
			while (check == false); // check duplication
		}
		public void generateFood(ClsSnake snake1, ClsSnake snake2, int width, int height) 
		{
			Random random = new Random();
			this.isBigFood = (random.Next(0, 100) < ClsParameter.PercentBigFood);
			bool check;
			do 
			{
				this._Coor.X = random.Next(0, width / snake1.Size) * snake1.Size;
				this._Coor.Y = random.Next(0, height / snake1.Size) * snake1.Size;
				check = true;
				for (int i = 0; i < snake1.lengh; i++)
					if (snake1.Coor[i].X == this._Coor.X && snake1.Coor[i].Y == this._Coor.Y)
					{
						check = false;
						break;
					}
				for (int i = 0; i < snake2.lengh; i++)
					if (snake2.Coor[i].X == this._Coor.X && snake2.Coor[i].Y == this._Coor.Y)
					{
						check = false;
						break;
					}
			} 
			while (check == false); // check duplication
		}
		public void drawFood(PaintEventArgs e, int size)
		{
			Graphics graphic = e.Graphics;
			if (this.isBigFood)
				graphic.DrawImage(new Bitmap(Application.StartupPath + string.Concat(this.Link, "Big", ClsParameter.Extension)), this.Coor.X, this.Coor.Y, size, size);
			else
				graphic.DrawImage(new Bitmap(Application.StartupPath + string.Concat(this.Link, ClsParameter.Extension)), this.Coor.X, this.Coor.Y, size, size);
		}
		public ClsFood(string color)
		{
			this._Coor = new ClsCoordinates();
			this.Link = ClsParameter.LinkForFood + color;
		}
	}
}
