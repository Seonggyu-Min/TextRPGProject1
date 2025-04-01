using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textRPG.Scenes
{
    public class Home2_1 : Scenes
    {
        public override void Render()
        {
            Game.PrintInfo();
            Util.Print("창 밖의 기괴한 소리에 초초함을 느끼던 당신은 생필품을 정리합니다.", 1000);
            Util.Print("갑자기 초인종이 울립니다... 누구일까요...?", ConsoleColor.Yellow, 1000);
            Util.Print("초인종을 누른 사람은 어린 남학생이었으며 공과금을 오래 내지 못해 추운 나머지 당신의 집에서 지낼 것을 부탁합니다...", ConsoleColor.Yellow, 1000);
            Util.Print("그를 들여보낼까요...?", ConsoleColor.Yellow, 1000);
        }


        public override void Choice()
        {
            Console.WriteLine("1. 추위에 떨고 있는 아이를 들여보낸다...");
            Console.WriteLine("2. 재난 상황에 누군가를 들여보내는 것은 너무 위험하다...");
        }

        public override void Result()
        {
            switch (input)
            {
                case (ConsoleKey.D1):
                    Console.WriteLine("당신은 그를 안쓰러히 여기며 들여보내줬습니다...");
                    Console.WriteLine("그는 호의를 베푼 당신에게 집에 있는 간단한 식품을 나눠주었습니다...");
                    Console.WriteLine("허기가 1 증가하였습니다.");
                    Console.WriteLine("당신은 남학생과 동반자가 되었습니다.");
                    Game.Player.Hunger++;
                    Game.companion.Add("남학생");
                    break;
                case (ConsoleKey.D2):
                    Console.WriteLine("그는 실망한 표정을 가득 안고 다른 집을 향해 발걸음을 돌립니다...");
                    Console.WriteLine("당신은 마음이 쓰이지만 자기 자신을 지키는 것이 무엇보다 중요한 것을 상기합니다...");
                    Console.WriteLine("당신은 긴장으로 인해 허기를 느끼지 못했지만 시간이 지나면서 점점 배가 고파옵니다...");
                    Console.WriteLine("허기가 1 감소했습니다.");
                    Game.Player.Hunger--;
                    break;
            }
        }

        public override void Wait()
        {
            Console.WriteLine("계속하려면 아무 키나 누르십시오.");
            Console.ReadKey();
        }

        public override void Next()
        {
            switch (input)
            {
                case (ConsoleKey.D1):
                case (ConsoleKey.D2):
                    {
                        Game.ChangeScene("Gate");
                        break;
                    }
            }
        }
    }

}

