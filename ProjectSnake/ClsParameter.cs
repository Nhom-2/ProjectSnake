
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectSnake
{
	/// <summary>
	/// Description of ClsParameter.
	/// luu tat ca cac gia tri thong so cho project
	/// </summary>
	public static class ClsParameter
	{
		public const string databaseServerName = ".\\Elessa";
		public const string databaseUserName = "sa";
		public const string databasePassword = "123";
		public const string databaseName = "snake";
		
		public const int MarginTop = 80; 				// pixels
		public const int MarginLeft = 40; 				// pixels
		public const int BorderSize = 20; 				// pixels
		public static Color TextColor = Color.DarkOrange;
		
		public const int SnakeMaxLengh = 200;
		public const int SnakeLenghDefault = 3;
		public const int DelayDefault = 150; 			// miliseconds
		public const int PercentBigFood = 15; 			// %
		
		public const string LinkBackground = "\\Resources\\Background";
		public const string LinkBGGame = "\\Resources\\BGGame\\";
		public const string LinkBDGame = "\\Resources\\BDGame";
		public const string LinkInit = "\\Resources\\Init";
		public const string LinkForSnake = "\\Resources\\Snake\\";
		public const string LinkForFood = "\\Resources\\Food\\";
		public const string Extension = ".png";
		
		public static ClsSnakeSize SnakeSize = new ClsSnakeSize();
		public static ClsMapSize MapSize = new ClsMapSize();
		public static ClsPublicColor BGColor = new ClsPublicColor();
		public static ClsPublicColor SFColor = new ClsPublicColor();
		
		public static ClsKeyCode PlayerKey1 = new ClsKeyCode(Keys.Up, Keys.Down, Keys.Left, Keys.Right);
		public static ClsKeyCode PlayerKey2 = new ClsKeyCode(Keys.W, Keys.S, Keys.A, Keys.D);
	}
	public static class ClsImage
	{
		public const string Up = "up";
		public const string Down = "Down";
		public const string Left = "Left";
		public const string Right = "Right";
		public const string UpRight = "UpRight";
		public const string UpLeft = "UpLeft";
		public const string DownRight = "DownRight";
		public const string DownLeft = "DownLeft";
		public const string LeftUp = "LeftUp";
		public const string LeftDown = "LeftDown";
		public const string RightUp = "RightUp";
		public const string RightDown = "RightDown";
		public const string HeadUp = "HeadUp";
		public const string HeadDown = "HeadDown";
		public const string HeadLeft = "HeadLeft";
		public const string HeadRight = "HeadRight";
		public const string TailUp = "TailUp";
		public const string TailDown = "TailDown";
		public const string TailLeft = "TailLeft";
		public const string TailRight = "TailRight";
	}
// ==================================================================
	public class ClsSnakeSize
	{
		public readonly int Small;
		public readonly int Medium;
		public ClsSnakeSize()
		{
			this.Small = 20;
			this.Medium = 40;
		}
	}
	public class ClsMapWidthHeight
	{
		public readonly int Width;
		public readonly int Height;
		public ClsMapWidthHeight(int width, int height)
		{
			this.Width = width;
			this.Height = height;
		}
	}
	public class ClsMapSize
	{
		public readonly ClsMapWidthHeight Small;
		public readonly ClsMapWidthHeight Medium;
		public readonly ClsMapWidthHeight Large;
		public ClsMapSize()
		{
			this.Small = new ClsMapWidthHeight(400, 300);
			this.Medium = new ClsMapWidthHeight(800, 600);
			this.Large = new ClsMapWidthHeight(1200, 600);
		}
	}
	public class ClsPublicColor
	{
		private const string Color0 = "Blue";
		private const string Color1 = "Brown";
		private const string Color2 = "Gray";
		private const string Color3 = "Green";	
		private const string Color4 = "Purple";
		private const string Color5 = "Red";
		private const string Color6 = "Blue2";
		private const string Color7 = "Green2";
		private const string Color8 = "Orange";
		private const string Color9 = "Pink";	
		private const string Color10 = "Special10";	
		private const string Color11 = "Special11";
		private const string Color12 = "Special12";
		private const string Color13 = "Special13";
		private const string Color14 = "Special14";
		private const string Color15 = "Special15";
		private const string Color16 = "Special16";
		private const string Color17 = "Special17";
		private const string Color18 = "Special18";
		private const string Color19 = "Special19";
		public readonly int numColorBasic;
		public readonly int numColorLarge;
		public string getColor(int color)
		{
			switch (color)
			{
				case 0:
					return Color0;
				case 1:
					return Color1;
				case 2:
					return Color2;
				case 3:
					return Color3;
				case 4:
					return Color4;
				case 5:
					return Color5;
				case 6:
					return Color6;
				case 7:
					return Color7;
				case 8:
					return Color8;
				case 9:
					return Color9;
				case 10:
					return Color10;
				case 11:
					return Color11;
				case 12:
					return Color12;
				case 13:
					return Color13;
				case 14:
					return Color14;
				case 15:
					return Color15;
				case 16:
					return Color16;
				case 17:
					return Color17;
				case 18:
					return Color18;
				case 19:
					return Color19;
				default:
					return Color0;		
			}
		}
		public ClsPublicColor()
		{
			this.numColorBasic = 5;
			this.numColorLarge = 19;
		}
	}
	public class ClsKeyCode
	{
		public readonly Keys UpCode;
		public readonly Keys DownCode;
		public readonly Keys LeftCode;
		public readonly Keys RightCode;
		public ClsKeyCode(Keys keyup, Keys keydown, Keys keyleft, Keys keyright)
		{
			this.UpCode = keyup;
			this.DownCode = keydown;
			this.LeftCode = keyleft;
			this.RightCode = keyright;
		}
		public ClsKeyCode(ClsKeyCode key)
		{
			this.UpCode = key.UpCode;
			this.DownCode = key.DownCode;
			this.LeftCode = key.LeftCode;
			this.RightCode = key.RightCode;
		}
	}
}
