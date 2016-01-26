using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisGameLib
{
    //存储当前形状的信息
    public class Shape:ICloneable
    {  
        #region 字段 刚出现时中心点位置(x,y),朝向往_dir
        private int _dir = 0;
        private int _x = 3;//记录4*4的（1,3）行列位置
        private int _y = 0;
        private int _id =1;
        private readonly KindOfShape shapeName;
        private  int[] _ShapeRegion;//当前的状态
        private int color = 1;

        public int Color
        {
            get { return color; }
            set { color = value; }
        }
        #endregion

        #region 属性
        
        public  int ID 
        {
            get
            {
                return _id;
            }
        }
       
        public int X
        {
            get { return _x; }
            set { _x = value; }
        }
        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }
        public int dir
        {
            get { return _dir; }
            set { _dir = value; }
        }
        #endregion
        //属性，每次调用时根据dir返回值
        public  int[] ShapeRegion
        {
            get { return ConstData.ShapeMap[(int)shapeName][dir]; }
            set { _ShapeRegion = value; }
        }

        //internal Shape(int sk, int dir)
        public Shape(KindOfShape sk, ShapeDirction dir, int mycolor)
        {
            shapeName = sk;
            color = mycolor;//color 是不为0的整数（2-10）
            ShapeRegion = ConstData.ShapeMap[(byte)sk][(byte)dir];//初始化，传入随机数形状和方向,生成一个对应实例
        }
        public object Clone()
        {
            return this.MemberwiseClone(); //返回浅clone方法¨}}
        }
        
    }
  

}
