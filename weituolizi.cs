using System;

namespace weituoanli
{
    class Program
    {
        //以游戏开发为例
        //一个人开发人物 一个人开发UI

        delegate void onewin();

        static void Player(onewin playerwin){
            Console.WriteLine("WIN");
            //此时应该显示胜利的UI
            //但是UI并不在人物开发者的代码中，此时就会定义委托来预留胜利UI的位置
            playerwin();
        }
        
        //UI开发者将UI代码录入进去后
        static void winUI(){
            Console.WriteLine("win UI");
        }

        static void Main(string[] args){
            Player(winUI);
        }
    }
}