using Terraria.ModLoader;
using Terraria.ID;

namespace BuffCharm
{
    class BuffCharmBuff : GlobalBuff
    {
        public override void ModifyBuffTip(int type, ref string tip, ref int rare)
        {
            if (type == BuffID.Rage)
            {
                tip = "10% increased critical chance\nAllows minions to crit";
            }
        }
    }
}
