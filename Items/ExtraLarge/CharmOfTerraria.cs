using BuffCharm.Items.Large;
using Terraria.ID;
using Terraria.ModLoader;

namespace BuffCharm.Items.ExtraLarge
{
    class CharmOfTerraria: _BaseLargeCharm
    {
        public override string Description => "Grants most vanilla buffs while equipped\nDisable any buffs you don't want by right clicking its icon\n'You feel overpowered'";

        public override bool CanBeCraftedFromTicket => false;
        public override int[] Buffs => new int[] 
        { 
            BuffID.AmmoReservation, BuffID.Archery, BuffID.Builder, BuffID.Crate, BuffID.Dangersense, BuffID.Endurance, BuffID.Featherfall,
            BuffID.Fishing, BuffID.Flipper, BuffID.Gills, BuffID.Gravitation, BuffID.Hunter, BuffID.Inferno, BuffID.Ironskin, BuffID.Lifeforce,
            BuffID.MagicPower, BuffID.ManaRegeneration, BuffID.Mining, BuffID.NightOwl, BuffID.ObsidianSkin, BuffID.Rage, BuffID.Regeneration,
            BuffID.Shine, BuffID.Sonar, BuffID.Spelunker, BuffID.Summoning, BuffID.Swiftness, BuffID.Thorns, BuffID.Titan, BuffID.Warmth,
            BuffID.WaterWalking, BuffID.Wrath
        };
        public override int[,] CharmsCraftedFrom => new int[,]
        {
            {
                ModContent.ItemType<CharmOfAres>(),
                ModContent.ItemType<CharmOfApollo>(),
                ModContent.ItemType<CharmOfAthena>(),
                ModContent.ItemType<CharmOfArtemis>(),
                ModContent.ItemType<CharmOfTheCorruption>(),
                ModContent.ItemType<CharmOfTheCrimson>(),
                ModContent.ItemType<CharmOfTheTurtle>(),
                ModContent.ItemType<CharmOfTheUnderworld>(),
                ModContent.ItemType<CharmOfSight>(),
                ModContent.ItemType<CharmOfTheDwarf>(),
                ModContent.ItemType<CharmOfTheCosmos>(),
                ModContent.ItemType<CharmOfTheSea>(),
                ModContent.ItemType<CharmOfTheAngler>()
            }
        };
    }
}
