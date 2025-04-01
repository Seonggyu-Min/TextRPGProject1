using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textRPG.Scenes
{
    public class Home2 : Scenes
    {
        public override void Render()
        {
            Game.PrintInfo();
            Util.Print("당신은 멀리서 몇몇의 주민들이 도망가는 모습을 볼 수 있었습니다.", 1000);
            Util.Print("당신은 그들보다 안전한 곳에 있단 사실에 안도감을 느낍니다.", 1000);
            Util.Print("그러나 안도감도 잠시뿐이었습니다. 당신의 아파트 입주민대표 아저씨가 아파트의 현관문을 막을 수 있게 도와달라고 요청합니다.", ConsoleColor.Yellow, 1000);
            Util.Print("선택은 당신 몫입니다.", 1000);
        }


        public override void Choice()
        {
            Console.WriteLine("1. 위험을 무릅쓰고 남을 도울 여유는 없다.");
            Console.WriteLine("2. 적어도 아파트 복도와 계단을 지키기 위해 도움을 준다.");
        }

        public override void Result()
        {
            switch(input)
            {
                case (ConsoleKey.D1):
                    Console.WriteLine("위험한 일에 몫숨을 걸 수는 없다...");
                    Console.WriteLine("상황을 지켜보며 생존을 우선시한다.");
                    break;
                case (ConsoleKey.D2):
                    Console.WriteLine("우리의 집은 우리가 지켜야 한다...");
                    Console.WriteLine("당신은 얼른 문단속을 하며 집 밖으로 나섰습니다.");
                    Console.WriteLine("체온이 1 감소했습니다.");
                    Game.Player.Temperature--;
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
                    {
                        Game.ChangeScene("Home3");
                        break;
                    }
                case (ConsoleKey.D2):
                    {
                        Game.ChangeScene("Gate");
                        break;
                    }
            }
        }
    }
}
