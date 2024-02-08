using PS4MacroAPI;

namespace AutoFarmSlimeMission
{
    class NextRoundScene : Scene
    {
        public override string Name => "NextRoundScene";

        public static PixelMap NextRound_QuestionMark = new PixelMap()
        {
            X = 562,
            Y = 348,
            Color = 0xA5ADB7
        };

        public static PixelMap NextRound_Yes_LeftBluePixel = new PixelMap()
        {
            X = 496,
            Y = 436,
            Color = 0x6CE2FF
        };

        public override bool Match(ScriptBase script)
        {
            return script.MatchTemplate(NextRound_QuestionMark, 98) && script.MatchTemplate(NextRound_Yes_LeftBluePixel, 98);
        }

        public override void OnMatched(ScriptBase script)
        {
            var _script = script as MainScript;
            _script.turboAttack = false;
            if (_script.turboX)
            {
                script.Press(new DualShockState() { Cross = true });
            }
        }
    }
}
