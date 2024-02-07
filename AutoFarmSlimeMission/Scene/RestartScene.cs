using PS4MacroAPI;

namespace AutoFarmSlimeMission
{
    public class RestartScene : Scene
    {
        public override string Name => "RestartScene";

        public static PixelMap IsFightAgain_Shi = new PixelMap()
        {
            X = 439,
            Y = 348,
            Color = 0xD3D9DA
        };

        public static PixelMap IsFightAgain_QuestionMark = new PixelMap()
        {
            X = 569,
            Y = 348,
            Color = 0xC3C7CE
        };

        public override bool Match(ScriptBase script)
        {
            return script.MatchTemplate(IsFightAgain_Shi, 99) && script.MatchTemplate(IsFightAgain_QuestionMark, 99);
        }

        public override void OnMatched(ScriptBase script)
        {
            var _script = script as MainScript;
            _script.turboX = false;
            _script.turboAttack = false;
            script.Sleep(150);
            script.Press(new DualShockState() { DPad_Up = true });
            script.Sleep(150);
            script.Press(new DualShockState() { Cross = true });
            _script.turboX = true;
        }
    }
}