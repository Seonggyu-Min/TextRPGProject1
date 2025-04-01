using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textRPG
{
    public static class Game
    {

        private static bool gameOver = false;

        private static Dictionary<string, Scenes.Scenes> sceDic;
        private static Scenes.Scenes currScn;

        private static Player player;
        public static Player Player { get { return player; } }

        public static List<string> inventory = new List<string>();
        public static List<string> companion = new List<string>();


        public static void Start()
        {
            sceDic = new Dictionary<string, Scenes.Scenes>();
            sceDic.Add("Title", new Scenes.Title());
            sceDic.Add("Home", new Scenes.Home());
            sceDic.Add("Home2", new Scenes.Home2());
            sceDic.Add("Home3", new Scenes.Home3());
            sceDic.Add("Gate", new Scenes.Gate());
            sceDic.Add("Home4", new Scenes.Home4());
            sceDic.Add("Home2_1", new Scenes.Home2_1());
            sceDic.Add("Inside", new Scenes.Inside());
            sceDic.Add("Chemistry", new Scenes.Chemistry());
            sceDic.Add("WalkieTalkie", new Scenes.WalkieTalkie());


            currScn = sceDic["Title"];

            player = new Player();
            player.Health = 3;
            player.Rest = 3;
            player.Temperature = 3;
            player.Hunger = 3;
        }

        public static void Run() 
        {
            while (gameOver == false)
            {
                Console.Clear();
                currScn.Render();
                Console.WriteLine();
                currScn.Choice();
                currScn.Input();
                Console.WriteLine();
                currScn.Result();
                Console.WriteLine();
                currScn.Wait();
                currScn.Next();
            }
        }

        public static void End()
        {
            Console.WriteLine($"당신의 체력: {player.Health}, 당신의 휴식: {player.Rest}, 당신의 체온: {player.Temperature}, 당신의 허기: {player.Hunger}");

            Console.WriteLine("=============================================");
            Console.WriteLine("                  GAME END                   ");
            Console.WriteLine("=============================================");
            gameOver = true;
        }

        public static void ChangeScene(string sceneName)
        {
            currScn = sceDic[sceneName];
        }


        public static void GameOver(string reason)
        {
            Console.Clear();
            Console.WriteLine("게임 오버");
            Console.WriteLine($"{reason}");

            gameOver = true;
        }

        public static void PrintInfo()
        {
            Console.WriteLine("=============================================");
            Console.WriteLine("플레이어 상태");
            Console.Write("체력: ");
            for (int i = 0; i < player.Health; i++)
                Console.Write('■');

            for (int i = 0; i < 5 - player.Health; i++)
                Console.Write('□');

            Console.WriteLine();

            Console.Write("휴식: ");
            for(int i = 0; i < player.Rest; i++)
                Console.Write('■');

            for (int i = 0; i < 5 - player.Rest; i++)
                Console.Write('□');

            Console.WriteLine();

            Console.Write("허기: ");
            for (int i = 0; i < player.Hunger; i++)
                Console.Write('■');

            for (int i = 0; i < 5 - player.Hunger; i++)
                Console.Write('□');

            Console.WriteLine();

            Console.Write("체온: ");
            for (int i = 0; i < player.Temperature; i++)
                Console.Write('■');

            for (int i = 0; i < 5 - player.Temperature; i++)
                Console.Write('□');

            Console.WriteLine();
            Console.WriteLine("=============================================");
            Console.WriteLine();
        }

    }
}
