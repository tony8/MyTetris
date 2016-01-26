using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TetrisGameLib
{
    //静态常量类，此处记录有所有静态数据，不会更改，任何时刻可以调用
    //主要有7种形状4个方向的图案（16格）
    //所有参数都在此处修改
    public static class ConstData
    {
        public const int TETRIES_WIDTH = 10;
        public const int TETRIES_HEIGHT = 20;
        public const int TETRISCubeSize = 25;//方块大小
        public const int NCLIENT = 2; //参与者最大数量
        public const int numOfShape = 7;
        public static readonly int[][][] ShapeMap = new int[numOfShape][][];
        public static Brush[] ShapeColor = new Brush[10]
        {
            Brushes.Black,//不会取到的黑色
            Brushes.Blue,Brushes.Yellow,Brushes.Red,
            Brushes.Olive,Brushes.Orange,Brushes.Pink,
            Brushes.YellowGreen,Brushes.Wheat,Brushes.PaleGreen
        };
        public static  int[] Socre = new int[]{0,100,300,600,1000};//收行的奖励分数

        #region 方块知识表，记录了7种形状，每种有4个方向
        static int[][] ShapeO =  new int[4][]{
             new int[] { 0, 0, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0 },
             new int[] { 0, 0, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0 },
             new int[] { 0, 0, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0 },
             new int[] { 0, 0, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0 },
        };
        static int[][] ShapeI = {
             new int[] { 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
             new int[] { 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0 },
             new int[] { 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
             new int[] { 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0 },
        };
        static int[][] ShapeS = {
             new int[] { 0, 0, 0, 0, 0, 0, 1, 1, 0, 1, 1, 0, 0, 0, 0, 0 },
             new int[] { 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 0, 0, 0 },
             new int[] { 0, 0, 0, 0, 0, 0, 1, 1, 0, 1, 1, 0, 0, 0, 0, 0 },
             new int[] { 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 0, 0, 0 },
        };
        static int[][] ShapeZ = {
             new int[] { 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0 },
             new int[] { 0, 0, 0, 1, 0, 0, 1, 1, 0, 0, 1, 0, 0, 0, 0, 0 },
             new int[] { 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0 },
             new int[] { 0, 0, 0, 1, 0, 0, 1, 1, 0, 0, 1, 0, 0, 0, 0, 0 },
        };
        static int[][] ShapeL = {
              new int[] { 0, 0, 0, 0, 0, 1, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0 },
              new int[] { 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0 },
              new int[] { 0, 0, 0, 1, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
              new int[] { 0, 1, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
        };
        static int[][] ShapeJ = {
             new int[]  { 0, 0, 0, 0, 0, 1, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0 },
             new int[]  { 0, 0, 1, 1, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
             new int[]  { 0, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
             new int[]  { 0, 0, 1, 0, 0, 0, 1, 0, 0, 1, 1, 0, 0, 0, 0, 0 },
        };
        static int[][] ShapeT = {
             new int[] { 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 1, 0, 0, 0, 0, 0 },
             new int[] { 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 1, 0, 0, 0, 0, 0 },
             new int[] { 0, 0, 1, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
             new int[] { 0, 0, 1, 0, 0, 1, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
        };
        #endregion
        

        static ConstData()
        {
            ShapeMap[0] = ShapeO;
            ShapeMap[1] = ShapeI;
            ShapeMap[2] = ShapeS;
            ShapeMap[3] = ShapeZ;
            ShapeMap[4] = ShapeL;
            ShapeMap[5] = ShapeJ;
            ShapeMap[6] = ShapeT;
        }
     

    }
    public enum KindOfShape : byte
    {
        shapeO = 0,
        shapeI = 1,
        shapeS = 2,
        shapeZ = 3,
        shapeL = 4,
        shapeJ = 5,
        shapeT = 6,
    }
    public enum ShapeDirction :byte
    {
        left = 0,
        right = 1,
        up = 2,
        down = 3,
    }

    public enum Control
    {
        ControlRotate = 0,
        ControlDrop = 1,
        ControlLeft = 2,
        ControlRight = 3,
    }

 



}
