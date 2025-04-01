using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textRPG.Scenes
{
    class Home4 : Scenes
    {
        public override void Render()
        {
            Game.PrintInfo();
            Util.Print("당신은 그대로 졸도하여 문 앞에 드러눕습니다...", ConsoleColor.Red, 1000);
            Util.Print("오랫동안 스트레스의 상황에 놓인 탓에 당신은 한동안 일어날 수 없었습니다...", ConsoleColor.Red, 1000);
            Util.Print("허기와 휴식이 1씩 감소합니다...", 1000);
            
            Game.Player.Rest--;
            Game.Player.Hunger--;

            if (Game.Player.Rest <= 0)
                Game.GameOver("휴식 수치가 극한에 다달았습니다...");

            if  (Game.Player.Hunger <= 0)
                Game.GameOver("허기 수치가 극한에 다달았습니다...");
        }


        public override void Choice()
        {

        }

        public override void Result()
        {
           
            
        }

        public override void Wait()
        {

        }

        public override void Next()
        {
            
            
        }
    }
}
