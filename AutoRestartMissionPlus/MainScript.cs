using PS4MacroAPI;
using System.Collections.Generic;

namespace AutoRestartMissionPlus
{
    public class MainScript : ScriptBase
    {
        public bool turboX = true;
        public MainScript()
        {
            Config.Name = "AutoRestartMissionPlus";
            Config.Scenes = new List<Scene>()
            {
                new RestartScene(),
                new ReportScene()
            };
        }
        public override void Update()
        {
            HandleScenes();
        }
    }
}
