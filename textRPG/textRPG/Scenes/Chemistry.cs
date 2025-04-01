using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textRPG.Scenes
{
    class Chemistry : Scenes
    {
        public override void Render()
        {
            Game.PrintInfo();
            Util.Print("아이는 금방이라도 부서질 듯한 문을 보며 생각하기 시작합니다.", 1000);
            Util.Print("집을 둘러보던 아이는 소금물, 알류미늄 호일, 라이터 그리고 전자레인지를 가져다달라고 부탁합니다.", 1000);
            Util.Print("아무리 생각해도 의아한 당신이지만 급한대로 준비를 합니다.", 1000);
            Util.Print("아이는 문 앞에 전자레인지를 연결하고 호일과 소금물을 함께 전자레인지에 넣어 돌리기 시작합니다.", ConsoleColor.Yellow, 1000);
            Util.Print("전자레인지 내부가 들끓으면서 문 또한 부서지기 직전입니다!!", ConsoleColor.Red, 1000);
            Util.Print("문이 부서짐과 동시에 아이는 라이터를 던져 전자레인지 내부를 폭발시킵니다!!", ConsoleColor.Red, 1000);
            Util.Print("아이는 화학에 대해 천재적인 재능이 있는 것으로 보입니다...", 1000);
            Util.Print("도움 덕분에 살아남은 당신은 창 밖에서 확성기 소리를 듣습니다...", 1000);
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
