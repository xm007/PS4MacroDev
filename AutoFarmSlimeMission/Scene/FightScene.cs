using PS4MacroAPI;

namespace AutoFarmSlimeMission
{
    class FightScene : Scene
    {
        public override string Name => "FightScene";

        public static RectMap QuestStart = new RectMap()
        {
            X = 186,
            Y = 309,
            Width = 636,
            Height = 109,
            Hash = 18119399714013055
        };

        public static PixelMap QuestStart_BlackPixelOnTheFloor = new PixelMap()
        {
            X = 651,
            Y = 628,
            Color = 0x0B0503
        };

        public override bool Match(ScriptBase script)
        {
            return script.MatchTemplate(QuestStart, 90) && script.MatchTemplate(QuestStart_BlackPixelOnTheFloor, 98);
        }

        public override void OnMatched(ScriptBase script)
        {
            var _script = script as MainScript;
            _script.turboAttack = true;
        }
    }
}