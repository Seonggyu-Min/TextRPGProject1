using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textRPG.Scenes
{
    class Inside : Scenes
    {
        public override void Render()
        {
            Game.PrintInfo();
            Util.Print("당신은 부서질 듯한 소음과 괴성을 들으며 숨습니다...", ConsoleColor.Red, 1000);
            Util.Print("좀비는 사냥감을 찾는 듯한 모습으로 집 안을 뒤지고 있습니다...", ConsoleColor.Red, 1000);
            Util.Print("당신은 두려움에 떨다가 실수로 다리로 장롱을 쳐버립니다...", ConsoleColor.Red, 1000);
            Util.Print("좀비는 당신에게 바로 달려옵니다!!!", ConsoleColor.Red, 1000);
            Game.GameOver("좀비에게 물렸습니다...");

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
