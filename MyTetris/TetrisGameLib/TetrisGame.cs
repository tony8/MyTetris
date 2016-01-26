using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TetrisGameLib
{
    /// <summary>
    /// 界面显示的大小等逻辑
    /// 
    /// </summary>
    public class TetrisGame
    {
        #region 事件
        public delegate void GamerOverEventHandler();
        public delegate void OneLineEliminatedEventHandler();
        public delegate void shapeReachBottomEventHandler();

        public event GamerOverEventHandler GamerOver;
        public event OneLineEliminatedEventHandler OneLineEliminated;
        public event shapeReachBottomEventHandler shapeReachBottom;
        #endregion

        #region 常量 游戏池的大小
        private  readonly int TETRIES_WIDTH = ConstData.TETRIES_WIDTH;
        private  readonly int TETRIES_HEIGHT = ConstData.TETRIES_HEIGHT;
        #endregion

        #region 字段
        private int[,] _map = null;
        private Shape _curShape = null;
        private Shape _nextShape = null;
        private ShapeFactory _sf = null;
        private int socre = 0;
        private int numOfElimiateLine = 0;

        public int NumOfElimiateLine
        {
            get { return numOfElimiateLine; }
            set { numOfElimiateLine = value; }
        }

        public int Socre
        {
            get { return socre; }
            set { socre = value; }
        }
        private Boolean isPaused = false;//是否暂停
        #endregion

        public Shape CurShape 
        {//防止被修改
            get 
            {
                return (Shape)_curShape;
            }
        }
        public int[,] Map 
        {
            get 
            {
                return (int[,])this._map.Clone();
            }
        }
        public TetrisGame(bool needSyncRandom = false)
        {
            _map = new int[TETRIES_WIDTH, TETRIES_HEIGHT];  // 初始化地图
            _sf = new ShapeFactory();//新建工厂
        }

        public void StartGame()
        {
            _map = new int[TETRIES_HEIGHT,TETRIES_WIDTH];  // 重新清零/载入开局
            _curShape = _sf.refresh(_sf.RandomeCreate());   // 产生一个形状
            _nextShape = _sf.refresh(_sf.RandomeCreate());
            Socre = 0;
          
        }

        /// <summary>
        /// 判断是否移动合法
        /// </summary>
        /// <returns></returns>
        private Boolean isLegal(Shape tempShape) 
        {
            Shape ShapeNow = (Shape)tempShape.Clone(); 
            //初步判断是否越界
            bool flag = ShapeNow.X >= -2 && ShapeNow.X < TETRIES_WIDTH-1 && ShapeNow.Y >= 0 && ShapeNow.Y < TETRIES_HEIGHT-1;
            if (!flag) 
                return false;
            //是否和基地发生碰撞
            for (int i = 0; i < 4;i++ )
            {
                for (int j = 0; j < 4;j++ )
                {
                    if (ShapeNow.ShapeRegion[4 * i + j] != 0 )
                    {
                        if (ShapeNow.X + j >= TETRIES_WIDTH || ShapeNow.Y + i >= TETRIES_HEIGHT || ShapeNow.X + j < 0)
                        {//和边界发生碰撞
                            return false;
                        }
                        if(_map[ShapeNow.Y+i,ShapeNow.X+j]!=0)
                        {//发生碰撞 
                            return false;
                        }
                        
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// 判断旋转时能否成功
        /// </summary>
        /// <returns></returns>
        public bool InputUp() 
        {
            Shape tempShapeUp1 = (Shape)_curShape.Clone();
            Shape tempShapeUp2 = (Shape)_curShape.Clone();
            tempShapeUp1.dir = (tempShapeUp1.dir + 1) % 4;//尝试顺时针旋转
            tempShapeUp2.dir = (tempShapeUp2.dir + 3) % 4; //尝试反方向旋转

            if (isLegal(tempShapeUp1)) 
            {
                _curShape.dir = (_curShape.dir + 1) % 4;
                return true;
            }
            else if (isLegal(tempShapeUp2))
            {
                _curShape.dir = (_curShape.dir + 3) % 4;
                return true;
            }
            else 
            {
                return false;
            }
        }

        public bool InputDown() 
        {
            //判断下移是否成功
            Shape tempShapeDown = (Shape)_curShape.Clone();
            tempShapeDown.Y++;
            if (isLegal(tempShapeDown))//下移一格成功
            {
                _curShape.Y++;
                return true;
            }
            else //触底:1.方块变成基地的一部分,消去满行 2.产生新的方块
            {
                AddCurshape();
                _curShape = _nextShape;
                _nextShape = _sf.refresh(_sf.RandomeCreate());
                int tempLine = EliminateLines();
                Socre = Socre + calSocre(tempLine);//消去满行。累加分数
                //判断游戏是否结束
                if(!isLegal(_curShape))//不合法，游戏结束
                {
                    if(GamerOver!=null)
                    {
                        GamerOver();
                    }
                }
                return false;
            }
        }

        public bool InputLeft() 
        {
            Shape tempShapeLeft = (Shape)_curShape.Clone();
            tempShapeLeft.X--;
            if (isLegal(tempShapeLeft))
            {
                _curShape.X--;
                return true;
            }
            else
            {
                return false;            
            }
        }

        public bool InputRight()
        {
            Shape tempShapeRight = (Shape)_curShape.Clone();
            tempShapeRight.X++;
            if (isLegal(tempShapeRight))
            {
                _curShape.X++;
                return true;
            }
            else
            {
                return false;
            }

        }

        private void AddCurshape()
        {//存入color
            for (int i = 0; i < 4; ++i)
            {
                for (int j = 0; j < 4; ++j)
                {
                    if (_curShape.ShapeRegion[i * 4 + j] == 1)
                        _map[_curShape.Y + i,_curShape.X + j] = _curShape.Color;//;_curShape.ID;
                }
            }
        }

        private int EliminateLines()
        {//着陆一个方块时消去所有满行，返回分数
            //1.把不满行的下移templine行，关键对象时不满行的
            int tempLine = 0;
            int count,tcol; 
            //int count = 0;//计数
            for (int row = ConstData.TETRIES_HEIGHT - 1; row > 0; row--)
            {//从下往上扫描每一行。消去是通过修改map表实现的
                for ( tcol = 0,count=0; tcol < ConstData.TETRIES_WIDTH; tcol++)
                {//计数是否满行
                    if (_map[row,tcol] != 0)                   
                        count++;                  
                } 
                
                if (ConstData.TETRIES_WIDTH == count) 
                {
                    tempLine++;
                    continue;//满行的跳过
                }
                if (tempLine == 0) continue;
                else 
                {//不满行的下移templiine行
                    for (tcol = 0; tcol < ConstData.TETRIES_WIDTH; tcol++)                
                    {
                        _map[row+tempLine,tcol] = _map[row ,tcol ];    
                    }
                }      
            }
            return tempLine;
        }

        private int calSocre(int line) 
        {
            int tscore = 0;
            switch (line)
            {
                case 0: tscore = ConstData.Socre[0];
                    break;
                case 1:
                    numOfElimiateLine++;
                    tscore = ConstData.Socre[1];
                    break;
                case 2: numOfElimiateLine = numOfElimiateLine + 2;
                    tscore = ConstData.Socre[2];
                    break;
                case 3: numOfElimiateLine = numOfElimiateLine + 3;
                    tscore = ConstData.Socre[3];
                    break;
                case 4: numOfElimiateLine = numOfElimiateLine + 4;
                    tscore = ConstData.Socre[4];
                    break;
            }
            return tscore;
        }
    }
}