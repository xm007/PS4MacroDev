using PS4MacroAPI;
using System.Collections.Generic;


namespace AutoFarmSlimeMission
{
    public class MainScript : ScriptBase
    {
        public MyForm form;
        public bool turboX = true;
        public bool turboAttack = false;

        public static bool IsCagliostro { get; set; }
        public static bool IsEugen { get; set; }
        public MainScript()
        {
            Config.Name = "AutoFarmSlimeMission";
            Config.Scenes = new List<Scene>()
            {
                new RestartScene(),
                new ReportScene(),
                new NextRoundScene(),
                //难以检测,弃用
                //new FightEndScene(),
                new FightScene()
            };

            ScriptForm = form = new MyForm();
            form.Show();
        }

        public override void Update()
        {
            if (turboAttack)
            {
                if (IsEugen)
                {
                    System.Console.WriteLine("Start Fight");
                    Press(new DualShockState() { LY = 0x0 },4000);
                    //开始连按三分钟方框
                    for (int i = 0; i < 202; i++)
                    {
                        System.Console.WriteLine(200-i);
                        Press(new DualShockState() { Square = true });
                        //850
                        Sleep(600);
                    }
                }
                else if (IsCagliostro)
                {
                    System.Console.WriteLine("Start Fight");
                    //开始连按三分钟三角
                    for (int i = 0; i < 109; i++)
                    {
                        System.Console.WriteLine(112 - i);
                        Press(new DualShockState() { Triangle = true });
                        //1600
                        Sleep(1500);
                    }
                }
                System.Console.WriteLine("End Fight");
                turboAttack = false;
            }
                HandleScenes(scene => { System.Console.WriteLine(scene.Name); });
        }
    }
}
