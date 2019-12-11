
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectSnake
{
	/// <summary>
	/// Description of FrmOption.
	/// form option
	/// </summary>
	public partial class FrmOption : Form
	{
		public bool isSingle; 				// true neu la 1 nguoi choi, false là 2 nguoi choi
		public ClsMapWidthHeight mapSize; 	// tra ve ClsParameter.MapSize.Small, ClsParameter.MapSize.Medium, ClsParameter.MapSize.Large
		public bool hasBorder; 				// true neu co vien, false neu ko co vien
		public string BGcolor; 				// tra ve ClsParameter.SFColor.getColor(-mot-con-so-); 1 so tuong ung 1 hinh

		public int snakeLengh; 				// ko can thay doi
		public int snakeSize; 				// trả ve ClsParameter.SnakeSize.Small, ClsParameter.SnakeSize.Medium
		public string snakeColor1; 			// tra ve ClsParameter.SFColor.getColor(-mot-con-so-);
		public string snakeColor2; 			// tra ve ClsParameter.SFColor.getColor(-mot-con-so-);
		public string foodColor; 			// tra ve ClsParameter.SFColor.getColor(-mot-con-so-);

		public ClsKeyCode playerKey1; 		// tra ve ClsParameter.PlayerKey1
		public ClsKeyCode playerKey2; 		// tra ve ClsParameter.PlayerKey2

		public bool isSpeedup; 				// true neu co thay doi toc do

		private int BGcolor_Option;
		private int snakeColor1_Option;
		private int snakeColor2_Option;
		private int foodColor_Option;
		
		public FrmOption()
		{
			InitializeComponent();
			
			this.BGcolor_Option = 14;
			this.snakeColor1_Option = 3;
			this.snakeColor2_Option = 0;
			this.foodColor_Option = 5;
			
			this.BackgroundImage = new Bitmap(Application.StartupPath + ClsParameter.LinkBackground + ClsParameter.Extension);
			this.BackgroundImageLayout = ImageLayout.Stretch;
			this.pictureBoxMapColor.BackgroundImageLayout = ImageLayout.Stretch;
			this.pictureBoxPlayerColor1.BackgroundImageLayout = ImageLayout.Stretch;
			this.pictureBoxPlayerColor2.BackgroundImageLayout = ImageLayout.Stretch;
			this.pictureBoxFoodColor.BackgroundImageLayout = ImageLayout.Stretch;
			
			this.isSingle = true;
			this.mapSize = ClsParameter.MapSize.Medium;
			this.hasBorder = false;
			this.BGcolor = ClsParameter.SFColor.getColor(14);
			
			this.snakeLengh = ClsParameter.SnakeLenghDefault;
			this.snakeSize = ClsParameter.SnakeSize.Medium;
			this.snakeColor1 = ClsParameter.SFColor.getColor(3);
			this.snakeColor2 = ClsParameter.SFColor.getColor(4);
			this.foodColor = ClsParameter.SFColor.getColor(3);
			
			this.playerKey1 = ClsParameter.PlayerKey1;
			this.playerKey2 = ClsParameter.PlayerKey2;
			
			this.isSpeedup = false;

			this.display();
		}
		private void display()
		{
			this.rdbtMapSizeSmall.Checked = (this.mapSize == ClsParameter.MapSize.Small);
			this.rdbtMapSizeMedium.Checked = (this.mapSize == ClsParameter.MapSize.Medium);
			this.rdbtMapSizeLarge.Checked = (this.mapSize == ClsParameter.MapSize.Large);
			this.checkBoxMapOptionBorder.Checked = this.hasBorder;
			this.checkBoxMapOptionSpeedup.Checked = this.isSpeedup;
			this.rdbtSnakeSizeSmall.Checked = (this.snakeSize == ClsParameter.SnakeSize.Small);
			this.rdbtSnakeSizeMedium.Checked = (this.snakeSize == ClsParameter.SnakeSize.Medium);
			this.rdbtSnakeStylePlayer1.Checked = (this.isSingle);
			this.rdbtSnakeStylePlayer2.Checked = (!this.isSingle);
			this.panelSnakePlayer2.Enabled = !this.isSingle;

			this.pictureBoxMapColor.BackgroundImage = new Bitmap(Application.StartupPath + ClsParameter.LinkBGGame + ClsParameter.BGColor.getColor(this.BGcolor_Option) + ClsParameter.Extension);
			this.pictureBoxPlayerColor1.BackgroundImage = new Bitmap(Application.StartupPath + ClsParameter.LinkForSnake + ClsParameter.SFColor.getColor(this.snakeColor1_Option) + "\\left" + ClsParameter.Extension);
			this.pictureBoxPlayerColor2.BackgroundImage = new Bitmap(Application.StartupPath + ClsParameter.LinkForSnake + ClsParameter.SFColor.getColor(this.snakeColor2_Option) + "\\left" + ClsParameter.Extension);
			this.pictureBoxFoodColor.BackgroundImage = new Bitmap(Application.StartupPath + ClsParameter.LinkForFood + ClsParameter.SFColor.getColor(this.foodColor_Option) + ClsParameter.Extension);	
		}
		private void saveOption()
		{
			this.isSingle = this.rdbtSnakeStylePlayer1.Checked;
			this.mapSize = (this.rdbtMapSizeSmall.Checked) ? ClsParameter.MapSize.Small : 
				((this.rdbtMapSizeMedium.Checked) ? ClsParameter.MapSize.Medium : ClsParameter.MapSize.Large);
			this.hasBorder = this.checkBoxMapOptionBorder.Checked;
			this.BGcolor = ClsParameter.BGColor.getColor(this.BGcolor_Option);
			
			this.snakeSize = (this.rdbtSnakeSizeSmall.Checked) ? ClsParameter.SnakeSize.Small : ClsParameter.SnakeSize.Medium;
			this.snakeColor1 = ClsParameter.SFColor.getColor(this.snakeColor1_Option);
			this.snakeColor2 = ClsParameter.SFColor.getColor(this.snakeColor2_Option);
			this.foodColor = ClsParameter.SFColor.getColor(this.foodColor_Option);

			this.isSpeedup = this.checkBoxMapOptionSpeedup.Checked;
		}
		void BtOKClick(object sender, EventArgs e)
		{
			this.saveOption();
			this.Hide();
		}
		void BtCancelClick(object sender, EventArgs e)
		{		
			this.display();
			this.Hide();
		}
		void RdbtMapSizeSmallCheckedChanged(object sender, EventArgs e)
		{
			this.rdbtSnakeSizeSmall.Checked = true;
			this.lbSnakeSizeMedium.Enabled = false;
			this.rdbtSnakeSizeMedium.Enabled = false;
		}
		void RdbtMapSizeMediumCheckedChanged(object sender, EventArgs e)
		{
			this.lbSnakeSizeMedium.Enabled = true;
			this.rdbtSnakeSizeMedium.Enabled = true;
		}
		void RdbtMapSizeLargeCheckedChanged(object sender, EventArgs e)
		{
			this.lbSnakeSizeMedium.Enabled = true;
			this.rdbtSnakeSizeMedium.Enabled = true;
		}
		void CheckBoxMapOptionBorderCheckedChanged(object sender, EventArgs e)
		{

		}
		void CheckBoxMapOptionSpeedupCheckedChanged(object sender, EventArgs e)
		{
			
		}
		void RdbtSnakeStylePlayer1CheckedChanged(object sender, EventArgs e)
		{
			this.panelSnakePlayer2.Enabled = false;
		}
		void RdbtSnakeStylePlayer2CheckedChanged(object sender, EventArgs e)
		{
			this.panelSnakePlayer2.Enabled = true;
		}
		void FrmOptionFormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			this.saveOption();
			this.Hide();
		}
		void BtMapColorNextClick(object sender, EventArgs e)
		{
			this.BGcolor_Option += (this.BGcolor_Option < ClsParameter.BGColor.numColorLarge) ? 1 : -ClsParameter.BGColor.numColorLarge;
			this.pictureBoxMapColor.BackgroundImage = new Bitmap(Application.StartupPath + ClsParameter.LinkBGGame + ClsParameter.BGColor.getColor(this.BGcolor_Option) + ClsParameter.Extension);
		}
		void BtMapColorPrevClick(object sender, EventArgs e)
		{
			this.BGcolor_Option -= (this.BGcolor_Option > 0) ? 1 : -ClsParameter.BGColor.numColorLarge;
			this.pictureBoxMapColor.BackgroundImage = new Bitmap(Application.StartupPath + ClsParameter.LinkBGGame + ClsParameter.BGColor.getColor(this.BGcolor_Option) + ClsParameter.Extension);
		}
		void BtPlayerPrev1Click(object sender, EventArgs e)
		{
			this.snakeColor1_Option -= (this.snakeColor1_Option > 0) ? 1 : -ClsParameter.SFColor.numColorBasic;
			this.pictureBoxPlayerColor1.BackgroundImage = new Bitmap(Application.StartupPath + ClsParameter.LinkForSnake + ClsParameter.SFColor.getColor(this.snakeColor1_Option) + "\\left" + ClsParameter.Extension);
		}
		void BtPlayerNext1Click(object sender, EventArgs e)
		{
			this.snakeColor1_Option += (this.snakeColor1_Option < ClsParameter.SFColor.numColorBasic) ? 1 : -ClsParameter.BGColor.numColorBasic;
			this.pictureBoxPlayerColor1.BackgroundImage = new Bitmap(Application.StartupPath + ClsParameter.LinkForSnake + ClsParameter.SFColor.getColor(this.snakeColor1_Option) + "\\left" + ClsParameter.Extension);
		}
		void BtPlayerPrev2Click(object sender, EventArgs e)
		{
			this.snakeColor2_Option -= (this.snakeColor2_Option > 0) ? 1 : -ClsParameter.SFColor.numColorBasic;
			this.pictureBoxPlayerColor2.BackgroundImage = new Bitmap(Application.StartupPath + ClsParameter.LinkForSnake + ClsParameter.SFColor.getColor(this.snakeColor2_Option) + "\\left" + ClsParameter.Extension);
		}
		void BtPlayerNext2Click(object sender, EventArgs e)
		{
			this.snakeColor2_Option += (this.snakeColor2_Option < ClsParameter.SFColor.numColorBasic) ? 1 : -ClsParameter.BGColor.numColorBasic;
			this.pictureBoxPlayerColor2.BackgroundImage = new Bitmap(Application.StartupPath + ClsParameter.LinkForSnake + ClsParameter.SFColor.getColor(this.snakeColor2_Option) + "\\left" + ClsParameter.Extension);
		}
		void BtFoodPrevClick(object sender, EventArgs e)
		{
			this.foodColor_Option -= (this.foodColor_Option > 0) ? 1 : -ClsParameter.SFColor.numColorBasic;
			this.pictureBoxFoodColor.BackgroundImage = new Bitmap(Application.StartupPath + ClsParameter.LinkForFood + ClsParameter.SFColor.getColor(this.foodColor_Option) + ClsParameter.Extension);
		}
		void BtFoodNextClick(object sender, EventArgs e)
		{
			this.foodColor_Option += (this.foodColor_Option < ClsParameter.SFColor.numColorBasic) ? 1 : -ClsParameter.BGColor.numColorBasic;
			this.pictureBoxFoodColor.BackgroundImage = new Bitmap(Application.StartupPath + ClsParameter.LinkForFood + ClsParameter.SFColor.getColor(this.foodColor_Option) + ClsParameter.Extension);
		}
	}
}
