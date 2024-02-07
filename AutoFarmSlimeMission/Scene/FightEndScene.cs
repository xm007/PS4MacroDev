using PS4MacroAPI;

namespace AutoFarmSlimeMission
{
    class FightEndScene : Scene
    {
        public override string Name => "FightScene";

        public static RectMap ZeroOut = new RectMap()
        {
            X = 929,
            Y = 150,
            Width = 28,
            Height = 10,
            Hash = 5030498289062760261
        };

        public static RectMap BattleResult = new RectMap()
        {
            X = 57,
            Y = 105,
            Width = 380,
            Height = 35,
            Hash = 36027695334166548
        };

        public override bool Match(ScriptBase script)
        {
            return script.MatchTemplate(ZeroOut, 95) || script.MatchTemplate(BattleResult, 90);
        }

        public override void OnMatched(ScriptBase script)
        {
            var _script = script as MainScript;
            _script.turboAttack = false;
        }
    }
}