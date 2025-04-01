using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textRPG.Scenes
{
    public class Title : Scenes
    {

        public override void Render()
        {

            Console.WriteLine("=============================================");
            Console.WriteLine("             좀비 아포칼립스 게임            ");
            Console.WriteLine("=============================================");

        }


        public override void Choice()
        {
            Console.WriteLine("1. 게임 시작");
            Console.WriteLine("2. 게임 종료");
        }



        public override void Result()
        {
        }

        public override void Wait()
        {

        }

        public override void Next()
        {
            switch(input)
            {
                case ConsoleKey.D1:
                    Game.ChangeScene("Home");
                    break;
                case ConsoleKey.D2:
                    Game.GameOver("게임을 종료하셨습니다.");
                    break;
            }
        }
    }
}
