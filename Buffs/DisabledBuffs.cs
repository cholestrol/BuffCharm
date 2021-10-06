using Terraria;
using Terraria.ModLoader;

namespace BuffCharm.Buffs
{
    public class DisabledBuffs : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Disabled Buffs");
            Description.SetDefault("You have disabled some buffs that would normally be granted to you by your charms\nDisable this buff by right clicking to re-enable them");
            Main.buffNoTimeDisplay[Type] = true;
            Main.debuff[Type] = false;
        }
    }
}
