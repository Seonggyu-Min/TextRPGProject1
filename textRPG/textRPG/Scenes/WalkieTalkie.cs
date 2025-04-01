using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textRPG.Scenes
{
    class WalkieTalkie : Scenes
    {
        public override void Render()
        {
            Game.PrintInfo();
            Util.Print("걸쭉한 목소리의 남성이 잠에서 깬 듯한 말투로 무전에 응답합니다.", 1000);
            Util.Print("당신은 떨리는 목소리로 상황을 설명하며 도움을 청합니다.", 1000);
            Util.Print("기술자 아저씨는 갈게라는 짧은 대답과 함께 무전을 끊습니다.", 1000);
            Util.Print("당신은 곧 이어 문 밖에서 둔탁한 소리와 함께 무언가가 쓰러지는 소리를 듣습니다...", ConsoleColor.Red, 1000);
            Util.Print("당신은 노크 소리를 듣고 문을 열어 문 앞에 쓰러져있는 좀비를 목격합니다.", 1000);
            Util.Print("곧 이어 좀비를 들쳐매고 계단을 올라가는 아저씨에게 당신은 감사하다는 말을 연신 하며 안도감을 느낍니다", ConsoleColor.Green, 1000);
            Console.WriteLine();
            Util.Print("며칠 후 당신은 밖에서 들리는 확성기 소리에 아침잠에서 깨어납니다.", 1000);
            Util.Print("군인이 좀비 발생 지역을 봉쇄하였고 확산을 막아 이 곳이 안전하다는 소식을 전해옵니다.", ConsoleColor.Green, 1000);
            Util.Print("당신은 오랜만의 바깥 공기를 쐬며 현관 밖으로 나갑니다...", ConsoleColor.Green, 1000);
            Game.End();
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
