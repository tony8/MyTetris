using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using TetrisGameLib;
//using TetrisGameLib.ConstData;

namespace TetrisSingle
{
    /// <summary>
    /// UI和逻辑分开
    /// 使用  timer.Start(); 每过固定时间出发一次下移
    /// </summary>
    public partial class SingleGame : Form
    {
        #region 私有数据
        private TetrisGame tetrisGame = null;   // 俄罗斯方块的逻辑
        private int eliminatedLines = 0;
        //private int score = 0;    // 分数暂时先不算
        private int speed = 0;
        private int proSpeed = 0;
        private int totalSeconds = 0;
        System.Timers.Timer mytimer ;//定时器

        private bool isPaused = false;  // 游戏是否暂停了
        #endregion

   
        public SingleGame()
        {
          InitializeComponent();
          // 设置默认双缓冲
          this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                        ControlStyles.UserPaint |
                        ControlStyles.AllPaintingInWmPaint, true);
          this.UpdateStyles();

          tetrisGame = new TetrisGame();  // 初始化俄罗斯方块逻辑

          // 注册俄罗斯方块事件
          tetrisGame.OneLineEliminated += this.OnLineEliminated;
          tetrisGame.shapeReachBottom += this.OnShapeReachBottom;
          tetrisGame.GamerOver += this.OnGameOver;

          timerDown.Start();
         

        }

        private void OnLineEliminated() 
        {
        }

        private void OnShapeReachBottom()
        {
        }
        private void OnGameOver()
        {
        }

        private void SingleGame_Load(object sender, EventArgs e)
        {
            tetrisGame.StartGame();
            panelMap.Size = new Size(
                ConstData.TETRIES_WIDTH * ConstData.TETRISCubeSize,
                ConstData.TETRIES_HEIGHT * ConstData.TETRISCubeSize);
          
        }

        /// <summary>
        /// 画出界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelMap_Paint(object sender, PaintEventArgs e)
        {//画界面
            Graphics g = e.Graphics;
            Rectangle curRect = new Rectangle();
            curRect.Width = ConstData.TETRISCubeSize; ;//ConstData.TETRISCubeSize;
            curRect.Height = ConstData.TETRISCubeSize; ;// ConstData.TETRISCubeSize;

            Shape curShape = tetrisGame.CurShape;

            //画当前的方块,4*4=16
            for (int i = 0; i < 16;i++ )
            {
                if(1 == tetrisGame.CurShape.ShapeRegion[i])
                {
                    g.FillRectangle(ConstData.ShapeColor[curShape.Color], (i % 4 + curShape.X) * curRect.Width,
                        (i / 4 + curShape.Y) * curRect.Height, curRect.Width, curRect.Height);
                }
            }
            //画区域
            for (int i = 0; i < ConstData.TETRIES_HEIGHT;i++ )
            {
                for (int j = 0; j < ConstData.TETRIES_WIDTH; j++)
                {
                    if (tetrisGame.Map[i,j]!=0)
                    {
                        curRect.X = j * curRect.Width;
                        curRect.Y = i * curRect.Height;
                        g.FillRectangle(ConstData.ShapeColor[tetrisGame.Map[i, j]], curRect);
                    }
                }
            }
            //更新分数和消去行数
            textBoxLine.Text = tetrisGame.NumOfElimiateLine.ToString();
            textBoxSocre.Text = tetrisGame.Socre.ToString();
        }

        private void SingleGame_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            //用户按下按键时
            switch (e.KeyCode) 
            {
                case Keys.Left: tetrisGame.InputLeft();
                    break;
                case Keys.Right: tetrisGame.InputRight();
                    break;
                case Keys.Up: tetrisGame.InputUp(); 
                    break;
                case Keys.Down: tetrisGame.InputDown(); 
                    break;
            }
            panelMap.Refresh();

        }

        private void timerDown_Tick(object sender, EventArgs e)
        {//原来在控件里面
            //MessageBox.Show("22222");
            tetrisGame.InputDown();
            panelMap.Refresh();
        }

    }
}
