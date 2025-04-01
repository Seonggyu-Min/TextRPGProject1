using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textRPG.Scenes
{
    public class Home : Scenes
    {
        public override void Render()
        {
            Game.PrintInfo();
            Util.Print("당신은 좀비로 가득찬 세상에서 살아남아야 합니다...", 1000);
            Util.Print("적절한 선택을 통해 당신의 체력, 허기, 휴식, 체온을 유지하여 살아남으세요...", 1000);
            Util.Print("추운 겨울 어느 날 밤... 당신의 집으로 좀비가 몰려들고 있습니다... 어떻게 하시겠습니까?", ConsoleColor.Red, 1000);
        }

        public override void Choice()
        {
            Console.WriteLine("1. 우선 집에서 벗어난다.");
            Console.WriteLine("2. 집 문을 걸어잠그고 버티며 구조를 기다린다.");
        }


        public override void Result()
        {
            switch (input)
            {
                case (ConsoleKey.D1):
                    {
                        Console.WriteLine("밖은 춥고 어둡지만 기다기만해서는 살아남을 수 없습니다...");
                        Console.WriteLine("당신은 고통을 감내하고 살아남을 길을 찾아나섭니다.");
                        Util.Print("휴식과 체온이 1씩 떨어집니다...");
                        Game.Player.Rest--;
                        Game.Player.Temperature--;
                        break;
                    }
                case (ConsoleKey.D2):
                    {
                        Console.WriteLine("밖은 춥고 위험이 도사릴 뿐입니다...");
                        Console.WriteLine("당신은 집에서 물자를 정리하며 최대한 버틸 준비를 합니다.");
                        break;
                    }
                default:
                    
                    break;
            }
        }

        public override void Wait()
        {
            if (!(input == ConsoleKey.D1 || input == ConsoleKey.D2))
            {
                Console.WriteLine("잘못 누르셨습니다.");
                Console.WriteLine("숫자를 눌러주세요.");
            }
            else
            {
                Console.WriteLine("계속하려면 아무 키나 누르십시오.");
                Console.ReadKey();
            }
                
        }

        public override void Next()
        {
            switch (input)
            {
                case (ConsoleKey.D1):
                    {
                        Game.ChangeScene("Outside");
                        break;
                    }
                case (ConsoleKey.D2):
                    {
                        Game.ChangeScene("Home2");
                        break;
                    }
            }
        }
    }
}
