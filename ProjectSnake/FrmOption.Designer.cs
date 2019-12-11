/*
 * Created by SharpDevelop.
 * User: thinh
 * Date: 09/12/2019
 * Time: 8:41 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProjectSnake
{
	partial class FrmOption
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panelMap;
		private System.Windows.Forms.Panel panelMapSize;
		private System.Windows.Forms.RadioButton rdbtMapSizeLarge;
		private System.Windows.Forms.RadioButton rdbtMapSizeMedium;
		private System.Windows.Forms.RadioButton rdbtMapSizeSmall;
		private System.Windows.Forms.Label lbMapSizeLarge;
		private System.Windows.Forms.Label lbMapSizeMedium;
		private System.Windows.Forms.Label lbMapSizeSmall;
		private System.Windows.Forms.Label lbMapSize;
		private System.Windows.Forms.Label lbMap;
		private System.Windows.Forms.Button btCancel;
		private System.Windows.Forms.Button btOK;
		private System.Windows.Forms.Panel panelMapOption;
		private System.Windows.Forms.CheckBox checkBoxMapOptionSpeedup;
		private System.Windows.Forms.CheckBox checkBoxMapOptionBorder;
		private System.Windows.Forms.Label lbMapSpeedup;
		private System.Windows.Forms.Label lbMapBorder;
		private System.Windows.Forms.Label lbMapOption;
		private System.Windows.Forms.Button btMapColorPrev;
		private System.Windows.Forms.Button btMapColorNext;
		private System.Windows.Forms.PictureBox pictureBoxMapColor;
		private System.Windows.Forms.Label lbMapColor;
		private System.Windows.Forms.Panel panelSnake;
		private System.Windows.Forms.Panel panelSnakeStyle;
		private System.Windows.Forms.RadioButton rdbtSnakeStylePlayer2;
		private System.Windows.Forms.Label lbSnakePlayer2;
		private System.Windows.Forms.RadioButton rdbtSnakeStylePlayer1;
		private System.Windows.Forms.Label lbSnakePlayer1;
		private System.Windows.Forms.Label lbSnakeStyle;
		private System.Windows.Forms.Panel panelSnakeSize;
		private System.Windows.Forms.RadioButton rdbtSnakeSizeMedium;
		private System.Windows.Forms.RadioButton rdbtSnakeSizeSmall;
		private System.Windows.Forms.Label lbSnakeSizeMedium;
		private System.Windows.Forms.Label lbSnakeSizeSmall;
		private System.Windows.Forms.Label lbSnakeSize;
		private System.Windows.Forms.Label lbSnake;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panelSnakePlayer1;
		private System.Windows.Forms.PictureBox pictureBoxPlayerColor1;
		private System.Windows.Forms.Button btPlayerPrev1;
		private System.Windows.Forms.Button btPlayerNext1;
		private System.Windows.Forms.Label lbPlayerColor1;
		private System.Windows.Forms.Label lbPlayer1;
		private System.Windows.Forms.Label lbFood;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pictureBoxFoodColor;
		private System.Windows.Forms.Button btFoodPrev;
		private System.Windows.Forms.Button btFoodNext;
		private System.Windows.Forms.Label lbFoodColor;
		private System.Windows.Forms.Panel panelSnakePlayer2;
		private System.Windows.Forms.PictureBox pictureBoxPlayerColor2;
		private System.Windows.Forms.Button btPlayerPrev2;
		private System.Windows.Forms.Button btPlayerNext2;
		private System.Windows.Forms.Label lbPlayerColor2;
		private System.Windows.Forms.Label lbPlayer2;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.panelMap = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lbMapColor = new System.Windows.Forms.Label();
			this.btMapColorPrev = new System.Windows.Forms.Button();
			this.pictureBoxMapColor = new System.Windows.Forms.PictureBox();
			this.btMapColorNext = new System.Windows.Forms.Button();
			this.panelMapOption = new System.Windows.Forms.Panel();
			this.checkBoxMapOptionSpeedup = new System.Windows.Forms.CheckBox();
			this.checkBoxMapOptionBorder = new System.Windows.Forms.CheckBox();
			this.lbMapSpeedup = new System.Windows.Forms.Label();
			this.lbMapBorder = new System.Windows.Forms.Label();
			this.lbMapOption = new System.Windows.Forms.Label();
			this.panelMapSize = new System.Windows.Forms.Panel();
			this.rdbtMapSizeLarge = new System.Windows.Forms.RadioButton();
			this.rdbtMapSizeMedium = new System.Windows.Forms.RadioButton();
			this.rdbtMapSizeSmall = new System.Windows.Forms.RadioButton();
			this.lbMapSizeLarge = new System.Windows.Forms.Label();
			this.lbMapSizeMedium = new System.Windows.Forms.Label();
			this.lbMapSizeSmall = new System.Windows.Forms.Label();
			this.lbMapSize = new System.Windows.Forms.Label();
			this.lbMap = new System.Windows.Forms.Label();
			this.btCancel = new System.Windows.Forms.Button();
			this.btOK = new System.Windows.Forms.Button();
			this.panelSnake = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pictureBoxFoodColor = new System.Windows.Forms.PictureBox();
			this.btFoodPrev = new System.Windows.Forms.Button();
			this.btFoodNext = new System.Windows.Forms.Button();
			this.lbFoodColor = new System.Windows.Forms.Label();
			this.panelSnakePlayer2 = new System.Windows.Forms.Panel();
			this.pictureBoxPlayerColor2 = new System.Windows.Forms.PictureBox();
			this.btPlayerPrev2 = new System.Windows.Forms.Button();
			this.btPlayerNext2 = new System.Windows.Forms.Button();
			this.lbPlayerColor2 = new System.Windows.Forms.Label();
			this.lbPlayer2 = new System.Windows.Forms.Label();
			this.lbFood = new System.Windows.Forms.Label();
			this.panelSnakePlayer1 = new System.Windows.Forms.Panel();
			this.pictureBoxPlayerColor1 = new System.Windows.Forms.PictureBox();
			this.btPlayerPrev1 = new System.Windows.Forms.Button();
			this.btPlayerNext1 = new System.Windows.Forms.Button();
			this.lbPlayerColor1 = new System.Windows.Forms.Label();
			this.lbPlayer1 = new System.Windows.Forms.Label();
			this.panelSnakeStyle = new System.Windows.Forms.Panel();
			this.rdbtSnakeStylePlayer2 = new System.Windows.Forms.RadioButton();
			this.lbSnakePlayer2 = new System.Windows.Forms.Label();
			this.rdbtSnakeStylePlayer1 = new System.Windows.Forms.RadioButton();
			this.lbSnakePlayer1 = new System.Windows.Forms.Label();
			this.lbSnakeStyle = new System.Windows.Forms.Label();
			this.panelSnakeSize = new System.Windows.Forms.Panel();
			this.rdbtSnakeSizeMedium = new System.Windows.Forms.RadioButton();
			this.rdbtSnakeSizeSmall = new System.Windows.Forms.RadioButton();
			this.lbSnakeSizeMedium = new System.Windows.Forms.Label();
			this.lbSnakeSizeSmall = new System.Windows.Forms.Label();
			this.lbSnakeSize = new System.Windows.Forms.Label();
			this.lbSnake = new System.Windows.Forms.Label();
			this.panelMap.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxMapColor)).BeginInit();
			this.panelMapOption.SuspendLayout();
			this.panelMapSize.SuspendLayout();
			this.panelSnake.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoodColor)).BeginInit();
			this.panelSnakePlayer2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayerColor2)).BeginInit();
			this.panelSnakePlayer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayerColor1)).BeginInit();
			this.panelSnakeStyle.SuspendLayout();
			this.panelSnakeSize.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelMap
			// 
			this.panelMap.BackColor = System.Drawing.Color.Lavender;
			this.panelMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelMap.Controls.Add(this.panel1);
			this.panelMap.Controls.Add(this.panelMapOption);
			this.panelMap.Controls.Add(this.panelMapSize);
			this.panelMap.Controls.Add(this.lbMap);
			this.panelMap.Location = new System.Drawing.Point(12, 12);
			this.panelMap.Name = "panelMap";
			this.panelMap.Size = new System.Drawing.Size(215, 349);
			this.panelMap.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.lbMapColor);
			this.panel1.Controls.Add(this.btMapColorPrev);
			this.panel1.Controls.Add(this.pictureBoxMapColor);
			this.panel1.Controls.Add(this.btMapColorNext);
			this.panel1.Location = new System.Drawing.Point(3, 145);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(207, 176);
			this.panel1.TabIndex = 11;
			// 
			// lbMapColor
			// 
			this.lbMapColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbMapColor.Location = new System.Drawing.Point(84, 6);
			this.lbMapColor.Name = "lbMapColor";
			this.lbMapColor.Size = new System.Drawing.Size(41, 23);
			this.lbMapColor.TabIndex = 7;
			this.lbMapColor.Text = "Color";
			this.lbMapColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btMapColorPrev
			// 
			this.btMapColorPrev.Location = new System.Drawing.Point(12, 36);
			this.btMapColorPrev.Name = "btMapColorPrev";
			this.btMapColorPrev.Size = new System.Drawing.Size(20, 124);
			this.btMapColorPrev.TabIndex = 10;
			this.btMapColorPrev.TabStop = false;
			this.btMapColorPrev.Text = "<";
			this.btMapColorPrev.UseVisualStyleBackColor = true;
			this.btMapColorPrev.Click += new System.EventHandler(this.BtMapColorPrevClick);
			// 
			// pictureBoxMapColor
			// 
			this.pictureBoxMapColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBoxMapColor.Location = new System.Drawing.Point(38, 36);
			this.pictureBoxMapColor.Name = "pictureBoxMapColor";
			this.pictureBoxMapColor.Size = new System.Drawing.Size(130, 125);
			this.pictureBoxMapColor.TabIndex = 8;
			this.pictureBoxMapColor.TabStop = false;
			// 
			// btMapColorNext
			// 
			this.btMapColorNext.Location = new System.Drawing.Point(174, 36);
			this.btMapColorNext.Name = "btMapColorNext";
			this.btMapColorNext.Size = new System.Drawing.Size(20, 124);
			this.btMapColorNext.TabIndex = 9;
			this.btMapColorNext.TabStop = false;
			this.btMapColorNext.Text = ">";
			this.btMapColorNext.UseVisualStyleBackColor = true;
			this.btMapColorNext.Click += new System.EventHandler(this.BtMapColorNextClick);
			// 
			// panelMapOption
			// 
			this.panelMapOption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelMapOption.Controls.Add(this.checkBoxMapOptionSpeedup);
			this.panelMapOption.Controls.Add(this.checkBoxMapOptionBorder);
			this.panelMapOption.Controls.Add(this.lbMapSpeedup);
			this.panelMapOption.Controls.Add(this.lbMapBorder);
			this.panelMapOption.Controls.Add(this.lbMapOption);
			this.panelMapOption.Location = new System.Drawing.Point(110, 33);
			this.panelMapOption.Name = "panelMapOption";
			this.panelMapOption.Size = new System.Drawing.Size(101, 106);
			this.panelMapOption.TabIndex = 7;
			// 
			// checkBoxMapOptionSpeedup
			// 
			this.checkBoxMapOptionSpeedup.Location = new System.Drawing.Point(69, 53);
			this.checkBoxMapOptionSpeedup.Name = "checkBoxMapOptionSpeedup";
			this.checkBoxMapOptionSpeedup.Size = new System.Drawing.Size(19, 19);
			this.checkBoxMapOptionSpeedup.TabIndex = 4;
			this.checkBoxMapOptionSpeedup.TabStop = false;
			this.checkBoxMapOptionSpeedup.Text = "checkBox2";
			this.checkBoxMapOptionSpeedup.UseVisualStyleBackColor = true;
			this.checkBoxMapOptionSpeedup.CheckedChanged += new System.EventHandler(this.CheckBoxMapOptionSpeedupCheckedChanged);
			// 
			// checkBoxMapOptionBorder
			// 
			this.checkBoxMapOptionBorder.Location = new System.Drawing.Point(69, 31);
			this.checkBoxMapOptionBorder.Name = "checkBoxMapOptionBorder";
			this.checkBoxMapOptionBorder.Size = new System.Drawing.Size(19, 19);
			this.checkBoxMapOptionBorder.TabIndex = 3;
			this.checkBoxMapOptionBorder.TabStop = false;
			this.checkBoxMapOptionBorder.Text = "checkBoxBorder";
			this.checkBoxMapOptionBorder.UseVisualStyleBackColor = true;
			this.checkBoxMapOptionBorder.CheckedChanged += new System.EventHandler(this.CheckBoxMapOptionBorderCheckedChanged);
			// 
			// lbMapSpeedup
			// 
			this.lbMapSpeedup.Location = new System.Drawing.Point(16, 50);
			this.lbMapSpeedup.Name = "lbMapSpeedup";
			this.lbMapSpeedup.Size = new System.Drawing.Size(54, 21);
			this.lbMapSpeedup.TabIndex = 2;
			this.lbMapSpeedup.Text = "Speedup";
			this.lbMapSpeedup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbMapBorder
			// 
			this.lbMapBorder.Location = new System.Drawing.Point(16, 29);
			this.lbMapBorder.Name = "lbMapBorder";
			this.lbMapBorder.Size = new System.Drawing.Size(48, 21);
			this.lbMapBorder.TabIndex = 1;
			this.lbMapBorder.Text = "Border";
			this.lbMapBorder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbMapOption
			// 
			this.lbMapOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbMapOption.Location = new System.Drawing.Point(6, 6);
			this.lbMapOption.Name = "lbMapOption";
			this.lbMapOption.Size = new System.Drawing.Size(58, 23);
			this.lbMapOption.TabIndex = 0;
			this.lbMapOption.Text = "Option";
			this.lbMapOption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panelMapSize
			// 
			this.panelMapSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelMapSize.Controls.Add(this.rdbtMapSizeLarge);
			this.panelMapSize.Controls.Add(this.rdbtMapSizeMedium);
			this.panelMapSize.Controls.Add(this.rdbtMapSizeSmall);
			this.panelMapSize.Controls.Add(this.lbMapSizeLarge);
			this.panelMapSize.Controls.Add(this.lbMapSizeMedium);
			this.panelMapSize.Controls.Add(this.lbMapSizeSmall);
			this.panelMapSize.Controls.Add(this.lbMapSize);
			this.panelMapSize.Location = new System.Drawing.Point(3, 33);
			this.panelMapSize.Name = "panelMapSize";
			this.panelMapSize.Size = new System.Drawing.Size(101, 106);
			this.panelMapSize.TabIndex = 1;
			// 
			// rdbtMapSizeLarge
			// 
			this.rdbtMapSizeLarge.Location = new System.Drawing.Point(64, 72);
			this.rdbtMapSizeLarge.Name = "rdbtMapSizeLarge";
			this.rdbtMapSizeLarge.Size = new System.Drawing.Size(22, 20);
			this.rdbtMapSizeLarge.TabIndex = 6;
			this.rdbtMapSizeLarge.Text = "Large";
			this.rdbtMapSizeLarge.UseVisualStyleBackColor = true;
			this.rdbtMapSizeLarge.CheckedChanged += new System.EventHandler(this.RdbtMapSizeLargeCheckedChanged);
			// 
			// rdbtMapSizeMedium
			// 
			this.rdbtMapSizeMedium.Location = new System.Drawing.Point(64, 51);
			this.rdbtMapSizeMedium.Name = "rdbtMapSizeMedium";
			this.rdbtMapSizeMedium.Size = new System.Drawing.Size(22, 20);
			this.rdbtMapSizeMedium.TabIndex = 5;
			this.rdbtMapSizeMedium.Text = "Medium";
			this.rdbtMapSizeMedium.UseVisualStyleBackColor = true;
			this.rdbtMapSizeMedium.CheckedChanged += new System.EventHandler(this.RdbtMapSizeMediumCheckedChanged);
			// 
			// rdbtMapSizeSmall
			// 
			this.rdbtMapSizeSmall.Location = new System.Drawing.Point(64, 29);
			this.rdbtMapSizeSmall.Name = "rdbtMapSizeSmall";
			this.rdbtMapSizeSmall.Size = new System.Drawing.Size(22, 20);
			this.rdbtMapSizeSmall.TabIndex = 4;
			this.rdbtMapSizeSmall.Text = "Small";
			this.rdbtMapSizeSmall.UseVisualStyleBackColor = true;
			this.rdbtMapSizeSmall.CheckedChanged += new System.EventHandler(this.RdbtMapSizeSmallCheckedChanged);
			// 
			// lbMapSizeLarge
			// 
			this.lbMapSizeLarge.Location = new System.Drawing.Point(16, 71);
			this.lbMapSizeLarge.Name = "lbMapSizeLarge";
			this.lbMapSizeLarge.Size = new System.Drawing.Size(48, 21);
			this.lbMapSizeLarge.TabIndex = 3;
			this.lbMapSizeLarge.Text = "Large";
			this.lbMapSizeLarge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbMapSizeMedium
			// 
			this.lbMapSizeMedium.Location = new System.Drawing.Point(16, 50);
			this.lbMapSizeMedium.Name = "lbMapSizeMedium";
			this.lbMapSizeMedium.Size = new System.Drawing.Size(48, 21);
			this.lbMapSizeMedium.TabIndex = 2;
			this.lbMapSizeMedium.Text = "Medium";
			this.lbMapSizeMedium.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbMapSizeSmall
			// 
			this.lbMapSizeSmall.Location = new System.Drawing.Point(16, 29);
			this.lbMapSizeSmall.Name = "lbMapSizeSmall";
			this.lbMapSizeSmall.Size = new System.Drawing.Size(48, 21);
			this.lbMapSizeSmall.TabIndex = 1;
			this.lbMapSizeSmall.Text = "Small";
			this.lbMapSizeSmall.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbMapSize
			// 
			this.lbMapSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbMapSize.Location = new System.Drawing.Point(6, 6);
			this.lbMapSize.Name = "lbMapSize";
			this.lbMapSize.Size = new System.Drawing.Size(33, 23);
			this.lbMapSize.TabIndex = 0;
			this.lbMapSize.Text = "Size";
			this.lbMapSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbMap
			// 
			this.lbMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbMap.Location = new System.Drawing.Point(67, 0);
			this.lbMap.Name = "lbMap";
			this.lbMap.Size = new System.Drawing.Size(80, 34);
			this.lbMap.TabIndex = 0;
			this.lbMap.Text = "MAP";
			this.lbMap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btCancel
			// 
			this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btCancel.Location = new System.Drawing.Point(150, 373);
			this.btCancel.Name = "btCancel";
			this.btCancel.Size = new System.Drawing.Size(77, 30);
			this.btCancel.TabIndex = 1;
			this.btCancel.TabStop = false;
			this.btCancel.Text = "Cancel";
			this.btCancel.UseVisualStyleBackColor = true;
			this.btCancel.Click += new System.EventHandler(this.BtCancelClick);
			// 
			// btOK
			// 
			this.btOK.Location = new System.Drawing.Point(234, 373);
			this.btOK.Name = "btOK";
			this.btOK.Size = new System.Drawing.Size(77, 30);
			this.btOK.TabIndex = 2;
			this.btOK.TabStop = false;
			this.btOK.Text = "OK";
			this.btOK.UseVisualStyleBackColor = true;
			this.btOK.Click += new System.EventHandler(this.BtOKClick);
			// 
			// panelSnake
			// 
			this.panelSnake.BackColor = System.Drawing.Color.Lavender;
			this.panelSnake.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelSnake.Controls.Add(this.panel2);
			this.panelSnake.Controls.Add(this.panelSnakePlayer2);
			this.panelSnake.Controls.Add(this.lbFood);
			this.panelSnake.Controls.Add(this.panelSnakePlayer1);
			this.panelSnake.Controls.Add(this.panelSnakeStyle);
			this.panelSnake.Controls.Add(this.panelSnakeSize);
			this.panelSnake.Controls.Add(this.lbSnake);
			this.panelSnake.Location = new System.Drawing.Point(234, 12);
			this.panelSnake.Name = "panelSnake";
			this.panelSnake.Size = new System.Drawing.Size(215, 349);
			this.panelSnake.TabIndex = 11;
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.pictureBoxFoodColor);
			this.panel2.Controls.Add(this.btFoodPrev);
			this.panel2.Controls.Add(this.btFoodNext);
			this.panel2.Controls.Add(this.lbFoodColor);
			this.panel2.Location = new System.Drawing.Point(4, 247);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(206, 74);
			this.panel2.TabIndex = 14;
			// 
			// pictureBoxFoodColor
			// 
			this.pictureBoxFoodColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBoxFoodColor.Location = new System.Drawing.Point(106, 5);
			this.pictureBoxFoodColor.Name = "pictureBoxFoodColor";
			this.pictureBoxFoodColor.Size = new System.Drawing.Size(22, 19);
			this.pictureBoxFoodColor.TabIndex = 13;
			this.pictureBoxFoodColor.TabStop = false;
			// 
			// btFoodPrev
			// 
			this.btFoodPrev.Location = new System.Drawing.Point(94, 5);
			this.btFoodPrev.Name = "btFoodPrev";
			this.btFoodPrev.Size = new System.Drawing.Size(13, 19);
			this.btFoodPrev.TabIndex = 12;
			this.btFoodPrev.TabStop = false;
			this.btFoodPrev.Text = "<";
			this.btFoodPrev.UseVisualStyleBackColor = true;
			this.btFoodPrev.Click += new System.EventHandler(this.BtFoodPrevClick);
			// 
			// btFoodNext
			// 
			this.btFoodNext.Location = new System.Drawing.Point(127, 5);
			this.btFoodNext.Name = "btFoodNext";
			this.btFoodNext.Size = new System.Drawing.Size(13, 19);
			this.btFoodNext.TabIndex = 11;
			this.btFoodNext.TabStop = false;
			this.btFoodNext.Text = ">";
			this.btFoodNext.UseVisualStyleBackColor = true;
			this.btFoodNext.Click += new System.EventHandler(this.BtFoodNextClick);
			// 
			// lbFoodColor
			// 
			this.lbFoodColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbFoodColor.Location = new System.Drawing.Point(56, 1);
			this.lbFoodColor.Name = "lbFoodColor";
			this.lbFoodColor.Size = new System.Drawing.Size(45, 23);
			this.lbFoodColor.TabIndex = 7;
			this.lbFoodColor.Text = "Color";
			this.lbFoodColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panelSnakePlayer2
			// 
			this.panelSnakePlayer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelSnakePlayer2.Controls.Add(this.pictureBoxPlayerColor2);
			this.panelSnakePlayer2.Controls.Add(this.btPlayerPrev2);
			this.panelSnakePlayer2.Controls.Add(this.btPlayerNext2);
			this.panelSnakePlayer2.Controls.Add(this.lbPlayerColor2);
			this.panelSnakePlayer2.Controls.Add(this.lbPlayer2);
			this.panelSnakePlayer2.Location = new System.Drawing.Point(110, 145);
			this.panelSnakePlayer2.Name = "panelSnakePlayer2";
			this.panelSnakePlayer2.Size = new System.Drawing.Size(100, 67);
			this.panelSnakePlayer2.TabIndex = 14;
			// 
			// pictureBoxPlayerColor2
			// 
			this.pictureBoxPlayerColor2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBoxPlayerColor2.Location = new System.Drawing.Point(57, 33);
			this.pictureBoxPlayerColor2.Name = "pictureBoxPlayerColor2";
			this.pictureBoxPlayerColor2.Size = new System.Drawing.Size(22, 19);
			this.pictureBoxPlayerColor2.TabIndex = 13;
			this.pictureBoxPlayerColor2.TabStop = false;
			// 
			// btPlayerPrev2
			// 
			this.btPlayerPrev2.Location = new System.Drawing.Point(45, 33);
			this.btPlayerPrev2.Name = "btPlayerPrev2";
			this.btPlayerPrev2.Size = new System.Drawing.Size(13, 19);
			this.btPlayerPrev2.TabIndex = 12;
			this.btPlayerPrev2.TabStop = false;
			this.btPlayerPrev2.Text = "<";
			this.btPlayerPrev2.UseVisualStyleBackColor = true;
			this.btPlayerPrev2.Click += new System.EventHandler(this.BtPlayerPrev2Click);
			// 
			// btPlayerNext2
			// 
			this.btPlayerNext2.Location = new System.Drawing.Point(78, 33);
			this.btPlayerNext2.Name = "btPlayerNext2";
			this.btPlayerNext2.Size = new System.Drawing.Size(13, 19);
			this.btPlayerNext2.TabIndex = 11;
			this.btPlayerNext2.TabStop = false;
			this.btPlayerNext2.Text = ">";
			this.btPlayerNext2.UseVisualStyleBackColor = true;
			this.btPlayerNext2.Click += new System.EventHandler(this.BtPlayerNext2Click);
			// 
			// lbPlayerColor2
			// 
			this.lbPlayerColor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbPlayerColor2.Location = new System.Drawing.Point(7, 29);
			this.lbPlayerColor2.Name = "lbPlayerColor2";
			this.lbPlayerColor2.Size = new System.Drawing.Size(45, 23);
			this.lbPlayerColor2.TabIndex = 7;
			this.lbPlayerColor2.Text = "Color";
			this.lbPlayerColor2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbPlayer2
			// 
			this.lbPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbPlayer2.Location = new System.Drawing.Point(15, 6);
			this.lbPlayer2.Name = "lbPlayer2";
			this.lbPlayer2.Size = new System.Drawing.Size(70, 23);
			this.lbPlayer2.TabIndex = 6;
			this.lbPlayer2.Text = "Player 2";
			this.lbPlayer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbFood
			// 
			this.lbFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbFood.Location = new System.Drawing.Point(66, 214);
			this.lbFood.Name = "lbFood";
			this.lbFood.Size = new System.Drawing.Size(80, 34);
			this.lbFood.TabIndex = 9;
			this.lbFood.Text = "FOOD";
			this.lbFood.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panelSnakePlayer1
			// 
			this.panelSnakePlayer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelSnakePlayer1.Controls.Add(this.pictureBoxPlayerColor1);
			this.panelSnakePlayer1.Controls.Add(this.btPlayerPrev1);
			this.panelSnakePlayer1.Controls.Add(this.btPlayerNext1);
			this.panelSnakePlayer1.Controls.Add(this.lbPlayerColor1);
			this.panelSnakePlayer1.Controls.Add(this.lbPlayer1);
			this.panelSnakePlayer1.Location = new System.Drawing.Point(3, 145);
			this.panelSnakePlayer1.Name = "panelSnakePlayer1";
			this.panelSnakePlayer1.Size = new System.Drawing.Size(100, 67);
			this.panelSnakePlayer1.TabIndex = 8;
			// 
			// pictureBoxPlayerColor1
			// 
			this.pictureBoxPlayerColor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBoxPlayerColor1.Location = new System.Drawing.Point(57, 33);
			this.pictureBoxPlayerColor1.Name = "pictureBoxPlayerColor1";
			this.pictureBoxPlayerColor1.Size = new System.Drawing.Size(22, 19);
			this.pictureBoxPlayerColor1.TabIndex = 13;
			this.pictureBoxPlayerColor1.TabStop = false;
			// 
			// btPlayerPrev1
			// 
			this.btPlayerPrev1.Location = new System.Drawing.Point(45, 33);
			this.btPlayerPrev1.Name = "btPlayerPrev1";
			this.btPlayerPrev1.Size = new System.Drawing.Size(13, 19);
			this.btPlayerPrev1.TabIndex = 12;
			this.btPlayerPrev1.TabStop = false;
			this.btPlayerPrev1.Text = "<";
			this.btPlayerPrev1.UseVisualStyleBackColor = true;
			this.btPlayerPrev1.Click += new System.EventHandler(this.BtPlayerPrev1Click);
			// 
			// btPlayerNext1
			// 
			this.btPlayerNext1.Location = new System.Drawing.Point(78, 33);
			this.btPlayerNext1.Name = "btPlayerNext1";
			this.btPlayerNext1.Size = new System.Drawing.Size(13, 19);
			this.btPlayerNext1.TabIndex = 11;
			this.btPlayerNext1.TabStop = false;
			this.btPlayerNext1.Text = ">";
			this.btPlayerNext1.UseVisualStyleBackColor = true;
			this.btPlayerNext1.Click += new System.EventHandler(this.BtPlayerNext1Click);
			// 
			// lbPlayerColor1
			// 
			this.lbPlayerColor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbPlayerColor1.Location = new System.Drawing.Point(7, 29);
			this.lbPlayerColor1.Name = "lbPlayerColor1";
			this.lbPlayerColor1.Size = new System.Drawing.Size(45, 23);
			this.lbPlayerColor1.TabIndex = 7;
			this.lbPlayerColor1.Text = "Color";
			this.lbPlayerColor1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbPlayer1
			// 
			this.lbPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbPlayer1.Location = new System.Drawing.Point(15, 6);
			this.lbPlayer1.Name = "lbPlayer1";
			this.lbPlayer1.Size = new System.Drawing.Size(70, 23);
			this.lbPlayer1.TabIndex = 6;
			this.lbPlayer1.Text = "Player 1";
			this.lbPlayer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panelSnakeStyle
			// 
			this.panelSnakeStyle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelSnakeStyle.Controls.Add(this.rdbtSnakeStylePlayer2);
			this.panelSnakeStyle.Controls.Add(this.lbSnakePlayer2);
			this.panelSnakeStyle.Controls.Add(this.rdbtSnakeStylePlayer1);
			this.panelSnakeStyle.Controls.Add(this.lbSnakePlayer1);
			this.panelSnakeStyle.Controls.Add(this.lbSnakeStyle);
			this.panelSnakeStyle.Location = new System.Drawing.Point(110, 33);
			this.panelSnakeStyle.Name = "panelSnakeStyle";
			this.panelSnakeStyle.Size = new System.Drawing.Size(101, 106);
			this.panelSnakeStyle.TabIndex = 7;
			// 
			// rdbtSnakeStylePlayer2
			// 
			this.rdbtSnakeStylePlayer2.Location = new System.Drawing.Point(65, 52);
			this.rdbtSnakeStylePlayer2.Name = "rdbtSnakeStylePlayer2";
			this.rdbtSnakeStylePlayer2.Size = new System.Drawing.Size(22, 20);
			this.rdbtSnakeStylePlayer2.TabIndex = 7;
			this.rdbtSnakeStylePlayer2.Text = "Medium";
			this.rdbtSnakeStylePlayer2.UseVisualStyleBackColor = true;
			this.rdbtSnakeStylePlayer2.CheckedChanged += new System.EventHandler(this.RdbtSnakeStylePlayer2CheckedChanged);
			// 
			// lbSnakePlayer2
			// 
			this.lbSnakePlayer2.Location = new System.Drawing.Point(16, 50);
			this.lbSnakePlayer2.Name = "lbSnakePlayer2";
			this.lbSnakePlayer2.Size = new System.Drawing.Size(54, 21);
			this.lbSnakePlayer2.TabIndex = 2;
			this.lbSnakePlayer2.Text = "2 Player";
			this.lbSnakePlayer2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// rdbtSnakeStylePlayer1
			// 
			this.rdbtSnakeStylePlayer1.Location = new System.Drawing.Point(65, 30);
			this.rdbtSnakeStylePlayer1.Name = "rdbtSnakeStylePlayer1";
			this.rdbtSnakeStylePlayer1.Size = new System.Drawing.Size(22, 20);
			this.rdbtSnakeStylePlayer1.TabIndex = 6;
			this.rdbtSnakeStylePlayer1.Text = "1Player";
			this.rdbtSnakeStylePlayer1.UseVisualStyleBackColor = true;
			this.rdbtSnakeStylePlayer1.CheckedChanged += new System.EventHandler(this.RdbtSnakeStylePlayer1CheckedChanged);
			// 
			// lbSnakePlayer1
			// 
			this.lbSnakePlayer1.Location = new System.Drawing.Point(16, 29);
			this.lbSnakePlayer1.Name = "lbSnakePlayer1";
			this.lbSnakePlayer1.Size = new System.Drawing.Size(48, 21);
			this.lbSnakePlayer1.TabIndex = 1;
			this.lbSnakePlayer1.Text = "1 Player";
			this.lbSnakePlayer1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbSnakeStyle
			// 
			this.lbSnakeStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbSnakeStyle.Location = new System.Drawing.Point(6, 6);
			this.lbSnakeStyle.Name = "lbSnakeStyle";
			this.lbSnakeStyle.Size = new System.Drawing.Size(58, 23);
			this.lbSnakeStyle.TabIndex = 0;
			this.lbSnakeStyle.Text = "Style";
			this.lbSnakeStyle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panelSnakeSize
			// 
			this.panelSnakeSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelSnakeSize.Controls.Add(this.rdbtSnakeSizeMedium);
			this.panelSnakeSize.Controls.Add(this.rdbtSnakeSizeSmall);
			this.panelSnakeSize.Controls.Add(this.lbSnakeSizeMedium);
			this.panelSnakeSize.Controls.Add(this.lbSnakeSizeSmall);
			this.panelSnakeSize.Controls.Add(this.lbSnakeSize);
			this.panelSnakeSize.Location = new System.Drawing.Point(3, 33);
			this.panelSnakeSize.Name = "panelSnakeSize";
			this.panelSnakeSize.Size = new System.Drawing.Size(101, 106);
			this.panelSnakeSize.TabIndex = 1;
			// 
			// rdbtSnakeSizeMedium
			// 
			this.rdbtSnakeSizeMedium.Location = new System.Drawing.Point(64, 51);
			this.rdbtSnakeSizeMedium.Name = "rdbtSnakeSizeMedium";
			this.rdbtSnakeSizeMedium.Size = new System.Drawing.Size(22, 20);
			this.rdbtSnakeSizeMedium.TabIndex = 5;
			this.rdbtSnakeSizeMedium.Text = "Medium";
			this.rdbtSnakeSizeMedium.UseVisualStyleBackColor = true;
			// 
			// rdbtSnakeSizeSmall
			// 
			this.rdbtSnakeSizeSmall.Location = new System.Drawing.Point(64, 29);
			this.rdbtSnakeSizeSmall.Name = "rdbtSnakeSizeSmall";
			this.rdbtSnakeSizeSmall.Size = new System.Drawing.Size(22, 20);
			this.rdbtSnakeSizeSmall.TabIndex = 4;
			this.rdbtSnakeSizeSmall.Text = "Small";
			this.rdbtSnakeSizeSmall.UseVisualStyleBackColor = true;
			// 
			// lbSnakeSizeMedium
			// 
			this.lbSnakeSizeMedium.Location = new System.Drawing.Point(16, 50);
			this.lbSnakeSizeMedium.Name = "lbSnakeSizeMedium";
			this.lbSnakeSizeMedium.Size = new System.Drawing.Size(48, 21);
			this.lbSnakeSizeMedium.TabIndex = 2;
			this.lbSnakeSizeMedium.Text = "Medium";
			this.lbSnakeSizeMedium.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbSnakeSizeSmall
			// 
			this.lbSnakeSizeSmall.Location = new System.Drawing.Point(16, 29);
			this.lbSnakeSizeSmall.Name = "lbSnakeSizeSmall";
			this.lbSnakeSizeSmall.Size = new System.Drawing.Size(48, 21);
			this.lbSnakeSizeSmall.TabIndex = 1;
			this.lbSnakeSizeSmall.Text = "Small";
			this.lbSnakeSizeSmall.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbSnakeSize
			// 
			this.lbSnakeSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbSnakeSize.Location = new System.Drawing.Point(6, 6);
			this.lbSnakeSize.Name = "lbSnakeSize";
			this.lbSnakeSize.Size = new System.Drawing.Size(33, 23);
			this.lbSnakeSize.TabIndex = 0;
			this.lbSnakeSize.Text = "Size";
			this.lbSnakeSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbSnake
			// 
			this.lbSnake.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbSnake.Location = new System.Drawing.Point(66, 0);
			this.lbSnake.Name = "lbSnake";
			this.lbSnake.Size = new System.Drawing.Size(80, 34);
			this.lbSnake.TabIndex = 0;
			this.lbSnake.Text = "SNAKE";
			this.lbSnake.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FrmOption
			// 
			this.AcceptButton = this.btOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.CancelButton = this.btCancel;
			this.ClientSize = new System.Drawing.Size(461, 415);
			this.Controls.Add(this.panelSnake);
			this.Controls.Add(this.btOK);
			this.Controls.Add(this.btCancel);
			this.Controls.Add(this.panelMap);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "FrmOption";
			this.Text = "Option";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmOptionFormClosing);
			this.panelMap.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxMapColor)).EndInit();
			this.panelMapOption.ResumeLayout(false);
			this.panelMapSize.ResumeLayout(false);
			this.panelSnake.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoodColor)).EndInit();
			this.panelSnakePlayer2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayerColor2)).EndInit();
			this.panelSnakePlayer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayerColor1)).EndInit();
			this.panelSnakeStyle.ResumeLayout(false);
			this.panelSnakeSize.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
