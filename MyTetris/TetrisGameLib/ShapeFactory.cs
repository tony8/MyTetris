using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisGameLib
{
    /// <summary>
    /// 不断产生新的随机方块
    /// 要随机形状（7个）和方向（4种）
    /// 记录每种形状出现的次数
    /// 相邻两个方块的颜色要求不同
    /// </summary>

    class ShapeFactory
    {       
        public int[] sumofShape;//记录各个形状的方块出现的次数
        public double[] rateOfShape;//记录各个形状的比例
        private int PreColor = 0;//上一个方块的颜色
        private int PreKind = 0;//上一个方块的形状
        private int PreDir = 0;//上一个方块的方向

        public ShapeFactory()
        {
            sumofShape = new int[ConstData.numOfShape];
            rateOfShape = new double[ConstData.numOfShape];           
        }

        //随机生成形状和颜色，不同于上一个
        public byte[] RandomeCreate()
        {//依次返回形状，方向，颜色信息
            Random rshape = new Random();
            Random rDir = new Random();
            Random rColor = new Random();
            byte[] randomPiece = new byte[3];
            randomPiece[0] = (byte)(rshape.Next() % 7);
            randomPiece[1] = (byte)(rshape.Next() % 4);
            randomPiece[2] = (byte)(rshape.Next() % 9);
            while (randomPiece[0] == PreKind || randomPiece[2] == PreColor) 
            {               
                randomPiece[0] = (byte)(rshape.Next() % 7);
                randomPiece[1] = (byte)(rshape.Next() % 4);
                randomPiece[2] = (byte)(rshape.Next() % 9);
            }           
            PreKind = randomPiece[0];
            PreDir = randomPiece[1]; 
            PreColor = randomPiece[2];
            return randomPiece;
        }

        //根据形状去更新其他的
        public Shape refresh(byte[] randomPiece)
        {
            KindOfShape temps = (KindOfShape)randomPiece[0];
            ShapeDirction tempDir = (ShapeDirction)randomPiece[1];
            int Color = randomPiece[2];
            //给颜色赋值         
            Shape shape = new Shape(temps, tempDir,Color);
            
            sumofShape[(int)temps]++;
            reFreshRate();
            return shape;
        }
        public void reFreshRate()
        {//更新比例
            double sum = sumofShape.Sum();
            for (int i=0;i< ConstData.numOfShape;i++)
            {
                rateOfShape[i] = sumofShape[i] / sum;
            }
        }
    }
}
