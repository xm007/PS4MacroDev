using PS4MacroAPI;

namespace AutoRestartMissionPlus
{
    class ReportScene : Scene
    {
        public override string Name => "ReportScene";

        public static RectMap Continue = new RectMap()
        {
            X = 869,
            Y = 611,
            Width = 40,
            Height = 13,
            Hash = 28551497049403200
        };

        public override bool Match(ScriptBase script)
        {
            return script.MatchTemplate(Continue, 90);
        }

        public override void OnMatched(ScriptBase script)
        {
            var _script = script as MainScript;
            if (_script.turboX)
            {
                script.Press(new DualShockState() { Cross = true });
                script.Sleep(500);
                script.Press(new DualShockState() { Cross = true });
                script.Sleep(500);
            }
        }
    }
}
