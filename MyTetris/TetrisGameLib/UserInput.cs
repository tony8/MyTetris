using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisGameLib
{
    class UserInput
    {
        //用户输入控制器
        //用户输入四个方向控制+暂停 调用相应的函数
        UserInput()
        {
            //
        }
        //private void TetrisSingle_KeyDown(object sender, KeyEventArgs e)
        //{
        //    switch (e.KeyCode)
        //    {
        //        case Keys.Left: tetrisGame.Left(); break;
        //        case Keys.Right: tetrisGame.Right(); break;
        //        case Keys.Up: tetrisGame.Up(); break;
        //        case Keys.Down: tetrisGame.Down(); break;
        //        case Keys.Space:
        //            {
        //                while (tetrisGame.Down()) ;
        //            }; break;
        //        case Keys.J:
        //            {
        //                tetrisGame.AddJunkRow();
        //                gamePanel.Refresh();
        //            }; break;
        //    }
        //    gamePanel.Refresh();
        //}

        private void inputPaused()
        {
        }
        private void inputLeft()
        {
        }
        private void inputRight()
        {
        }
        private void inputDrop()
        {
        }
        private void inputRotate()
        {
        }

    }
}
