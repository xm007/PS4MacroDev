using PS4MacroAPI;
using System.Collections.Generic;


namespace AutoFarmSlimeMission
{
    public class MainScript : ScriptBase
    {
        public bool turboX = true;
        public bool turboAttack = false;
        public MainScript()
        {
            Config.Name = "AutoFarmSlimeMission";
            Config.Scenes = new List<Scene>()
            {
                new RestartScene(),
                new ReportScene(),
                //难以检测,弃用
                //new FightEndScene(),
                new FightScene()
            };
        }
        public override void Update()
        {
            if (turboAttack)
            {
                System.Console.WriteLine("Start Attack!!");
                //开始连按三分钟三角
                for (int i = 0; i < 112; i++)
                {
                    Press(new DualShockState() { Triangle = true });
                    Sleep(1600);
                }
                System.Console.WriteLine("Attack End!!");
                turboAttack = false;
            }
                HandleScenes(scene => { System.Console.WriteLine(scene.Name); });
        }
    }
}
