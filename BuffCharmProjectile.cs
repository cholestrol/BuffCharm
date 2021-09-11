using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace BuffCharm
{
    class BuffCharmProjectile : GlobalProjectile
    {
        public override void ModifyHitNPC(Projectile projectile, NPC target, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
        {
            if (projectile.minion && Main.player[projectile.owner].HasBuff(BuffID.Rage))
            {
                if (Main.rand.Next(10) == 0)
                {
                    crit = true;
                }
            }
        }
    }
}
