using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textRPG.Scenes
{
    public class Home3 : Scenes
    {
        public override void Render()
        {
            Game.PrintInfo();
            Util.Print("좀비가 집 밖을 서성이기 시작한 후로부터 며칠이 흘렀습니다.", 1000);
            Util.Print("당신은 그날 밤도 여느 때 처럼 집 밖의 좀비 소리로부터 밤잠을 뒤척이고 있습니다.", 1000);
            Util.Print("오늘 밤의 소음는 유난히 크게 들리는 것 같습니다...", ConsoleColor.Yellow, 1000);
            Util.Print("당신은 그 소음이 몇 층 아래가 아닌 문 앞에서 난다는 것을 알기까지 오래걸리지 않았습니다.", ConsoleColor.Red, 1000);
            Util.Print("부서질 듯 요란한 소리를 내는 문은 당신을 혼란스럽게 합니다.", ConsoleColor.Red, 1000);
            Util.Print("그러나 패닉에 빠진 것도 잠시 당신은 결단을 내립니다.", 1000);
        }


        public override void Choice()
        {
            Console.WriteLine("1. [인벤토리: 무전기] 현관에서 만났던 아저씨에게 도움을 요청한다.");
            Console.WriteLine("2. [npc: 남학생] 아이를 깨워 함께 도움을 요청한다.");
            Console.WriteLine("3. 문을 막기 위해 가구를 옮긴다.");
            Console.WriteLine("4. 장롱 속으로 숨는다.");
        }

        public override void Result()
        {
            switch (input)
            {
                case (ConsoleKey.D1):
                    if (!Game.inventory.Contains("무전기"))
                    {
                        Console.WriteLine("인벤토리에 무전기가 없습니다.");
                        Console.WriteLine("고를 수 없는 선택지입니다.");
                        break;
                    }
                    Console.WriteLine("당신은 듬직한 기술자 아저씨가 준 무전기가 떠올랐습니다.");
                    Console.WriteLine("아저씨가 무전을 받기를 기도하며 무전을 시작합니다...");
                    break;
                case (ConsoleKey.D2):
                    if (!Game.companion.Contains("남학생"))
                    {
                        Console.WriteLine("동반자에 남학생이 없습니다.");
                        Console.WriteLine("고를 수 없는 선택지입니다.");
                        break;
                    }
                    Console.WriteLine("당신은 아이에게 달려가 도움을 요청합니다.");
                    Console.WriteLine("아이는 잠에서 막 깨어났지만 그의 명석한 두뇌로 빠르게 상황을 파악합니다...");
                    break;
                case (ConsoleKey.D3):
                    {
                        Console.WriteLine("당신은 후들거리는 다리를 이끌고 문 앞을 막기 시작합니다...");
                        Console.WriteLine("문 앞을 다 막아갈 때 쯤 당신은 안도감과 함께 급격한 피로를 느낍니다...");
                        Console.WriteLine("휴식과 허기가 1씩 감소했습니다.");
                        Game.Player.Rest--;
                        Game.Player.Hunger--;
                        break;
                    }
                case (ConsoleKey.D4):
                    {
                        Console.WriteLine("당신은 온 몸이 굳어 도망칠 생각을 합니다...");
                        Console.WriteLine("좀비가 집에 들어와 자신을 찾지 못할 것만을 기도하며 장롱 속으로 숨습니다...");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("잘못된 입력입니다.");
                        break;
                    }
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
                        Game.ChangeScene("WalkieTalkie");
                        break;
                    }
                case (ConsoleKey.D2):
                    {
                        Game.ChangeScene("Chemisty");
                        break;
                    }
                case (ConsoleKey.D3):
                    {
                        Game.ChangeScene("Home4");
                        break;
                    }
                case (ConsoleKey.D4):
                    {
                        Game.ChangeScene("Inside");
                        break;
                    }
            }
        }
    }
}
