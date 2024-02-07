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

        public static RectMap TimeUp = new RectMap() 
        {
            X = 382,
            Y = 336,
            Width = 244,
            Height = 54,
            Hash = 35887507611321456
        };

        public override bool Match(ScriptBase script)
        {
            return script.MatchTemplate(ZeroOut, 85) && script.MatchTemplate(TimeUp, 85);
        }

        public override void OnMatched(ScriptBase script)
        {
            var _script = script as MainScript;
            _script.turboAttack = false;
        }
    }
}