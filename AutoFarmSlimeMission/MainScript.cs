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
                new FightEndScene(),
                new FightScene()
            };
        }
        public override void Update()
        {
            if (turboAttack)
            {
                Press(new DualShockState() { Triangle = true });
                Sleep(150);
            }
            HandleScenes();
        }
    }
}
